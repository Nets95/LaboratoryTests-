using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using PatientResults.DAL.Abstraction.Repositories;
using PatientResults.DAL.Concreate.Repositories;
using PatientResults.DAL.Concreate.SQL;
using PatientTestResult.Parser.PatientInfoParser;
using PatientTestResult.Parser.TestResultParser;
using PatientTestResult.Model.PatientModels;
using System.IO;



namespace LabTestResults
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }
        
        private string _nameOfWindow;

        public string NameOfWindow 
        {
            get { return _nameOfWindow; }
            set { _nameOfWindow = value; }
        }

        private void searchByNameOfPatient(object sender, RoutedEventArgs e)
        {
            try
            {
                IPatientRepository patientRepository = new PatientRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);

                string[] nameOfPatient = NameOfPatient.Text.Split(' ');
                var parameters = new[]
            {
                new SqlParameter(StoredProcedureParameters.spName, nameOfPatient[0]),
                new SqlParameter(StoredProcedureParameters.spLastName, nameOfPatient[1])
            };

                var result = patientRepository.ExecuteReader(StoredProcedureNames.SpGetPatientResultByName, PatientInfoParser.Instance.MakeResult, parameters);
                DataTable dataTable = result.ConvertToDataTable();
                dataGrid.ItemsSource = dataTable.DefaultView;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enablePatientRegistrationWindow(object sender, RoutedEventArgs e)
        {
            AddNewPatient registerForm = new AddNewPatient();
            registerForm.Show(); 
        }

        private void exitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void showAllPatientsClick(object sender, RoutedEventArgs e)
        {
            IPatientRepository patientRepository = new PatientRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);
            var result = patientRepository.ExecuteReaderWithOutParameters(StoredProcedureNames.SpGetAllPatients, PatientInfoParser.Instance.MakeResult);
            DataTable dataTable = result.ConvertToDataTable();
            dataGrid.ItemsSource = dataTable.DefaultView;
        }
       
        private void addPatientTestResult(object sender, RoutedEventArgs e)
        {

            if (NameOfWindow == "Urina Test")
            {
                InsertUrinaTestResultWindow urinaWindow = new InsertUrinaTestResultWindow();
                urinaWindow.Show();
            }
            if (NameOfWindow == "General Blood Test")
            {
                InsertGeneralBloodWindow generalBloodWindow = new InsertGeneralBloodWindow();
                generalBloodWindow.Show();
            }
            if (NameOfWindow == "Carbohydrate Metabolism Test")
            {
                InsertCarbohydrateMetabolismWindow carbohydrateWindow = new InsertCarbohydrateMetabolismWindow();
                carbohydrateWindow.Show();
            }
            if (NameOfWindow == "Protein Metabolism Test")
            {
                InsertProteinMetabolismWindow proteinWindow = new InsertProteinMetabolismWindow();
                proteinWindow.Show();
            }
            if (NameOfWindow == "Vitamins Test")
            {
                InsertVitaminsWindow vitaminsWindow = new InsertVitaminsWindow();
                vitaminsWindow.Show();
            }          
        }

        private void selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < dataGrid.SelectedItems.Count; i++)
                {
                    var selectedFile = (System.Data.DataRowView)dataGrid.SelectedItems[i];
                    NameOfWindow = Convert.ToString(selectedFile.Row.ItemArray[11]);
                    PatientRepository.PatientId = Convert.ToInt32(selectedFile.Row.ItemArray[12]);
                    PatientRepository.PatientName = Convert.ToString(selectedFile.Row.ItemArray[0]);
                    PatientRepository.PatientLastName = Convert.ToString(selectedFile.Row.ItemArray[1]);
                }
            }
        }

        private void showPatientTestResultClick(object sender, RoutedEventArgs e)
        {
            ShowTestResults testResultWindow = new ShowTestResults();
            testResultWindow.Show();
        }

        private void searchByNameOfTest(object sender, RoutedEventArgs e)
        {
            IPatientRepository patientRepository = new PatientRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);
            ComboBoxItem cmItem = (ComboBoxItem)testsComboBox.SelectedItem;
            string nameOfTest = cmItem.Content.ToString();
            var parameters = new[]
            {
                new SqlParameter(StoredProcedureParameters.SpNameTest, nameOfTest)
            };
           
            var result = patientRepository.ExecuteReader(StoredProcedureNames.SpGetPatientResultByNameOfTest, PatientInfoParser.Instance.MakeResult, parameters);
            DataTable dataTable = result.ConvertToDataTable();
            dataGrid.ItemsSource = dataTable.DefaultView;
        }

        private void searchByNameOfAsistent(object sender, RoutedEventArgs e)
        {
            IPatientRepository patientRepository = new PatientRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);
            ComboBoxItem cmItem = (ComboBoxItem)asistantsComboBox.SelectedItem;
            string str = cmItem.Content.ToString();
            string[] nameOfAsistent = str.Split(' '); 
            var parameters = new[]
            {
                new SqlParameter(StoredProcedureParameters.SpNameOfAsistant, nameOfAsistent[0]),
                new SqlParameter(StoredProcedureParameters.SpLastNameOfAsistant, nameOfAsistent[1])

            };

            var result = patientRepository.ExecuteReader(StoredProcedureNames.SpGetAllPatientsByNameOfAsistent, PatientInfoParser.Instance.MakeResult, parameters);
            DataTable dataTable = result.ConvertToDataTable();
            dataGrid.ItemsSource = dataTable.DefaultView;
        }

        private void deletePatient(object sender, RoutedEventArgs e)
        {
            IPatientRepository patientRepository = new PatientRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);
           
            var parameters = new[]
            {
                new SqlParameter(StoredProcedureParameters.Id, PatientRepository.PatientId)
            };

            var result = patientRepository.ExecuteReader(StoredProcedureNames.SpDeletePatientById, PatientInfoParser.Instance.MakeResult, parameters);
            MessageBox.Show("Patient succsesfully deleted!");
        }
    }
}




