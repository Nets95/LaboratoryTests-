using System;
using PatientTestResult.Model.BaseModels;

namespace PatientTestResult.Model.TestResultModels
{
    public class TestResultModel:PersistantModel
    {
        public string NameOfTest { get; set; }

        public string DateOfResult { get; set; }

        //Urina Test
        public double PhValue { get; set; }

        public double Protein { get; set; }

        public double Sugar { get; set; }

        public double Nitrite { get; set; }

        public double Ketone { get; set; }

        public double Bilirubin { get; set; }

        public double Urobilinogen { get; set; }

        public double RedBloodCells { get; set; }

        public double WhiteBloodCells { get; set; }

        //General Blood Test 
        public double Erythrocytes { get; set; }

        public double Hemoglobin { get; set; }

        public double Hematocrit { get; set; }

        public double ColorIndicator { get; set; }

        public double Mch { get; set; }

        public double Mchc { get; set; }

        public double Mcv { get; set; }

        public double Rdw { get; set; }

        public double AverageSizeErythrocytes { get; set; }

        public double Platelets { get; set; }

        public double Eosinophils { get; set; }

        public double Lymphocytes { get; set; }


        //Protein Metabolism
        public double GeneralProtein { get; set; }

        public double Albumin { get; set; }

        public double Globulin { get; set; }

        public double Fibrinogen { get; set; }

        public double Creatinine { get; set; }

        public double CreatineKinase { get; set; }

        public double Urea { get; set; }

        public double UreaAcid { get; set; }


        //Carbohydrate Metabalism
        public double Glucose { get; set; }

        public double SialAcid { get; set; }

        public double LacticAcid { get; set; }


        //Vitamins
        public double Kaltsydol { get; set; }

        public double Cobalamin { get; set; }

        public double FolicAcid { get; set; }

        public double Pyridoxine { get; set; }

        public double Retinol { get; set; }

        public double Tocopherol { get; set; }

    }
}
