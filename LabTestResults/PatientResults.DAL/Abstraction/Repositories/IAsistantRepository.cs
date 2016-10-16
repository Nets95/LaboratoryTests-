using PatientTestResult.Model.AsistantModels;
using System.Data.SqlClient;
namespace PatientResults.DAL.Abstraction.Repositories
{
    public interface IAsistantRepository:IGenericRepository<AsistantModel>
    {
        void InsertAsistantInfo(string spName, SqlParameter[] parameters);
    }
}
