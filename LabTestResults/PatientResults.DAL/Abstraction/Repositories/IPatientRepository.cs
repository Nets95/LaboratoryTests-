using PatientTestResult.Model.PatientModels;
using System.Data.SqlClient;
using System.Data;

namespace PatientResults.DAL.Abstraction.Repositories
{
    public interface IPatientRepository : IGenericRepository<PatientModel>
    {
        void InsertPatientsInfo(string spName, SqlParameter[] parameters);

        void InsertPatientRegistrationInfo(string spName, SqlParameter[] parameters);
    }
}
