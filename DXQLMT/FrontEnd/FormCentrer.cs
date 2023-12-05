using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DXQLMT.BackEnd;
using DXQLMT.FrontEnd;
using DXQLMT.FrontEnd.Form_Account;
using DXQLMT.FrontEnd.Form_Bill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXQLMT
{
    public partial class FormCentrer : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public bool isClose = true;
        public FormCentrer()
        {
            InitializeComponent();
            AcceptButton = BTN_Search;
            if (LoginDAO.Instance.type == 0)
            {
                menu_update_products.Enabled = false;
                //TS_Update_Bill.Enabled = false;
                //TS_financial_statistics.Enabled = false;
            }
            txt_search.Focus();
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
           
        }

        private void FormCentrer_Load(object sender, EventArgs e)
        {
            gridControl_centrer.DataSource = FcenterDAO.Instance.load_dgv_Home();
            RepositoryItemPictureEdit pictureEdit = new RepositoryItemPictureEdit();
            gridView1.Columns["ProductImage"].ColumnEdit = pictureEdit;
            pictureEdit.SizeMode = PictureSizeMode.Zoom;
            gridView1.Columns["Id"].Width = 10; // Thiết lập chiều rộng của cột "TenCot" là 100
            gridView1.Columns["Id"].OptionsColumn.FixedWidth = true; // Giữ nguyên chiều rộng của cột khi kích thước cửa sổ thay đổi
            gridView1.Columns["Quantity"].Width = 50; // Thiết lập chiều rộng của cột "TenCot" là 100
            gridView1.Columns["Quantity"].OptionsColumn.FixedWidth = true; // Giữ nguyên chiều rộng của cột khi kích thước cửa sổ thay đổi
            gridView1.Columns["Quantity"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Thiết lập vị trí ngang cho văn bản là bên trái
            gridView1.Columns["GiaBan"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near; // Thiết lập vị trí ngang cho văn bản là bên trái
        }

        private void BTN_Search_Click_1(object sender, EventArgs e)
        {
            gridControl_centrer.DataSource = FcenterDAO.Instance.Load_Search(txt_search.Text);
        }

        private void Menu_home_Click(object sender, EventArgs e)
        {
            gridControl_centrer.DataSource = FcenterDAO.Instance.load_dgv_Home();
            txt_search.Clear();
        }

        private void FormCentrer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClose)
            {
                DialogResult kq;
                kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kq != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Menu_products_dell_Click(object sender, EventArgs e)
        {
            gridControl_centrer.DataSource = FcenterDAO.Instance.Load_Search_ProductsOfDell();
        }

        private void menu_products_acer_Click(object sender, EventArgs e)
        {
            gridControl_centrer.DataSource = FcenterDAO.Instance.Load_Search_ProductsOfAcer();
        }

        private void Item_Latidue_Click(object sender, EventArgs e)
        {
            gridControl_centrer.DataSource = FcenterDAO.Instance.find_Latidue();
        }

        private void Item_Vostro_Click(object sender, EventArgs e)
        {
            gridControl_centrer.DataSource = FcenterDAO.Instance.find_vostro();
        }

        private void Item_inspiron_Click(object sender, EventArgs e)
        {
            gridControl_centrer.DataSource = FcenterDAO.Instance.find_Inspiron();
        }

        private void Item_Nitro_Click(object sender, EventArgs e)
        {
            gridControl_centrer.DataSource = FcenterDAO.Instance.find_nitro();
        }

        private void menu_update_products_Click(object sender, EventArgs e)
        {
            EditProduct frm = new EditProduct();
            frm.ShowDialog();
        }

        private void gridControl_centrer_Click(object sender, EventArgs e)
        {

        }

        private void menu_logout_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                isClose = false;
                FLogin frm = new FLogin();
                this.Close();
                frm.ShowDialog();
            }
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            Faccount frm = new Faccount();
            frm.ShowDialog();
        }

        private void menu_create_bill_Click(object sender, EventArgs e)
        {
            TaoHoaDon frm = new TaoHoaDon();
            frm.Show();
        }
    }
}
