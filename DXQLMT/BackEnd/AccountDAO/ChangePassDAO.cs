using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLMT.BackEnd.AccountDAO
{
    public class ChangePassDAO
    {
        private static ChangePassDAO instance;
        private ChangePassDAO() { }

        public static ChangePassDAO Instance { get => instance ?? (instance = new ChangePassDAO()); private set => instance = value; }
        public bool Load_check(int username, string password)
        {
            try
            {
                string query = "select *from Accounts where Id = @username and Pass = @password ";
                if (DataProvide.Instance.ExecuteQuery(query, new object[] {username, password}).Rows.Count > 0)
                {
                    return true;
                } else return false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void Load_Change_Pass(int username, string newpass)
        {
            try
            {
                string query = "update Accounts set Pass = @newpass  where Id = @username";
                DataProvide.Instance.ExecuteNonQuery(query, new object[] {newpass, username});
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
