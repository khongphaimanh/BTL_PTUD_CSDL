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
    public partial class ChangePass : DevExpress.XtraEditors.XtraForm
    {
        public ChangePass()
        {
            InitializeComponent();
            AcceptButton = BTN_ResetPass;

        }

        private void BTN_ResetPass_Click(object sender, EventArgs e)
        {
            if (text_Id.Text != "" || text_pass_old.Text != "" && (text_pass_new != null && text_repeat_pass != null && text_pass_new.Text == text_repeat_pass.Text))
            {
                int username = Convert.ToInt32(text_Id.Text);
                string password = text_pass_old.Text;
                string newpass = text_pass_new.Text;
                if (ChangePassDAO.Instance.Load_check(username, password))
                {
                    ChangePassDAO.Instance.Load_Change_Pass(username, newpass);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
            else MessageBox.Show("Nhập thiếu dữ liệu!");
        }

        private void text_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, hãy ngăn ngừa người dùng nhập
                e.Handled = true;
                MessageBox.Show("Nhập sai kiểu dữ liệu Id!");
            }
        }
    }
}