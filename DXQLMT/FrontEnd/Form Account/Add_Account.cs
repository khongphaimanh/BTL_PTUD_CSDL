using DevExpress.XtraEditors;
using DXQLMT.BackEnd.AccountDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLMT.FrontEnd.Form_Account
{
    public partial class Add_Account : DevExpress.XtraEditors.XtraForm
    {
        public Add_Account()
        {
            InitializeComponent();
            AcceptButton = BTN_Add;
            
        }

        private void textId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, hãy ngăn ngừa người dùng nhập
                e.Handled = true;
                MessageBox.Show("Nhập sai kiểu dữ liệu Id!");
            }
        }

        private void numericUpDown_Type_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textId.Text);
            string displayname = text_Display_name.Text;
            string Pass = text_Pass.Text;
            int type = Convert.ToInt32(numericUpDown_Type.Value);
            AddAccountDAO.Instance.Insert_Account(Id, displayname, Pass, type);
            this.Close();
        }
    }
}