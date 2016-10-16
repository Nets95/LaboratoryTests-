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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using PatientResults.DAL.Abstraction.Repositories;
using PatientResults.DAL.Concreate.Repositories;
using PatientResults.DAL.Concreate.SQL;
using System.IO;


namespace LabTestResults
{
    /// <summary>
    /// Interaction logic for AddNewPatient.xaml
    /// </summary>
    public partial class AddNewPatient : Window
    {
        public AddNewPatient()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void AddPatientClick(object sender, RoutedEventArgs e)
        {

            try
            {

                IPatientRepository patientRepository = new PatientRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);
                string gender = " ";
                if (rbtnMale.IsChecked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                var parameters = new[]
                {
                           new SqlParameter(StoredProcedureParameters.SpName, txtName.Text),
                           new SqlParameter(StoredProcedureParameters.SpLastName, txtLastName.Text),
                           new SqlParameter(StoredProcedureParameters.SpGender, gender),
                           new SqlParameter(StoredProcedureParameters.SpDateOfBirth, Calendar.ToString()),
                           new SqlParameter(StoredProcedureParameters.SpPalceOfResidence, txtPlaceOfResistance.Text),
                           new SqlParameter(StoredProcedureParameters.SpBloodType, txtBloodType.Text),
                           new SqlParameter(StoredProcedureParameters.SpEmail, txtEmail.Text),
                           new SqlParameter(StoredProcedureParameters.SpPhoneNumber, txtPhoneNumber.Text)
                };
                patientRepository.InsertPatientsInfo(StoredProcedureNames.SpInsertPatient, parameters);
                ComboBoxItem cmItem = (ComboBoxItem)testsComboBox.SelectedItem;
                var registerParameters = new[]
                {
                    new SqlParameter(StoredProcedureParameters.SpNameOfTest, cmItem.Content),
                    new SqlParameter(StoredProcedureParameters.NameOfAsistant, "Nicolas"), 
                    new SqlParameter(StoredProcedureParameters.LastNameOfAsistant, "Browdi"),
                    new SqlParameter(StoredProcedureParameters.Name, txtName.Text),
                    new SqlParameter(StoredProcedureParameters.LastName, txtLastName.Text)
                };

                patientRepository.InsertPatientRegistrationInfo(StoredProcedureNames.SpInsertRegistration, registerParameters);
                AddPatientWindow.Visibility = Visibility.Hidden;
                MessageBox.Show("Patient was successfully added!");
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

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            AddPatientWindow.Close();
        }
    }
}


