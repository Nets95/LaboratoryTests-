using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PatientTestResult.Model.PatientModels;
using PatientResults.DAL.Concreate.SQL;
using System.Globalization;


namespace PatientTestResult.Parser.PatientInfoParser
{
    public class PatientInfoParser
    {
         private static PatientInfoParser _instance;

        private PatientInfoParser()
        {

        }

        public static PatientInfoParser Instance
        {
            get { return _instance ?? (_instance = new PatientInfoParser()); }
        }

        public PatientModel MakeResult(SqlDataReader reader)
        {
            var modelPatient = new PatientModel();
           
            if (reader.ColumnExists(StoredProcedureParameters.Id))
            {
                modelPatient.Id = reader[StoredProcedureParameters.Id] is DBNull
                ? 0
                : Convert.ToInt32(reader[StoredProcedureParameters.Id], CultureInfo.CurrentCulture);
            }

            if (reader.ColumnExists(StoredProcedureParameters.Name))
            {
                modelPatient.Name = reader[StoredProcedureParameters.Name] is DBNull 
                    ? string.Empty 
                    : reader[StoredProcedureParameters.Name].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.LastName))
            {
                modelPatient.LastName = reader[StoredProcedureParameters.LastName] is DBNull 
                    ? string.Empty 
                    : reader[StoredProcedureParameters.LastName].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.Gender))
            {
                modelPatient.Gender = reader[StoredProcedureParameters.Gender] is DBNull 
                    ? string.Empty 
                    : reader[StoredProcedureParameters.Gender].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.DateOfBirth))
            {
                modelPatient.DateOfBirth = reader[StoredProcedureParameters.DateOfBirth] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.DateOfBirth].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.DateOfBirth))
            {
                modelPatient.DateOfBirth = reader[StoredProcedureParameters.DateOfBirth] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.DateOfBirth].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.PalceOfResidence))
            {
                modelPatient.PlaceOfResidence = reader[StoredProcedureParameters.PalceOfResidence] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.PalceOfResidence].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.BloodType))
            {
                modelPatient.BloodType = reader[StoredProcedureParameters.BloodType] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.BloodType].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.Email))
            {
                modelPatient.Email = reader[StoredProcedureParameters.Email] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.Email].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.PhoneNumber))
            {
                modelPatient.PhoneNumber = reader[StoredProcedureParameters.PhoneNumber] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.PhoneNumber].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.DateOfRegistration))
            {
                modelPatient.DateOfRegistration = reader[StoredProcedureParameters.DateOfRegistration] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.DateOfRegistration].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.NameOfTest))
            {
                modelPatient.NameOfTest = reader[StoredProcedureParameters.NameOfTest] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.NameOfTest].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.NameOfAsistant))
            {
                modelPatient.NameOfAsistant = reader[StoredProcedureParameters.NameOfAsistant] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.NameOfAsistant].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.LastNameOfAsistant))
            {
                modelPatient.LastNameOfAsistant = reader[StoredProcedureParameters.LastNameOfAsistant] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.LastNameOfAsistant].ToString();
            }

            return modelPatient;
        }
    }
}
