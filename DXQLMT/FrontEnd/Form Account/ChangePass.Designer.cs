namespace DXQLMT.FrontEnd.Form_Account
{
    partial class ChangePass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_repeat_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_pass_new = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_pass_old = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_ResetPass = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DXQLMT.Properties.Resources.icon_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.text_repeat_pass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.text_pass_new);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.text_pass_old);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.text_Id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 151);
            this.panel2.TabIndex = 1;
            // 
            // text_repeat_pass
            // 
            this.text_repeat_pass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_repeat_pass.Location = new System.Drawing.Point(147, 120);
            this.text_repeat_pass.Name = "text_repeat_pass";
            this.text_repeat_pass.PasswordChar = '*';
            this.text_repeat_pass.Size = new System.Drawing.Size(195, 22);
            this.text_repeat_pass.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // text_pass_new
            // 
            this.text_pass_new.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pass_new.Location = new System.Drawing.Point(147, 85);
            this.text_pass_new.Name = "text_pass_new";
            this.text_pass_new.PasswordChar = '*';
            this.text_pass_new.Size = new System.Drawing.Size(195, 22);
            this.text_pass_new.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // text_pass_old
            // 
            this.text_pass_old.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pass_old.Location = new System.Drawing.Point(147, 47);
            this.text_pass_old.Name = "text_pass_old";
            this.text_pass_old.PasswordChar = '*';
            this.text_pass_old.Size = new System.Drawing.Size(195, 22);
            this.text_pass_old.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // text_Id
            // 
            this.text_Id.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(147, 10);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(195, 22);
            this.text_Id.TabIndex = 3;
            this.text_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Account:";
            // 
            // BTN_ResetPass
            // 
            this.BTN_ResetPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ResetPass.Location = new System.Drawing.Point(250, 264);
            this.BTN_ResetPass.Name = "BTN_ResetPass";
            this.BTN_ResetPass.Size = new System.Drawing.Size(75, 23);
            this.BTN_ResetPass.TabIndex = 2;
            this.BTN_ResetPass.Text = "Apply";
            this.BTN_ResetPass.UseVisualStyleBackColor = true;
            this.BTN_ResetPass.Click += new System.EventHandler(this.BTN_ResetPass_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 299);
            this.Controls.Add(this.BTN_ResetPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::DXQLMT.Properties.Resources.Icons8_Windows_8_Security_Password_1_32;
            this.MaximumSize = new System.Drawing.Size(368, 331);
            this.MinimumSize = new System.Drawing.Size(368, 331);
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_repeat_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_pass_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_pass_old;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_ResetPass;
    }
}