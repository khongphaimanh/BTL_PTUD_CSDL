using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLMT.BackEnd
{
    public class LoginDAO
    {
        private static LoginDAO instance;
        private LoginDAO() { }

        public static LoginDAO Instance
        {
            get => instance ?? (instance = new LoginDAO());
            private set => instance = value;
        }
        public int type = 0;
        public bool Check_Account(int username, string password)
        {

            try
            { 
                string query = "select *from Accounts where Id = @username and Pass = @password ";
                if (DataProvide.Instance.ExecuteQuery(query, new object[] {username, password}).Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public void get_type(int username)
        {
            string query = "select Type from Accounts where Id = @username ";
            object result = DataProvide.Instance.ExecuteScalar(query, new object[] {username});
            if (result != null)
            {
                result = result.ToString();
            }
            type = Convert.ToInt32(result);
        }
    }
}
