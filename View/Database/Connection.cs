using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace View.Database
{
    public class Connection
    {
        public static string connection = "Data Source=LAPTOP-UJCQAF9R\\SQLEXPRESS;Initial Catalog=appclothing;Integrated Security=True;";
        public static SqlConnection connect = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", connect);
        public static SqlDataReader rd;

        public static void OpenConnection()
        {
            try
            {
                if(connect.State==System.Data.ConnectionState.Closed )
                {
                    connect.ConnectionString = connection;
                    connect.Open();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Server is disconnect~" + ex.Message);
            }
        }
        public static void CloseConnection()
        {
            try
            {
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    connect.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server is Error~" + ex.Message);
            }
        }
    }
}
