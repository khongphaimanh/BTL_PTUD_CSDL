namespace DXQLMT.FrontEnd.Form_Bill
{
    partial class TaoHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoHoaDon));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Bill = new System.Windows.Forms.DateTimePicker();
            this.txt_IdBill = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Name_Customer = new System.Windows.Forms.TextBox();
            this.txt_local = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ProductId = new System.Windows.Forms.TextBox();
            this.BTN_Add_Product = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_DEL = new System.Windows.Forms.Button();
            this.BTN_reset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView_Bill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ngày lập ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã hóa đơn ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.txt_Note);
            this.groupBox1.Controls.Add(this.dateTimePicker_Bill);
            this.groupBox1.Controls.Add(this.txt_IdBill);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn ";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(71, 117);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(200, 51);
            this.txt_Note.TabIndex = 9;
            // 
            // dateTimePicker_Bill
            // 
            this.dateTimePicker_Bill.Location = new System.Drawing.Point(71, 80);
            this.dateTimePicker_Bill.Name = "dateTimePicker_Bill";
            this.dateTimePicker_Bill.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_Bill.TabIndex = 8;
            // 
            // txt_IdBill
            // 
            this.txt_IdBill.Location = new System.Drawing.Point(71, 31);
            this.txt_IdBill.Name = "txt_IdBill";
            this.txt_IdBill.ReadOnly = true;
            this.txt_IdBill.Size = new System.Drawing.Size(200, 21);
            this.txt_IdBill.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ghi chú ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.txt_Name_Customer);
            this.groupBox2.Controls.Add(this.txt_local);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Location = new System.Drawing.Point(310, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng ";
            // 
            // txt_Name_Customer
            // 
            this.txt_Name_Customer.Location = new System.Drawing.Point(77, 29);
            this.txt_Name_Customer.Name = "txt_Name_Customer";
            this.txt_Name_Customer.Size = new System.Drawing.Size(183, 21);
            this.txt_Name_Customer.TabIndex = 6;
            // 
            // txt_local
            // 
            this.txt_local.Location = new System.Drawing.Point(77, 117);
            this.txt_local.Multiline = true;
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(183, 51);
            this.txt_local.TabIndex = 5;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(77, 72);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(183, 21);
            this.txt_sdt.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Địa chỉ ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Họ tên ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Số điện thoại ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Controls.Add(this.txt_Total);
            this.groupBox3.Controls.Add(this.labelControl9);
            this.groupBox3.Controls.Add(this.txt_Quantity);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.labelControl8);
            this.groupBox3.Controls.Add(this.txt_ProductId);
            this.groupBox3.Location = new System.Drawing.Point(594, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 130);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(82, 99);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(177, 21);
            this.txt_Total.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(13, 102);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 13);
            this.labelControl9.TabIndex = 5;
            this.labelControl9.Text = "Total";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(82, 67);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(48, 21);
            this.txt_Quantity.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 70);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Số lượng ";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 34);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Mã sản phẩm";
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.Location = new System.Drawing.Point(82, 29);
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.Size = new System.Drawing.Size(177, 21);
            this.txt_ProductId.TabIndex = 3;
            // 
            // BTN_Add_Product
            // 
            this.BTN_Add_Product.Image = global::DXQLMT.Properties.Resources.Kyo_Tux_Delikate_Add_24;
            this.BTN_Add_Product.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Add_Product.Location = new System.Drawing.Point(759, 159);
            this.BTN_Add_Product.Name = "BTN_Add_Product";
            this.BTN_Add_Product.Size = new System.Drawing.Size(94, 46);
            this.BTN_Add_Product.TabIndex = 6;
            this.BTN_Add_Product.Text = "Thêm sản phẩm ";
            this.BTN_Add_Product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Add_Product.UseVisualStyleBackColor = true;
            this.BTN_Add_Product.Click += new System.EventHandler(this.BTN_Add_Product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(363, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin hóa đơn ";
            // 
            // BTN_Add
            // 
            this.BTN_Add.Image = global::DXQLMT.Properties.Resources.Kyo_Tux_Delikate_Add_32;
            this.BTN_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Add.Location = new System.Drawing.Point(32, 254);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(100, 46);
            this.BTN_Add.TabIndex = 7;
            this.BTN_Add.Text = "Thêm ";
            this.BTN_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_DEL
            // 
            this.BTN_DEL.Image = global::DXQLMT.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete_24;
            this.BTN_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DEL.Location = new System.Drawing.Point(32, 377);
            this.BTN_DEL.Name = "BTN_DEL";
            this.BTN_DEL.Size = new System.Drawing.Size(100, 46);
            this.BTN_DEL.TabIndex = 6;
            this.BTN_DEL.Text = "Xóa ";
            this.BTN_DEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_DEL.UseVisualStyleBackColor = true;
            // 
            // BTN_reset
            // 
            this.BTN_reset.Image = global::DXQLMT.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh_24;
            this.BTN_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_reset.Location = new System.Drawing.Point(32, 315);
            this.BTN_reset.Name = "BTN_reset";
            this.BTN_reset.Size = new System.Drawing.Size(100, 46);
            this.BTN_reset.TabIndex = 5;
            this.BTN_reset.Text = "Sửa ";
            this.BTN_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_reset.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(152, 254);
            this.gridControl1.MainView = this.gridView_Bill;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(720, 221);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Bill});
            // 
            // gridView_Bill
            // 
            this.gridView_Bill.GridControl = this.gridControl1;
            this.gridView_Bill.Name = "gridView_Bill";
            // 
            // BTN_Save
            // 
            this.BTN_Save.Image = global::DXQLMT.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save_32;
            this.BTN_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Save.Location = new System.Drawing.Point(32, 429);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(100, 46);
            this.BTN_Save.TabIndex = 12;
            this.BTN_Save.Text = "Lưu";
            this.BTN_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 221);
            this.dataGridView1.TabIndex = 13;
            // 
            // TaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_Add_Product);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_DEL);
            this.Controls.Add(this.BTN_reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TaoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoHoaDon";
            this.Load += new System.EventHandler(this.TaoHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Name_Customer;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.TextBox txt_sdt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Quantity;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txt_ProductId;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Bill;
        private System.Windows.Forms.TextBox txt_IdBill;
        private System.Windows.Forms.Button BTN_Add_Product;
        private System.Windows.Forms.Button BTN_reset;
        private System.Windows.Forms.Button BTN_DEL;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Bill;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.TextBox txt_Total;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}