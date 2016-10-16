using PatientResults.DAL.Concreate.Repositories;
using PatientTestResult.Model.PatientModels;
using PatientResults.DAL.Abstraction.Repositories;
using System.Data.SqlClient;
using System.Data;

namespace PatientResults.DAL.Concreate.Repositories
{
    public class PatientRepository: GenericRepository<PatientModel>, IPatientRepository
    {
        public PatientRepository(string connection): base(connection){}

        //for saving state of selected data grid row
        //----------------------------------------
        private static int _patientId;
        
        private static string _patientName;
        
        private static string _patientLastName;

        public static string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }

        public static string PatientLastName
        {
            get { return _patientLastName; }
            set { _patientLastName = value; }
        }

        public static int PatientId
        {
            get { return _patientId; }
            set { _patientId = value; }
        }
        //-----------------------------------------

        public void InsertPatientsInfo(string spName, SqlParameter[] parameters)
        {
            SqlWrapper.ExecuteReaderWithOutCallback(CommandType.StoredProcedure, spName, parameters);
        }

        public void InsertPatientRegistrationInfo(string spName, SqlParameter[] parameters)
        {
            SqlWrapper.ExecuteReaderWithOutCallback(CommandType.StoredProcedure, spName, parameters);
        }
    }
}

