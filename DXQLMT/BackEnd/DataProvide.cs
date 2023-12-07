using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DXQLMT.BackEnd
{
    public class DataProvide
    {
        string debugpath;
        string projectpath;
        string stringconnection;
        private DataProvide()
        {
            debugpath = Directory.GetCurrentDirectory();
            projectpath = Directory.GetParent(Directory.GetParent(debugpath).FullName).FullName;
            stringconnection = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.Combine(projectpath, "DataProvide.mdf")};Integrated Security=True;";

        }

        private static DataProvide instance; //ctrl + R + E

        public static DataProvide Instance { 
            get => instance ?? (instance = new DataProvide()); 
            private set => instance = value;
        }
        
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
        public void ExecuteTransaction(string[] queries, object[] parameter = null)
        {
            SqlConnection connection = new SqlConnection(stringconnection);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                int ParaIndex = 0;
                for (int i = 0; i < queries.Length; i++)
                {
                    SqlCommand command = new SqlCommand(queries[i], connection, transaction);
                    if (parameter != null)
                    {
                        string[] listpara = queries[i].Split(' ');
                        foreach (string para in listpara)
                        {
                            command.Parameters.AddWithValue(para, parameter[ParaIndex]);
                            ParaIndex++;
                        }
                    }
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                connection.Close();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
