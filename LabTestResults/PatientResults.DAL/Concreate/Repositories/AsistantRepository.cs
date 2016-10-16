using PatientResults.DAL.Abstraction.Repositories;
using PatientTestResult.Model.AsistantModels;
using System.Data.SqlClient;
using System.Data;


namespace PatientResults.DAL.Concreate.Repositories
{
    public class AsistantRepository: GenericRepository<AsistantModel>, IAsistantRepository
    {
        public AsistantRepository(string connection) : base (connection){}

        public void InsertAsistantInfo(string spName, SqlParameter[] parameters)
        {
            SqlWrapper.ExecuteReaderWithOutCallback(CommandType.StoredProcedure, spName, parameters);
        }
    }
}
