using PatientTestResult.Model.TestResultModels;
using System.Data;
using System.Data.SqlClient;

namespace PatientResults.DAL.Abstraction.Repositories
{
    public interface ITestResultRepository:IGenericRepository<TestResultModel>
    {
         void InsertUrinaTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters);

         void InsertGeneralBloodTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters);

         void InsertProteinMetabolismTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters);

         void InsertCarbogydrateMetabolismTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters);

         void InsertVitaminsTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters);
    
    }
}
