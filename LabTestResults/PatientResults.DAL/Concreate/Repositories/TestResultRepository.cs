using PatientResults.DAL.Abstraction.Repositories;
using PatientTestResult.Model.TestResultModels;
using PatientResults.DAL.Concreate.Repositories;
using System.Data;
using System.Data.SqlClient;

namespace PatientResults.DAL.Concreate.Repositories
{
    public class TestResultRepository : GenericRepository<TestResultModel>, ITestResultRepository
   {       
       public TestResultRepository(string connection) :base(connection){}

       public void InsertUrinaTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters)
       {
           SqlWrapper.ExecuteReaderWithOutCallback(CommandType.StoredProcedure, spName, parameters);
       }

       public void InsertGeneralBloodTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters)
       {
           SqlWrapper.ExecuteReaderWithOutCallback(CommandType.StoredProcedure, spName, parameters);
       }

       public void InsertProteinMetabolismTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters)
       {
           SqlWrapper.ExecuteReaderWithOutCallback(CommandType.StoredProcedure, spName, parameters);
       }

       public void InsertCarbogydrateMetabolismTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters)
       {
           SqlWrapper.ExecuteReaderWithOutCallback(CommandType.StoredProcedure, spName, parameters);
       }

       public void InsertVitaminsTestResultInfo(CommandType commandType, string spName, SqlParameter[] parameters)
       {
           SqlWrapper.ExecuteReaderWithOutCallback(CommandType.StoredProcedure, spName, parameters);
       }
   }
}
