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
using System.Data;
using System.IO;

namespace LabTestResults
{
    /// <summary>
    /// Interaction logic for InsertCarbohydrateMetabolismWindow.xaml
    /// </summary>
    public partial class InsertCarbohydrateMetabolismWindow : Window
    {
        public InsertCarbohydrateMetabolismWindow()
        {
            InitializeComponent();
        }

        private void addTestResult(object sender, RoutedEventArgs e)
        {
             try
            {
                ITestResultRepository testResultRepository = new TestResultRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);

                var parameters = new[]
                {
                    new SqlParameter(StoredProcedureParameters.Id, PatientRepository.PatientId),
                    new SqlParameter(StoredProcedureParameters.NameOfTest, "Carbohydrate Metabolism Test"),
                    new SqlParameter(StoredProcedureParameters.SpDateOfResult, Calendar.ToString()),
                    new SqlParameter(StoredProcedureParameters.Glucose, Convert.ToDouble(txtGlucose.Text)),
                    new SqlParameter(StoredProcedureParameters.SialAcid, Convert.ToDouble(txtSialAcid.Text)),
                    new SqlParameter(StoredProcedureParameters.LacticAcid, Convert.ToDouble(txtLacticAcid.Text)),
                  
                };
                testResultRepository.InsertCarbogydrateMetabolismTestResultInfo(CommandType.StoredProcedure,
                    StoredProcedureNames.SpInsertCarbohydrateMetabolismTestResultInfo, parameters);
                txtGlucose.Text = string.Empty;
                txtSialAcid.Text = string.Empty;
                txtLacticAcid.Text = string.Empty;
            
                carbohydrateWindow.Visibility = Visibility.Hidden;
                MessageBox.Show("Thank you, carbohydrate metabolism test result was succsesfully added");
               
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
