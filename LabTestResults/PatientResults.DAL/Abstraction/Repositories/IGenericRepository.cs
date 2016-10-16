using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PatientResults.DAL.Abstraction.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> ExecuteReader(string spName, Func<SqlDataReader, TEntity> callback, SqlParameter[] parameters = null);

        IEnumerable<TEntity> ExecuteReaderWithOutParameters(string spName, Func<SqlDataReader, TEntity> callback);

    }
}
