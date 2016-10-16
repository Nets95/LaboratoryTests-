using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientTestResult.Model.UserModel;
using PatientResults.DAL.Concreate.SQL;
using System.Globalization;


namespace PatientTestResult.Parser.UserParser
{
    public class UserParser
    {
           private static UserParser _instance;

        private UserParser()
        {

        }

        public static UserParser Instance
        {
            get { return _instance ?? (_instance = new UserParser()); }
        }

        public UserModel MakeResult(SqlDataReader reader)
        {
            var modelUser = new UserModel();

            if (reader.ColumnExists(StoredProcedureParameters.Id))
            {
                modelUser.Id = reader[StoredProcedureParameters.Id] is DBNull
                ? 0
                : Convert.ToInt32(reader[StoredProcedureParameters.Id], CultureInfo.CurrentCulture);
            }

            if (reader.ColumnExists(StoredProcedureParameters.FirstName))
            {
                modelUser.FirstName = reader[StoredProcedureParameters.FirstName] is DBNull
                    ? string.Empty
                    : reader[StoredProcedureParameters.FirstName].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.Surname))
            {
                modelUser.Surname = reader[StoredProcedureParameters.Surname] is DBNull
                    ? string.Empty
                    : reader[StoredProcedureParameters.Surname].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.Login))
            {
                modelUser.Login = reader[StoredProcedureParameters.Login] is DBNull
                    ? string.Empty
                    : reader[StoredProcedureParameters.Login].ToString();
            }

            if (reader.ColumnExists(StoredProcedureParameters.Password))
            {
                modelUser.Password = reader[StoredProcedureParameters.Password] is DBNull ? string.Empty :
                    reader[StoredProcedureParameters.Password].ToString();
            }

               if (reader.ColumnExists(StoredProcedureParameters.Disabled))
            {
                modelUser.Disabled = reader[StoredProcedureParameters.Disabled] is DBNull ? false :
                                Convert.ToBoolean(reader[StoredProcedureParameters.Disabled].ToString());
            }
               return modelUser;
        }

    }
}
