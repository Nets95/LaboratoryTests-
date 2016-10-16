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
using PatientTestResult.Parser.PatientInfoParser;
using PatientTestResult.Parser.TestResultParser;
using PatientTestResult.Model.PatientModels;


namespace LabTestResults
{
    /// <summary>
    /// Interaction logic for ShowTestResults.xaml
    /// </summary>
    public partial class ShowTestResults : Window
    {
        public ShowTestResults()
        {
            InitializeComponent();
            ITestResultRepository testResultRepository = new TestResultRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);
            var parameters = new[]
                {
                   new SqlParameter(StoredProcedureParameters.spName, PatientRepository.PatientName),
                   new SqlParameter(StoredProcedureParameters.spLastName, PatientRepository.PatientLastName)
                };
            var result = testResultRepository.ExecuteReader(StoredProcedureNames.SpGetPatientResultByName,
                TestResultParser.Instance.MakeResult, parameters);

            DataTable dataTable = result.ConvertToDataTable();
            dataGridTestResults.ItemsSource = dataTable.DefaultView;
        }
    }
}
