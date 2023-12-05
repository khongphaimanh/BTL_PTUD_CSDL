using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLMT.BackEnd
{
    public class DataProvide
    {
        private DataProvide() { }
        private static DataProvide instance; //ctrl + R + E

        public static DataProvide Instance { 
            get => instance ?? (instance = new DataProvide()); 
            private set => instance = value; 
        }
        private string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Pham Manh\\source\\repos\\DXQLMT\\DXQLMT\\DataProvide.mdf\";Integrated Security=True";
        public void ExecuteNonQuery(string query, object[] parameter = null)
        {
            SqlConnection connection = new SqlConnection(stringconnection);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listpara)
                    {
                        if (s.Contains("@"))
                        {
                            command.Parameters.AddWithValue(s, parameter[i]);
                            i++;
                        }
                    }
                }
                command.ExecuteNonQuery();
                //MessageBox.Show("Thay đổi dữ liệu thành công!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(stringconnection);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listpara)
                    {
                        if (s.Contains("@"))
                        {
                            command.Parameters.AddWithValue(s, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return table;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null;
            SqlConnection connection = new SqlConnection(stringconnection);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listpara)
                    {
                        if (s.Contains("@"))
                        {
                            command.Parameters.AddWithValue(s, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return data;
        }
        public DataTable ExecuteQuerySearch(string query)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(stringconnection);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return table;
        }
    }
}
