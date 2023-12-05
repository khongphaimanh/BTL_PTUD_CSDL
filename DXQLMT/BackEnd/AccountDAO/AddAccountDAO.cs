using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLMT.BackEnd.AccountDAO
{
    public class AddAccountDAO
    {
        private AddAccountDAO() { }
        private static AddAccountDAO instance;

        public static AddAccountDAO Instance { 
            get => instance ?? (instance = new AddAccountDAO()); 
            private set => instance = value; 
        }
        public void Insert_Account(int Id, string displayname, string Pass, int type)
        {
            try
            {
                string query = "insert into Accounts(Id, DisplayName, Pass, Type)\r\nvalues ( @Id , @displayname , @Pass , @type );";
                DataProvide.Instance.ExecuteNonQuery(query, new object[] {Id, displayname, Pass, type});
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
