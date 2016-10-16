using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientTestResult.Model.TestResultModels;
using System.Data.SqlClient;
using PatientResults.DAL.Concreate.SQL;
using System.Globalization;


namespace PatientTestResult.Parser.TestResultParser
{
    public class TestResultParser
    {
        private static TestResultParser _instance;

        private TestResultParser()
        {

        }

        public static TestResultParser Instance
        {
            get { return _instance ?? (_instance = new TestResultParser()); }
        }

        public TestResultModel MakeResult(SqlDataReader reader)
        {
            var testResultModel = new TestResultModel();

            if (reader.ColumnExists(StoredProcedureParameters.Id))
            {
                testResultModel.Id = reader[StoredProcedureParameters.Id] is DBNull
                ? 0
                : Convert.ToInt32(reader[StoredProcedureParameters.Id], CultureInfo.CurrentCulture);
            }

            if (reader.ColumnExists(StoredProcedureParameters.NameOfTest))
            {
                testResultModel.NameOfTest = reader[StoredProcedureParameters.NameOfTest] is DBNull
                    ? string.Empty
                    : reader[StoredProcedureParameters.NameOfTest].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.DateOfResult))
            {
                testResultModel.DateOfResult = reader[StoredProcedureParameters.DateOfResult] is DBNull
                    ? string.Empty
                    : reader[StoredProcedureParameters.DateOfResult].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.PhValue))
            {
                testResultModel.PhValue = reader[StoredProcedureParameters.PhValue] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.PhValue]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Protein))
            {
                testResultModel.Protein = reader[StoredProcedureParameters.Protein] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Protein]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Sugar))
            {
                testResultModel.Sugar = reader[StoredProcedureParameters.Sugar] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Sugar]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Nitrite))
            {
                testResultModel.Nitrite = reader[StoredProcedureParameters.Nitrite] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Nitrite]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Ketone))
            {
                testResultModel.Ketone = reader[StoredProcedureParameters.Ketone] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Ketone]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Bilirubin))
            {
                testResultModel.Bilirubin = reader[StoredProcedureParameters.Bilirubin] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Bilirubin]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Urobilinogen))
            {
                testResultModel.Urobilinogen = reader[StoredProcedureParameters.Urobilinogen] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Urobilinogen]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.RedBloodCells))
            {
                testResultModel.RedBloodCells = reader[StoredProcedureParameters.RedBloodCells] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.RedBloodCells]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.WhiteBloodCells))
            {
                testResultModel.WhiteBloodCells = reader[StoredProcedureParameters.WhiteBloodCells] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.WhiteBloodCells]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Erythrocytes))
            {
                testResultModel.Erythrocytes = reader[StoredProcedureParameters.Erythrocytes] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Erythrocytes]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Hemoglobin))
            {
                testResultModel.Hemoglobin = reader[StoredProcedureParameters.Hemoglobin] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Hemoglobin]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Hematocrit))
            {
                testResultModel.Hematocrit = reader[StoredProcedureParameters.Hematocrit] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Hematocrit]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.ColorIndicator))
            {
                testResultModel.ColorIndicator = reader[StoredProcedureParameters.ColorIndicator] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.ColorIndicator]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Mch))
            {
                testResultModel.Mch = reader[StoredProcedureParameters.Mch] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Mch]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Mcv))
            {
                testResultModel.Mcv = reader[StoredProcedureParameters.Mcv] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Mcv]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Rdw))
            {
                testResultModel.Rdw = reader[StoredProcedureParameters.Rdw] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Rdw]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.AverageSizeErythrocytes))
            {
                testResultModel.AverageSizeErythrocytes = reader[StoredProcedureParameters.AverageSizeErythrocytes] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.AverageSizeErythrocytes]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Platelets))
            {
                testResultModel.Platelets = reader[StoredProcedureParameters.Platelets] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Platelets]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Eosinophils))
            {
                testResultModel.Eosinophils = reader[StoredProcedureParameters.Eosinophils] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Eosinophils]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Lymphocytes))
            {
                testResultModel.Lymphocytes = reader[StoredProcedureParameters.Lymphocytes] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Lymphocytes]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.GeneralProtein))
            {
                testResultModel.GeneralProtein = reader[StoredProcedureParameters.GeneralProtein] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.GeneralProtein]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Albumin))
            {
                testResultModel.Albumin = reader[StoredProcedureParameters.Albumin] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Albumin]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Globulin))
            {
                testResultModel.Globulin = reader[StoredProcedureParameters.Globulin] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Globulin]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Fibrinogen))
            {
                testResultModel.Fibrinogen = reader[StoredProcedureParameters.Fibrinogen] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Fibrinogen]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Creatinine))
            {
                testResultModel.Creatinine = reader[StoredProcedureParameters.Creatinine] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Creatinine]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.CreatineKinase))
            {
                testResultModel.CreatineKinase = reader[StoredProcedureParameters.CreatineKinase] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.CreatineKinase]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Urea))
            {
                testResultModel.Urea = reader[StoredProcedureParameters.Urea] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Urea]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.UreaAcid))
            {
                testResultModel.UreaAcid = reader[StoredProcedureParameters.UreaAcid] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.UreaAcid]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.UreaAcid))
            {
                testResultModel.UreaAcid = reader[StoredProcedureParameters.UreaAcid] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.UreaAcid]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Glucose))
            {
                testResultModel.Glucose = reader[StoredProcedureParameters.Glucose] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Glucose]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.SialAcid))
            {
                testResultModel.SialAcid = reader[StoredProcedureParameters.SialAcid] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.SialAcid]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.LacticAcid))
            {
                testResultModel.LacticAcid = reader[StoredProcedureParameters.LacticAcid] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.LacticAcid]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Kaltsydol))
            {
                testResultModel.Kaltsydol = reader[StoredProcedureParameters.Kaltsydol] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Kaltsydol]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Cobalamin))
            {
                testResultModel.Cobalamin = reader[StoredProcedureParameters.Cobalamin] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Cobalamin]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.FolicAcid))
            {
                testResultModel.FolicAcid = reader[StoredProcedureParameters.FolicAcid] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.FolicAcid]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Pyridoxine))
            {
                testResultModel.Pyridoxine = reader[StoredProcedureParameters.Pyridoxine] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Pyridoxine]);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Retinol))
            {
                testResultModel.Retinol = reader[StoredProcedureParameters.Retinol] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Retinol]);
            }


            if (reader.ColumnExists(StoredProcedureParameters.Tocopherol))
            {
                testResultModel.Tocopherol = reader[StoredProcedureParameters.Tocopherol] is DBNull
                    ? 0
                    : Convert.ToDouble(reader[StoredProcedureParameters.Tocopherol]);
            }


            return testResultModel;
        }

    }
}
