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
using System.Windows.Shapes;
using PatientResults.DAL.Abstraction.Repositories;
using PatientResults.DAL.Concreate.Repositories;
using PatientResults.DAL.Concreate.SQL;
using System.Configuration;
using System.Data.SqlClient;
using PatientResults.DAL.Concreate.SQL;
using System.Data;
using PatientResults.DAL.Concreate.Repositories;
using System.IO;


namespace LabTestResults
{
    /// <summary>
    /// Interaction logic for InsertUrinaTestResultWindow.xaml
    /// </summary>
    public partial class InsertUrinaTestResultWindow : Window
    {
        public InsertUrinaTestResultWindow()
        {
            InitializeComponent();
        }

        private void addUrinaTestResult(object sender, RoutedEventArgs e)
        {
            try
            {
                ITestResultRepository testResultRepository = new TestResultRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);
                var parameters = new[]
                {
                    new SqlParameter(StoredProcedureParameters.Id, PatientRepository.PatientId),
                    new SqlParameter(StoredProcedureParameters.NameOfTest, "Urina Test"),
                    new SqlParameter(StoredProcedureParameters.SpDateOfResult, Calendar.ToString()),
                    new SqlParameter(StoredProcedureParameters.PhValue, Convert.ToDouble(txtPhValue.Text)),
                    new SqlParameter(StoredProcedureParameters.Protein, Convert.ToDouble(txtProteint.Text)),   
                    new SqlParameter(StoredProcedureParameters.Sugar, Convert.ToDouble(txtSugar.Text)),
                    new SqlParameter(StoredProcedureParameters.Nitrite, Convert.ToDouble(txtNitrine.Text)),
                    new SqlParameter(StoredProcedureParameters.Ketone, Convert.ToDouble(txtKetone.Text)),
                    new SqlParameter(StoredProcedureParameters.Bilirubin, Convert.ToDouble(txtBilirubin.Text)),
                    new SqlParameter(StoredProcedureParameters.Urobilinogen, Convert.ToDouble(txtUrobilinogen.Text)),
                    new SqlParameter(StoredProcedureParameters.RedBloodCells, Convert.ToDouble(txtRedBloodCells.Text)),
                    new SqlParameter(StoredProcedureParameters.WhiteBloodCells, Convert.ToDouble(txtWhiteBloodCells.Text)), 
                };

                testResultRepository.InsertUrinaTestResultInfo(CommandType.StoredProcedure,
                StoredProcedureNames.SpInsertUrinaTestResultInfo, parameters);
                txtPhValue.Text = string.Empty;
                txtProteint.Text = string.Empty;
                txtSugar.Text = string.Empty;
                txtNitrine.Text = string.Empty;
                txtKetone.Text = string.Empty;
                txtBilirubin.Text = string.Empty;
                txtUrobilinogen.Text = string.Empty;
                txtRedBloodCells.Text = string.Empty;
                txtWhiteBloodCells.Text = string.Empty;
                InsertUrinaTestResultWindow urinaWindow = new InsertUrinaTestResultWindow();
                MessageBox.Show("Thank you, urina test result was succsesfully added");
                urinaWindow.Visibility = Visibility.Hidden;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
