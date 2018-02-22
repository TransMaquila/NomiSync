using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace NomiSync
{
    static class DAL
    {

        private static string ConnectionString
        {
            get
            {
                return @"Data Source=10.1.1.23,49170; Integrated Security=False; User ID=rgarcia; Password=Reynosa0!; Connect Timeout=10;";
               // return @"Data Source=(localdb)\MSSQLLocalDB; Integrated Security=False; User ID=rgarcia; Password=Reynosa0!; Connect Timeout=30; Encrypt=False; TrustServerCertificate=True; ApplicationIntent=ReadWrite; MultiSubnetFailover=False";
            }
        }

        public async static Task<string> Execute(string queryString)
        {
            int rowsAffected = 0;
            using (SqlConnection connectionSql = new SqlConnection(ConnectionString))
            {
                SqlCommand commandSql = new SqlCommand
                {
                    Connection = connectionSql,
                    CommandText = queryString
                };

                try
                {
                    commandSql.Connection.Open();
                    rowsAffected = await commandSql.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    Console.WriteLine(ex.Message);
                    return ex.Message;
                }

            }
            return rowsAffected.ToString();
        }
    }
}
