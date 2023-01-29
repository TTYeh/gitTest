using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;



namespace ispan.Estore.SqlDataLayer
{
    public class SqlDB
    {
        public static string ApplicationName { get; set; }
        public static int ConnectTimeout { get; set; }
        public static bool? Pooling { get; set; }
        public static string GetConnectionString(string keyOfConnString)
        {
            var node = System.Configuration.ConfigurationManager.
                ConnectionStrings[keyOfConnString];
            if (node == null) throw new Exception($"找不到節點{keyOfConnString}，請確認後再試");
            string connStr = node.ToString();

            var sb = new SqlConnectionStringBuilder(connStr);
            if (string.IsNullOrEmpty(ApplicationName) == false) sb.ApplicationName = ApplicationName;
            if (ConnectTimeout > 0) sb.ConnectTimeout = ConnectTimeout;
            if (Pooling.HasValue) sb.Pooling = Pooling.Value;
            /*
            sb.ConnectTimeout = 30; //預設15秒
            sb.Pooling = false; // 預設試true，表示不要使用這個連線池
            sb.ApplicationName = "winDemo";
            */
            return sb.ToString();
        }

        public static SqlConnection GetConnection()
        { 
            return GetConnection("default");
        }
        public static SqlConnection GetConnection(string keyOfConnString)
        {
            string connStr = GetConnectionString(keyOfConnString);
            return new SqlConnection(connStr); //建立一個sql connection物件並傳回
        }

        public static int UpdateOrDelete(Func<SqlConnection> functionConnection, string sql, params SqlParameter[] parameters )
        {
            // what is functionConnection?
            // SqlConnection conn = SqlDB.GetConnection("default")
            using (SqlConnection conn = functionConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Create(Func<SqlConnection> functionConnection, string sql, params SqlParameter[] parameters)
        {
            sql += ";SELECT SCOPE_IDENTITY();";
            // what is functionConnection?
            // SqlConnection conn = SqlDB.GetConnection("default")
            using (SqlConnection conn = functionConnection())
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    // cmd.ExecuteNonQuery();
                    // ExecuteNonQuery 會傳回受影響的筆數
                    // ExecuteScalar 傳回select的值
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static T Get<T>(Func<SqlConnection> funcConnection,
            Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters) {

            SqlDB.ApplicationName = "getNews request";
            // SQL連線會忘記斷資源所以用using
            using (var conn = funcConnection())
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    if(parameters != null) cmd.Parameters.AddRange(parameters);
                    var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return reader.Read()
                        ? funcAssembler(reader)
                        : default(T);
                }

            }
        }
        public static IEnumerable<T> Search<T>(Func<SqlConnection> funcConnection,
    Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
        {
            using (var conn = funcConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText=sql;
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read()) 
                    {
                        yield return funcAssembler(reader);
                    }
                }

            }
        }


    }
}
