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
    /// Interaction logic for InsertGeneralBloodWindow.xaml
    /// </summary>
    public partial class InsertGeneralBloodWindow : Window
    {
        public InsertGeneralBloodWindow()
        {
            InitializeComponent();
        }

        private void addTestREsult(object sender, RoutedEventArgs e)
        {
            try
            {
                ITestResultRepository testResultRepository = new TestResultRepository(ConfigurationManager.ConnectionStrings["ConnectionPatientResults"].ConnectionString);

                var parameters = new[]
              {
                    new SqlParameter(StoredProcedureParameters.Id, PatientRepository.PatientId),
                    new SqlParameter(StoredProcedureParameters.NameOfTest, "Gneral Blood Test"),
                    new SqlParameter(StoredProcedureParameters.SpDateOfResult, Calendar.ToString()),
                    new SqlParameter(StoredProcedureParameters.Erythrocytes, Convert.ToDouble(txtErytrocites.Text)),
                    new SqlParameter(StoredProcedureParameters.Hemoglobin, Convert.ToDouble(txtHemoglobin.Text)),
                    new SqlParameter(StoredProcedureParameters.Hematocrit, Convert.ToDouble(txtHematocrit.Text)),
                    new SqlParameter(StoredProcedureParameters.ColorIndicator, Convert.ToDouble(txtColorIndecator.Text)),
                    new SqlParameter(StoredProcedureParameters.Mch, Convert.ToDouble(txtMCH.Text)),
                    new SqlParameter(StoredProcedureParameters.Mchc, Convert.ToDouble(txtMCHC.Text)),
                    new SqlParameter(StoredProcedureParameters.Mcv, Convert.ToDouble(txtMCV.Text)),
                    new SqlParameter(StoredProcedureParameters.Rdw, Convert.ToDouble(txtRDW.Text)),
                    new SqlParameter(StoredProcedureParameters.AverageSizeErythrocytes, Convert.ToDouble(txtAveregeSize.Text)),
                    new SqlParameter(StoredProcedureParameters.Platelets, Convert.ToDouble(txtPlteles.Text)),
                    new SqlParameter(StoredProcedureParameters.WhiteBloodCells, Convert.ToDouble(txtWhiteCells.Text)),
                    new SqlParameter(StoredProcedureParameters.Eosinophils, Convert.ToDouble(txtEosinophils.Text)),
                    new SqlParameter(StoredProcedureParameters.Lymphocytes, Convert.ToDouble(txtLimphocytes.Text))
              };
                testResultRepository.InsertGeneralBloodTestResultInfo(CommandType.StoredProcedure,
                    StoredProcedureNames.SInsertpGeneralBloodTestResultInfo, parameters);
               
                txtErytrocites.Text = string.Empty;
                txtHemoglobin.Text = string.Empty;
                txtHematocrit.Text = string.Empty;
                txtMCHC.Text = string.Empty;
                txtColorIndecator.Text = string.Empty;
                txtMCH.Text = string.Empty;
                txtMCV.Text = string.Empty;
                txtRDW.Text = string.Empty;
                txtAveregeSize.Text = string.Empty;
                txtPlteles.Text = string.Empty;
                txtWhiteCells.Text = string.Empty;
                txtEosinophils.Text = string.Empty;
                txtLimphocytes.Text = string.Empty;
               
                generalBloodWindow.Visibility = Visibility.Hidden;
                MessageBox.Show("Thank you, general blood test result was succsesfully added");
              
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

      
    }
}
