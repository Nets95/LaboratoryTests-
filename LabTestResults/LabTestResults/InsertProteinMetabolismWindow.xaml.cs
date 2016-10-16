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
    /// Interaction logic for InsertProteinMetabolismWindow.xaml
    /// </summary>
    public partial class InsertProteinMetabolismWindow : Window
    {
        public InsertProteinMetabolismWindow()
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
                    new SqlParameter(StoredProcedureParameters.NameOfTest, "Protein Metabolism Test"),
                    new SqlParameter(StoredProcedureParameters.SpDateOfResult, Calendar.ToString()),
                    new SqlParameter(StoredProcedureParameters.GeneralProtein, Convert.ToDouble(txtGeneralProtein.Text)),
                    new SqlParameter(StoredProcedureParameters.Albumin, Convert.ToDouble(txtAlbumin.Text)),
                    new SqlParameter(StoredProcedureParameters.Globulin, Convert.ToDouble(txtGlobulin.Text)),
                    new SqlParameter(StoredProcedureParameters.Fibrinogen, Convert.ToDouble(txtFibrinogen.Text)),
                    new SqlParameter(StoredProcedureParameters.Creatinine, Convert.ToDouble(txtCreatinin.Text)),
                    new SqlParameter(StoredProcedureParameters.CreatineKinase, Convert.ToDouble(txtCreatineKinase.Text)),
                    new SqlParameter(StoredProcedureParameters.Urea, Convert.ToDouble(txtUrea.Text)),
                    new SqlParameter(StoredProcedureParameters.UreaAcid, Convert.ToDouble(txtUreaAcid.Text))
                };

                testResultRepository.InsertProteinMetabolismTestResultInfo(CommandType.StoredProcedure,
                     StoredProcedureNames.SpInsertProteinMetabolismTestresultInfo, parameters);
                txtGeneralProtein.Text = string.Empty;
                txtAlbumin.Text = string.Empty;
                txtGlobulin.Text = string.Empty;
                txtFibrinogen.Text = string.Empty;
                txtCreatinin.Text = string.Empty;
                txtCreatineKinase.Text = string.Empty;
                txtUrea.Text = string.Empty;
                txtUreaAcid.Text = string.Empty;

                proteinMetabolism.Visibility = Visibility.Hidden;
                MessageBox.Show("Thank you, protein metabolism test result was succsesfully added");
               
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
