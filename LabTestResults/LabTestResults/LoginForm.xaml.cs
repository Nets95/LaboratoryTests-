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
using PatientTestResult.Parser.PatientInfoParser;
using PatientTestResult.Parser.UserParser;
using PatientTestResult.Model.UserModel;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace LabTestResults
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void logIn(object sender, RoutedEventArgs e)
        {
            try
            {

                IUserRepository userRepository = new UserRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);

                var parameters = new[]
            {
                new SqlParameter(StoredProcedureParameters.SpLogin, txtLogin.Text),
                new SqlParameter(StoredProcedureParameters.SpPassword, txtPassword.Text),
            };

                var result = userRepository.ExecuteReader(StoredProcedureNames.SpGetUserByLoginQuery, UserParser.Instance.MakeResult, parameters);
                if (result.Count() != 0)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    loginW.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Incorrect Password or Login");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
