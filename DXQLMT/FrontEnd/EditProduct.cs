using DevExpress.XtraEditors;
using DXQLMT.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLMT.FrontEnd
{
    public partial class EditProduct : DevExpress.XtraEditors.XtraForm
    {
        public EditProduct()
        {
            InitializeComponent();
            BTN_Del.Enabled = false;
            BTN_Update.Enabled = false;
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập chữ số!");
            }
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập chữ số!");
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập chữ số!");
            }
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text == "" || txt_Name.Text == "")
            {
                MessageBox.Show("Chưa có mã định danh cho sản phầm!");
            }
            else
            {
                try
                {
                   /*( txt_Id.Clear();
                    txt_Name.Clear();
                    txt_Image.Clear();
                    txt_mota.Clear();
                    txt_price.Clear();
                    txt_Quantity.Clear(); */
                    //int Id = Convert.ToInt32((dgv_product.Rows[dgv_product.Rows.Count - 1].Cells[0].Value)) + 1;
                    //txt_Id.Text = Id.ToString();
                    int Id = Convert.ToInt32(txt_Id.Text);
                    if (EditProductDAO.Instance.check_Id(Id)) MessageBox.Show("Id đã tồn tại!");
                    else
                    {
                        try
                        {
                            string name = txt_Name.Text;
                            string path = txt_Image.Text;
                            int sl = Convert.ToInt32(txt_Quantity.Text);
                            string mota = txt_mota.Text;
                            decimal giaban = Convert.ToDecimal(txt_price.Text);
                            byte[] img = File.ReadAllBytes(path); //convertImgToByte
                            EditProductDAO.Instance.Add_Product(Id, name, img, sl, mota, giaban);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void BTN_Insert_Click(object sender, EventArgs e)
        {
            if (StreamImg.ShowDialog() == DialogResult.OK)
            {
                txt_Image.Text = StreamImg.FileName;
                pic_img.ImageLocation = StreamImg.FileName;
            }
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgv_product.DataSource = FcenterDAO.Instance.load_dgv_Home();
                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)dgv_product.Columns[2];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                if (txt_Id.Text != null) BTN_Add.Enabled = true;
                txt_Id.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "Id"));
                txt_Name.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "ProductName"));
                txt_Quantity.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "Quantity"));
                txt_mota.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "MoTa"));
                txt_price.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "GiaBan"));
                dgv_product.Columns["Id"].Width = 20; // Thiết lập chiều rộng của cột "Id" là 50
                dgv_product.Columns["Id"].Frozen = true; // Giữ nguyên chiều rộng của cột khi kích thước cửa sổ thay đổi
                dgv_product.Columns["Quantity"].Width = 60; // Thiết lập chiều rộng của cột "Quantity" là 70
                dgv_product.Columns["Quantity"].Frozen = true; // Giữ nguyên chiều rộng của cột khi kích thước cửa sổ thay đổi
                dgv_product.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Thiết lập vị trí ngang cho văn bản là giữa bên trái
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_product_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_product.SelectedRows.Count > 0)
            {
                BTN_Del.Enabled = true;
            }
        }

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                EditProductDAO.Instance.del_Products(Convert.ToInt32(txt_Id.Text));
            }
        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_Update.Enabled = true;
            txt_Id.ReadOnly = true;
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txt_Id.Text);
                string name = txt_Name.Text;
                string path = txt_Image.Text;
                int sl = Convert.ToInt32(txt_Quantity.Text);
                string mota = txt_mota.Text;
                decimal giaban = Convert.ToDecimal(txt_price.Text);
                if (path != "")
                {
                    byte[] img = File.ReadAllBytes(path); //convertImgToByte
                    EditProductDAO.Instance.Update_Product(Id, name, img, sl, mota, giaban);
                }
                else
                {
                    EditProductDAO.Instance.Update_Product1(Id, name, sl, mota, giaban);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            dgv_product.DataSource = FcenterDAO.Instance.load_dgv_Home();
        }
    }
}