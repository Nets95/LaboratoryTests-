using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientTestResult.Model.UserModel;
using System.Data.SqlClient;

namespace PatientResults.DAL.Abstraction.Repositories
{
    public interface IUserRepository: IGenericRepository<UserModel>
    {
        object GetUserByLogin<T>(string spName, SqlParameter[] parameters, Func<SqlDataReader, T> callback);
    }
}
