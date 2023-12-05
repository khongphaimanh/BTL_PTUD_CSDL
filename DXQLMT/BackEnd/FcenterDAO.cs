using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLMT.BackEnd
{
    public class FcenterDAO
    {
        private FcenterDAO() { }
        private static FcenterDAO instance;

        public static FcenterDAO Instance { 
            get => instance ?? (instance = new FcenterDAO()); 
            private set => instance = value; 
        }
        public DataTable load_dgv_Home()
        {
            DataTable data = null;
            try
            {
                string query = "select *from Products";
                data = DataProvide.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public DataTable Load_Search(string text)
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%"+text+"%'";
            data = DataProvide.Instance.ExecuteQuerySearch(query);
            return data;
        }

        public DataTable Load_Search_ProductsOfDell()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%Dell%'";
            data = DataProvide.Instance.ExecuteQuerySearch(query);
            return data;
        }
        public DataTable Load_Search_ProductsOfAcer()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%Acer%'";
            data = DataProvide.Instance.ExecuteQuerySearch(query);
            return data;
        }
        public DataTable find_Inspiron()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%inspiron%'";
            data = DataProvide.Instance.ExecuteQuerySearch(query);
            return data;
        }
        public DataTable find_Latidue()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%latidue%'";
            data = DataProvide.Instance.ExecuteQuerySearch(query);
            return data;
        }
        public DataTable find_vostro()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%vostro%'";
            data = DataProvide.Instance.ExecuteQuerySearch(query);
            return data;
        }
        public DataTable find_nitro()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%nitro%'";
            data = DataProvide.Instance.ExecuteQuerySearch(query);
            return data;
        }
    }
}
