namespace DXQLMT.FrontEnd.Form_Account
{
    partial class Faccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_changePass = new System.Windows.Forms.Button();
            this.BTN_Del = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_account);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Account";
            // 
            // dgv_account
            // 
            this.dgv_account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_account.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Location = new System.Drawing.Point(6, 25);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.Size = new System.Drawing.Size(401, 193);
            this.dgv_account.TabIndex = 1;
            this.dgv_account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_CellClick);
            this.dgv_account.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_account_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(516, 59);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(169, 22);
            this.txt_Id.TabIndex = 4;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DisplayName.Location = new System.Drawing.Point(516, 116);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.Size = new System.Drawing.Size(169, 22);
            this.txt_DisplayName.TabIndex = 5;
            // 
            // txt_type
            // 
            this.txt_type.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type.Location = new System.Drawing.Point(516, 168);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(169, 22);
            this.txt_type.TabIndex = 6;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.Image = global::DXQLMT.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh_24;
            this.BTN_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Refresh.Location = new System.Drawing.Point(516, 256);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(90, 38);
            this.BTN_Refresh.TabIndex = 11;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // BTN_changePass
            // 
            this.BTN_changePass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_changePass.Image = global::DXQLMT.Properties.Resources.Icons8_Windows_8_Security_Password_1_32;
            this.BTN_changePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_changePass.Location = new System.Drawing.Point(364, 256);
            this.BTN_changePass.Name = "BTN_changePass";
            this.BTN_changePass.Size = new System.Drawing.Size(129, 38);
            this.BTN_changePass.TabIndex = 10;
            this.BTN_changePass.Text = "Change Pass";
            this.BTN_changePass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_changePass.UseVisualStyleBackColor = true;
            this.BTN_changePass.Click += new System.EventHandler(this.BTN_changePass_Click);
            // 
            // BTN_Del
            // 
            this.BTN_Del.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Del.Image = global::DXQLMT.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete_24;
            this.BTN_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Del.Location = new System.Drawing.Point(274, 256);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(66, 38);
            this.BTN_Del.TabIndex = 9;
            this.BTN_Del.Text = "Xoá";
            this.BTN_Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Reset.Image = global::DXQLMT.Properties.Resources.Icons8_Ios7_Users_Change_User_32;
            this.BTN_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Reset.Location = new System.Drawing.Point(150, 256);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(108, 38);
            this.BTN_Reset.TabIndex = 8;
            this.BTN_Reset.Text = "Cập nhật";
            this.BTN_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.Image = global::DXQLMT.Properties.Resources.Kyo_Tux_Delikate_Add_32;
            this.BTN_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Add.Location = new System.Drawing.Point(39, 256);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(90, 38);
            this.BTN_Add.TabIndex = 7;
            this.BTN_Add.Text = "Thêm";
            this.BTN_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // Faccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 323);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.BTN_changePass);
            this.Controls.Add(this.BTN_Del);
            this.Controls.Add(this.BTN_Reset);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_DisplayName);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.Image = global::DXQLMT.Properties.Resources.Pictogrammers_Material_Account_box_32;
            this.MaximumSize = new System.Drawing.Size(699, 355);
            this.MinimumSize = new System.Drawing.Size(699, 355);
            this.Name = "Faccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Faccount_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.Button BTN_changePass;
        private System.Windows.Forms.Button BTN_Refresh;
    }
}