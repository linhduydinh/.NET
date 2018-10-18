using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_and_IQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=LINHDD-LAPTOP;Initial Catalog=northwind;Integrated Security=True";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "Select * from Categories";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader =  cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0), reader.GetString(1));
                    }
                }
            }
        }
    }
}
