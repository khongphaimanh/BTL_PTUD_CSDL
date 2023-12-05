using DevExpress.XtraEditors;
using DXQLMT.BackEnd.BillDAO;
using System;
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
    public partial class ThongKeTaiChinh : DevExpress.XtraEditors.XtraForm
    {
        public ThongKeTaiChinh()
        {
            InitializeComponent();
        }

        private void BTN_ThongKe_Click(object sender, EventArgs e)
        {
            decimal Total = ThongKeTaiChinhDAO.Instance.ThongKe();
            txt_Total.Text = Total.ToString();
        }

        private void ThongKeTaiChinh_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ThongKeTaiChinhDAO.Instance.load_dgv_Bill();
        }
    }
}