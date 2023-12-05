using DevExpress.XtraEditors;
using DXQLMT.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLMT.FrontEnd
{
    public partial class FLogin : DevExpress.XtraEditors.XtraForm
    {
        public FLogin()
        {
            InitializeComponent();
            AcceptButton = BTN_Login;
            CancelButton = BTN_Exit;
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq == DialogResult.Yes ) Application.Exit();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text != "" || txt_pass.Text != "")
            {
                int username = Convert.ToInt32(txt_Id.Text);
                string password = txt_pass.Text;
                if (LoginDAO.Instance.Check_Account(username, password))
                {
                    LoginDAO.Instance.get_type(username);
                    this.Hide();
                    FormCentrer frm = new FormCentrer();
                    frm.Show();

                }
            }
            else MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu!");
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, hãy ngăn ngừa người dùng nhập
                e.Handled = true;
                MessageBox.Show("Nhập sai kiểu dữ liệu Id!");
            }
        }
        public void formshow()
        {
            this.ShowDialog();
        }
    }
}