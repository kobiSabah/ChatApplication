using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public static class DBMethod
    {
        /*
            TODO:: 1. Good name for the class.
            TODO:: 2. Using LINQ
            TODO:: 3. Check if there is another way to pass the connection string.
            TODO:: 4. Repository for database query.
         */
        public static bool isExist(string i_Username, string i_Password, string i_ConnectionString)
        {
            string query = $"SELECT COUNT(*) FROM Contact WHERE Username like '{i_Username}' and Password like '{i_Password}'";
            using (SqlConnection connection = new SqlConnection(i_ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                connection.Open();
                return (int)adapter.SelectCommand.ExecuteScalar() == 1;
            }
        }

        public static DataTable GetHistoryMessage (int i_SenderId, int i_ReceiverID, string i_ConnectionString)
        {
            List<HistoryMessageModel> messages = new List<HistoryMessageModel>();

            string query = $"SELECT * FROM HistoryMessage WHERE SenderID = {i_SenderId} or ReceiverID = {i_SenderId}";
            using (SqlConnection connection = new SqlConnection(i_ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                connection.Open();
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
