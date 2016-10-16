using System;
using System.Data;

namespace PatientResults.DAL.Concreate.SQL
{
    public static class ExtensionMethods
    {
        public static bool ColumnExists(this IDataRecord reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (string.Equals(reader.GetName(i), columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
