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
    /// Interaction logic for InsertVitaminsWindow.xaml
    /// </summary>
    public partial class InsertVitaminsWindow : Window
    {
        public InsertVitaminsWindow()
        {
            InitializeComponent();
        }

        private void addPatientResult(object sender, RoutedEventArgs e)
        {
            try
            {
                ITestResultRepository testResultRepository = new TestResultRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);

                var parameters = new[] 
                {
                    new SqlParameter(StoredProcedureParameters.Id, PatientRepository.PatientId),
                    new SqlParameter(StoredProcedureParameters.NameOfTest, "Test Test"),
                    new SqlParameter(StoredProcedureParameters.SpDateOfResult, Calendar.ToString()),
                    new SqlParameter(StoredProcedureParameters.Kaltsydol, Convert.ToDouble(txtCaltsydol.Text)),
                    new SqlParameter(StoredProcedureParameters.Cobalamin, Convert.ToDouble(txtCobalamin.Text)),
                    new SqlParameter(StoredProcedureParameters.FolicAcid, Convert.ToDouble(txtFoliAcid.Text)),
                    new SqlParameter(StoredProcedureParameters.Pyridoxine, Convert.ToDouble(txtPyridoxin.Text)),
                    new SqlParameter(StoredProcedureParameters.Retinol, Convert.ToDouble(txtRetinol.Text)),
                    new SqlParameter(StoredProcedureParameters.Tocopherol, Convert.ToDouble(txtTocopheron.Text))
                };

                testResultRepository.InsertVitaminsTestResultInfo(CommandType.StoredProcedure,
                    StoredProcedureNames.SpInsertVitaminsTestResultInfo, parameters);
                txtCaltsydol.Text = string.Empty;
                txtCobalamin.Text = string.Empty;
                txtFoliAcid.Text = string.Empty;
                txtPyridoxin.Text = string.Empty;
                txtRetinol.Text = string.Empty;
                txtTocopheron.Text = string.Empty;

                vitaminsWindow.Visibility = Visibility.Hidden;
                MessageBox.Show("Thank you, vitamins test result was succsesfully added");
               
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
