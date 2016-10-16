using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PatientResults.DAL.Abstraction.Repositories;
using PatientResults.DAL.Concreate.SQL;

namespace PatientResults.DAL.Concreate.Repositories
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity : class, new () 
    {
        private readonly SqlCommandWrapper _sqlWrapper;

        public GenericRepository(string connection)
        {
            _sqlWrapper = new SqlCommandWrapper(connection);
        }

        public SqlCommandWrapper SqlWrapper
        {
            get { return _sqlWrapper; }
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();    
        }

        public IEnumerable<TEntity> ExecuteReader(string spName, Func<SqlDataReader, TEntity> callback, SqlParameter[] parameters = null)
        {
            var result = SqlWrapper.ExecuteReader(CommandType.StoredProcedure, spName, parameters, callback);
            return (IEnumerable<TEntity>)result;
        }

        public IEnumerable<TEntity> ExecuteReaderWithOutParameters(string spName, Func<SqlDataReader, TEntity> callback)
        {
            var result = SqlWrapper.ExecuteReaderWithOutParameters(CommandType.StoredProcedure, spName, callback);
            return (IEnumerable<TEntity>)result;
        }

    }
}
