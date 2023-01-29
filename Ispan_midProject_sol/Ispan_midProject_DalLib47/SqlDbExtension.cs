using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ispan_BackstageManagement_Lib35
{
    public static class SqlDataReaderExtension
    {
        public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
        {
            // 每個泛型資料型態的預設值，例如int的預設值=0，bool的預設值是false
            // T defaultValue = default;

            // DBNull是看看db的值是不是null，
            return source[columnName].Equals(DBNull.Value)
                ? default(T)
                : (T)source[columnName];
        }
    }
}
