using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientTestResult.Model.UserModel;
using PatientResults.DAL.Abstraction.Repositories;
using System.Data.SqlClient;
using System.Data;


namespace PatientResults.DAL.Concreate.Repositories
{
    public class UserRepository : GenericRepository<UserModel>, IUserRepository
    {
                

        public UserRepository(string connection) : base (connection){}

        public object GetUserByLogin<T>(string spName, SqlParameter[] parameters, Func<SqlDataReader,T> callback)
        {
            var result = SqlWrapper.ExecuteReader(CommandType.StoredProcedure, spName, parameters, callback);
            return (IEnumerable<T>)result;
        }
    }
}
