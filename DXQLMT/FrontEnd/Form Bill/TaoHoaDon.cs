using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DXQLMT.BackEnd.BillDAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLMT.FrontEnd.Form_Bill
{
    public partial class TaoHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public TaoHoaDon()
        {
            InitializeComponent();
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txt_IdBill.Text = "HD" + now.ToString("yyyyMMddHHmmss");
            dateTimePicker_Bill.Value = now;
            txt_IdBill.Enabled = true;
            dateTimePicker_Bill.Enabled = true;
            txt_Note.Enabled = true;
            txt_Name_Customer.Enabled = true;
            txt_sdt.Enabled = true;
            txt_local.Enabled = true;
            txt_ProductId.Enabled = true;
            txt_Quantity.Enabled = true;
            txt_Total.Enabled = true;
            BTN_Add_Product.Enabled = true;
            BTN_Add.Enabled = false;
            BTN_Save.Enabled = true;
        }

        private void TaoHoaDon_Load(object sender, EventArgs e)
        {
            txt_IdBill.Enabled=false;
            dateTimePicker_Bill.Enabled=false;
            txt_Note.Enabled=false;
            txt_Name_Customer.Enabled=false;
            txt_sdt.Enabled=false;
            txt_local.Enabled=false;
            txt_ProductId.Enabled=false;
            txt_Quantity.Enabled=false;
            BTN_Add_Product.Enabled=false;
            gridControl1.DataSource = BillDAO.Instance.load_dgv_bill();
            dataGridView1.Visible=false;
            BTN_reset.Enabled=false;
            BTN_Save.Enabled=false;
            BTN_DEL.Enabled=false;
            txt_Total.Enabled=false;
        }

        private void BTN_Add_Product_Click(object sender, EventArgs e)
        {
            int msp = Convert.ToInt32(txt_ProductId.Text);
            int sl = Convert.ToInt32(txt_Quantity.Text);
            if (BillDAO.Instance.check_Quantity(msp, sl))
            {
                BillDAO.Instance.add_product(txt_IdBill.Text, msp, sl);
                gridControl1.Visible = false;
                dataGridView1.Visible=true;
                dataGridView1.DataSource = BillDAO.Instance.temp_product();
            }
            else MessageBox.Show("Số lượng mặt hàng không đủ!");
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            gridControl1.Visible = true;
            dataGridView1.Visible = false;
            BillDAO.Instance.copy_data(txt_IdBill.Text, txt_Name_Customer.Text, dateTimePicker_Bill.Value, txt_sdt.Text, txt_Note.Text);
            gridControl1.DataSource = BillDAO.Instance.load_dgv_bill();
        }
    }
}