using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientResults.DAL.Concreate.SQL
{
    public static class StoredProcedureParameters
    {
        public const string Id = "id_patient"; 
       
        public const string Name = "name";
        
        public const string LastName = "last_name";
        
        public const string Gender = "gender";
        
        public const string DateOfBirth = "date_of_birth";
        
        public const string PalceOfResidence = "place_of_residence";
        
        public const string BloodType = "blood_type";
        
        public const string Email = "email_adress";
        
        public const string PhoneNumber = "phone_number";
        
        public const string NameOfTest = "name_of_test";

        public const string IdAsistant = "id_asistant";

        public const string NameOfAsistant = "name_of_asistent";
        
        public const string LastNameOfAsistant = "last_name_of_asistent";
        
        public const string DateOfRegistration = "date_of_registration";
        
        public const string spName = "@name_patient";
        
        public const string spLastName = "@last_name";
        
        public const string SpName = "name";
        
        public const string SpLastName = "last_name";
        
        public const string SpGender = "gender";
        
        public const string SpDateOfBirth = "date_of_birth";

        public const string EmailAdressOfAsistant = "email_adress";

        public const string SpPalceOfResidence = "place_of_residence";
        
        public const string SpBloodType = "blood_type";
        
        public const string SpEmail = "email_adress";
        
        public const string SpPhoneNumber = "phone_number";

        public const string SpNameOfAsistant = "@name_of_asistent";

        public const string SpLastNameOfAsistant = "@last_name_of_asistent";

        public const string SpEmailAdressOfAsistant = "@email_adress";

        public const string SpDateOfRegistration = "@date_of_registration";

        public const string SpIdPatient = "@id_patient"; 
 
        public const string SpNameOfTest = "@name_of_test";

        public const string SpDateOfResult = "@date_of_result";
	
        public const string DateOfResult = "date_of_result";

        public const string SpNameTest = "@test_name";
        
        //Urina Test
        public const string PhValue = "pH_value ";
        public const string Protein = "protein";
        public const string Sugar = "sugar";
        public const string Nitrite = "nitrite";
        public const string Ketone = "ketone";
        public const string Bilirubin = "bilirubin";
        public const string Urobilinogen = "urobilinogen";
        public const string RedBloodCells = "red_blood_cells";
        public const string WhiteBloodCells = "white_blood_cells";
        //General Blood Test 
        public const string Erythrocytes = "erythrocytes";
        public const string Hemoglobin = "hemoglobin";
        public const string Hematocrit = "hematocrit";
        public const string ColorIndicator = "color_indicator";
        public const string Mch = "mch";
        public const string Mchc = "mchc";
        public const string Mcv = "mcv";
        public const string Rdw = "rdw";
        public const string AverageSizeErythrocytes = "average_size_erythrocytes";
        public const string Platelets = "platelets";
        public const string Eosinophils = "eosinophils";
        public const string Lymphocytes = "lymphocytes";

        //Protein Metabolism
        public const string GeneralProtein = "general_protein";
        public const string Albumin = "albumin";
        public const string Globulin = "globulin";
        public const string Fibrinogen = "fibrinogen";
        public const string Creatinine = "creatinine";
        public const string CreatineKinase = "creatine_kinase";
        public const string Urea = "urea";
        public const string UreaAcid = "urea_acid";
        
        //Carbohydrate Metabalism
        public const string Glucose = "glucose";
        public const string SialAcid = "sial_acid";
        public const string LacticAcid = "lactic_acid";
        
        //Vitamins
        public const string Kaltsydol = "kaltsydol";
        public const string Cobalamin = "cobalamin";
        public const string FolicAcid = "folic_acid";
        public const string Pyridoxine = "pyridoxine";
        public const string Retinol = "retinol";
        public const string Tocopherol = "tocopherol";
    
        //User
       

        public const string FirstName = "first_name";

        public const string Surname = "surname";

        public const string Login = "[login]";

        public const string Password = "[password]";

        public const string Disabled = "[disabled]";

        public const string SpLogin = "@login";

        public const string SpPassword = "@password";
    }
}
