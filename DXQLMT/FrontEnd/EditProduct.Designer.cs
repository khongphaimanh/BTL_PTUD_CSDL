namespace DXQLMT.FrontEnd
{
    partial class EditProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Insert = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.StreamImg = new System.Windows.Forms.OpenFileDialog();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.pic_img = new System.Windows.Forms.PictureBox();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_Del = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(171, 18);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(190, 21);
            this.txt_Id.TabIndex = 1;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(171, 55);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(190, 21);
            this.txt_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txt_Image
            // 
            this.txt_Image.Location = new System.Drawing.Point(171, 92);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.Size = new System.Drawing.Size(112, 21);
            this.txt_Image.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hình ảnh sản phẩm";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(171, 130);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(190, 21);
            this.txt_Quantity.TabIndex = 7;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(171, 171);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(190, 21);
            this.txt_mota.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mô tả";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(171, 210);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(190, 21);
            this.txt_price.TabIndex = 11;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giá bán";
            // 
            // BTN_Insert
            // 
            this.BTN_Insert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Insert.Location = new System.Drawing.Point(286, 92);
            this.BTN_Insert.Name = "BTN_Insert";
            this.BTN_Insert.Size = new System.Drawing.Size(75, 23);
            this.BTN_Insert.TabIndex = 16;
            this.BTN_Insert.Text = "Browser...";
            this.BTN_Insert.UseVisualStyleBackColor = true;
            this.BTN_Insert.Click += new System.EventHandler(this.BTN_Insert_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(12, 287);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowTemplate.Height = 60;
            this.dgv_product.Size = new System.Drawing.Size(558, 248);
            this.dgv_product.TabIndex = 18;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            this.dgv_product.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_product_RowHeaderMouseClick);
            // 
            // StreamImg
            // 
            this.StreamImg.FileName = "openFileDialog1";
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.Image = global::DXQLMT.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh_24;
            this.BTN_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Refresh.Location = new System.Drawing.Point(463, 247);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(89, 34);
            this.BTN_Refresh.TabIndex = 19;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // pic_img
            // 
            this.pic_img.Location = new System.Drawing.Point(394, 18);
            this.pic_img.Name = "pic_img";
            this.pic_img.Size = new System.Drawing.Size(149, 122);
            this.pic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_img.TabIndex = 17;
            this.pic_img.TabStop = false;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Exit.Image = global::DXQLMT.Properties.Resources.Icons8_Windows_8_Users_Exit_16;
            this.BTN_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Exit.Location = new System.Drawing.Point(393, 247);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(64, 34);
            this.BTN_Exit.TabIndex = 15;
            this.BTN_Exit.Text = "Thoát";
            this.BTN_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Update.Image = global::DXQLMT.Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_system_software_update_24;
            this.BTN_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Update.Location = new System.Drawing.Point(308, 247);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(66, 34);
            this.BTN_Update.TabIndex = 14;
            this.BTN_Update.Text = "Sửa";
            this.BTN_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // BTN_Del
            // 
            this.BTN_Del.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Del.Image = global::DXQLMT.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete_24;
            this.BTN_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Del.Location = new System.Drawing.Point(225, 247);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(65, 34);
            this.BTN_Del.TabIndex = 13;
            this.BTN_Del.Text = "Xoá";
            this.BTN_Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.Image = global::DXQLMT.Properties.Resources.Kyo_Tux_Delikate_Add_24;
            this.BTN_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Add.Location = new System.Drawing.Point(144, 247);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 34);
            this.BTN_Add.TabIndex = 12;
            this.BTN_Add.Text = "Thêm";
            this.BTN_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 547);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.pic_img);
            this.Controls.Add(this.BTN_Insert);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.BTN_Del);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = global::DXQLMT.Properties.Resources.Etherbrian_Webuosities_Fix_it_32;
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Button BTN_Insert;
        private System.Windows.Forms.PictureBox pic_img;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.OpenFileDialog StreamImg;
        private System.Windows.Forms.Button BTN_Refresh;
    }
}