namespace DXQLMT
{
    partial class FormCentrer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCentrer));
            this.Frm_main = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.gridControl_centrer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.txt_search = new DevExpress.XtraEditors.TextEdit();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.ACD_Main = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.Menu_home = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Menu_products = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Menu_products_dell = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Item_Latidue = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Item_Vostro = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Item_inspiron = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menu_products_acer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Item_Nitro = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menu_update_products = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menu_Bill = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menu_create_bill = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menu_Thongke = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menu_logout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.Frm_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_centrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACD_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Frm_main
            // 
            this.Frm_main.Controls.Add(this.gridControl_centrer);
            this.Frm_main.Controls.Add(this.panelControl1);
            this.Frm_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frm_main.Location = new System.Drawing.Point(250, 31);
            this.Frm_main.Name = "Frm_main";
            this.Frm_main.Size = new System.Drawing.Size(833, 554);
            this.Frm_main.TabIndex = 0;
            // 
            // gridControl_centrer
            // 
            this.gridControl_centrer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl_centrer.Location = new System.Drawing.Point(0, 116);
            this.gridControl_centrer.MainView = this.gridView1;
            this.gridControl_centrer.Name = "gridControl_centrer";
            this.gridControl_centrer.Size = new System.Drawing.Size(833, 438);
            this.gridControl_centrer.TabIndex = 1;
            this.gridControl_centrer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl_centrer.Click += new System.EventHandler(this.gridControl_centrer_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_centrer;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowHeight = 60;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.BTN_Search);
            this.panelControl1.Controls.Add(this.txt_search);
            this.panelControl1.Location = new System.Drawing.Point(242, 31);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(550, 79);
            this.panelControl1.TabIndex = 0;
            // 
            // BTN_Search
            // 
            this.BTN_Search.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.Image = global::DXQLMT.Properties.Resources.Gianni_Polito_Colobrush_Loupe_24;
            this.BTN_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Search.Location = new System.Drawing.Point(370, 31);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(117, 38);
            this.BTN_Search.TabIndex = 2;
            this.BTN_Search.Text = "Tìm kiếm";
            this.BTN_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click_1);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(57, 37);
            this.txt_search.MenuManager = this.fluentFormDefaultManager1;
            this.txt_search.Name = "txt_search";
            this.txt_search.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Properties.Appearance.Options.UseFont = true;
            this.txt_search.Size = new System.Drawing.Size(307, 24);
            this.txt_search.TabIndex = 0;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // ACD_Main
            // 
            this.ACD_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.ACD_Main.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Menu_home,
            this.Menu_products,
            this.menu_Bill,
            this.accordionControlElement1,
            this.menu_logout});
            this.ACD_Main.Location = new System.Drawing.Point(0, 31);
            this.ACD_Main.Name = "ACD_Main";
            this.ACD_Main.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.ACD_Main.Size = new System.Drawing.Size(250, 554);
            this.ACD_Main.TabIndex = 1;
            this.ACD_Main.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // Menu_home
            // 
            this.Menu_home.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Menu_home.ImageOptions.SvgImage")));
            this.Menu_home.Name = "Menu_home";
            this.Menu_home.Text = "Home";
            this.Menu_home.Click += new System.EventHandler(this.Menu_home_Click);
            // 
            // Menu_products
            // 
            this.Menu_products.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Menu_products_dell,
            this.menu_products_acer,
            this.menu_update_products});
            this.Menu_products.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Menu_products.ImageOptions.SvgImage")));
            this.Menu_products.Name = "Menu_products";
            this.Menu_products.Text = "Products";
            // 
            // Menu_products_dell
            // 
            this.Menu_products_dell.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Item_Latidue,
            this.Item_Vostro,
            this.Item_inspiron});
            this.Menu_products_dell.ImageOptions.Image = global::DXQLMT.Properties.Resources.Dakirby309_Windows_8_Metro_Web_Dell_Metro_24;
            this.Menu_products_dell.Name = "Menu_products_dell";
            this.Menu_products_dell.Text = "Sản phẩm của Dell";
            this.Menu_products_dell.Click += new System.EventHandler(this.Menu_products_dell_Click);
            // 
            // Item_Latidue
            // 
            this.Item_Latidue.Name = "Item_Latidue";
            this.Item_Latidue.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Item_Latidue.Text = "Dell Latidue";
            this.Item_Latidue.Click += new System.EventHandler(this.Item_Latidue_Click);
            // 
            // Item_Vostro
            // 
            this.Item_Vostro.Name = "Item_Vostro";
            this.Item_Vostro.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Item_Vostro.Text = "Dell Vostro";
            this.Item_Vostro.Click += new System.EventHandler(this.Item_Vostro_Click);
            // 
            // Item_inspiron
            // 
            this.Item_inspiron.Name = "Item_inspiron";
            this.Item_inspiron.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Item_inspiron.Text = "Dell Inspiron";
            this.Item_inspiron.Click += new System.EventHandler(this.Item_inspiron_Click);
            // 
            // menu_products_acer
            // 
            this.menu_products_acer.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Item_Nitro});
            this.menu_products_acer.ImageOptions.Image = global::DXQLMT.Properties.Resources.Dakirby309_Windows_8_Metro_Web_Acer_Metro_24;
            this.menu_products_acer.Name = "menu_products_acer";
            this.menu_products_acer.Text = "Sản phẩm của Acer";
            this.menu_products_acer.Click += new System.EventHandler(this.menu_products_acer_Click);
            // 
            // Item_Nitro
            // 
            this.Item_Nitro.Name = "Item_Nitro";
            this.Item_Nitro.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Item_Nitro.Text = "Acer Nitro";
            this.Item_Nitro.Click += new System.EventHandler(this.Item_Nitro_Click);
            // 
            // menu_update_products
            // 
            this.menu_update_products.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menu_update_products.ImageOptions.SvgImage")));
            this.menu_update_products.Name = "menu_update_products";
            this.menu_update_products.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menu_update_products.Text = "Chỉnh sửa sản phẩm";
            this.menu_update_products.Click += new System.EventHandler(this.menu_update_products_Click);
            // 
            // menu_Bill
            // 
            this.menu_Bill.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menu_create_bill,
            this.menu_Thongke});
            this.menu_Bill.Expanded = true;
            this.menu_Bill.ImageOptions.Image = global::DXQLMT.Properties.Resources.Icons8_Windows_8_Ecommerce_Bill_24;
            this.menu_Bill.Name = "menu_Bill";
            this.menu_Bill.Text = "Bill";
            // 
            // menu_create_bill
            // 
            this.menu_create_bill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menu_create_bill.ImageOptions.Image")));
            this.menu_create_bill.Name = "menu_create_bill";
            this.menu_create_bill.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menu_create_bill.Text = "Tạo hoá đơn";
            this.menu_create_bill.Click += new System.EventHandler(this.menu_create_bill_Click);
            // 
            // menu_Thongke
            // 
            this.menu_Thongke.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menu_Thongke.ImageOptions.Image")));
            this.menu_Thongke.Name = "menu_Thongke";
            this.menu_Thongke.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menu_Thongke.Text = "Thống kê tài chính";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Accounts";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // menu_logout
            // 
            this.menu_logout.ImageOptions.Image = global::DXQLMT.Properties.Resources.Icons8_Windows_8_User_Interface_Logout_32;
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Text = "Log Out";
            this.menu_logout.Click += new System.EventHandler(this.menu_logout_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1083, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // FormCentrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 585);
            this.ControlContainer = this.Frm_main;
            this.Controls.Add(this.Frm_main);
            this.Controls.Add(this.ACD_Main);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::DXQLMT.Properties.Resources.Inipagi_Job_Seeker_Laptop_1_48;
            this.MaximumSize = new System.Drawing.Size(1085, 586);
            this.MinimumSize = new System.Drawing.Size(1085, 586);
            this.Name = "FormCentrer";
            this.NavigationControl = this.ACD_Main;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa hàng máy tính NTH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCentrer_FormClosing);
            this.Load += new System.EventHandler(this.FormCentrer_Load);
            this.Frm_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_centrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACD_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer Frm_main;
        private DevExpress.XtraBars.Navigation.AccordionControl ACD_Main;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txt_search;
        private DevExpress.XtraGrid.GridControl gridControl_centrer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button BTN_Search;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Menu_home;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Menu_products;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Menu_products_dell;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menu_products_acer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menu_update_products;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menu_Bill;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menu_create_bill;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menu_Thongke;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Item_Latidue;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Item_Vostro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Item_inspiron;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Item_Nitro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menu_logout;
    }
}

