namespace XML_QuanLyCoffeeShop.UI
{
    partial class FormQuanLyKhachHang
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
            this.txt_input_Sdt = new System.Windows.Forms.TextBox();
            this.txt_input_HoTen = new System.Windows.Forms.TextBox();
            this.txt_input_Id = new System.Windows.Forms.TextBox();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.txt_input_Ten_TimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.date_input_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbo_input_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_input_DiaChi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_input_CCCD = new System.Windows.Forms.TextBox();
            this.btn_TaiLai = new System.Windows.Forms.PictureBox();
            this.btn_TimKhachHang = new System.Windows.Forms.PictureBox();
            this.btn_XoaKhachHang = new System.Windows.Forms.PictureBox();
            this.btn_ThemKhachHang = new System.Windows.Forms.PictureBox();
            this.btn_SuaKhachHang = new System.Windows.Forms.PictureBox();
            this.btn_XemTrenWeb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TaiLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TimKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_XoaKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ThemKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SuaKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_input_Sdt
            // 
            this.txt_input_Sdt.Location = new System.Drawing.Point(268, 358);
            this.txt_input_Sdt.Name = "txt_input_Sdt";
            this.txt_input_Sdt.Size = new System.Drawing.Size(160, 22);
            this.txt_input_Sdt.TabIndex = 34;
            // 
            // txt_input_HoTen
            // 
            this.txt_input_HoTen.Location = new System.Drawing.Point(268, 115);
            this.txt_input_HoTen.Name = "txt_input_HoTen";
            this.txt_input_HoTen.Size = new System.Drawing.Size(160, 22);
            this.txt_input_HoTen.TabIndex = 31;
            // 
            // txt_input_Id
            // 
            this.txt_input_Id.Enabled = false;
            this.txt_input_Id.Location = new System.Drawing.Point(268, 54);
            this.txt_input_Id.Name = "txt_input_Id";
            this.txt_input_Id.Size = new System.Drawing.Size(160, 22);
            this.txt_input_Id.TabIndex = 30;
            this.txt_input_Id.TextChanged += new System.EventHandler(this.txt_input_Id_TextChanged);
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(497, 115);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(467, 325);
            this.dgv_KhachHang.TabIndex = 37;
            this.dgv_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellContentClick);
            // 
            // txt_input_Ten_TimKiem
            // 
            this.txt_input_Ten_TimKiem.Location = new System.Drawing.Point(508, 54);
            this.txt_input_Ten_TimKiem.Name = "txt_input_Ten_TimKiem";
            this.txt_input_Ten_TimKiem.Size = new System.Drawing.Size(160, 22);
            this.txt_input_Ten_TimKiem.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(99, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(99, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(99, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Họ và tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(99, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(102, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Số điện thoại";
            // 
            // date_input_NgaySinh
            // 
            this.date_input_NgaySinh.Location = new System.Drawing.Point(268, 176);
            this.date_input_NgaySinh.Name = "date_input_NgaySinh";
            this.date_input_NgaySinh.Size = new System.Drawing.Size(160, 22);
            this.date_input_NgaySinh.TabIndex = 38;
            // 
            // cbo_input_GioiTinh
            // 
            this.cbo_input_GioiTinh.FormattingEnabled = true;
            this.cbo_input_GioiTinh.Location = new System.Drawing.Point(268, 232);
            this.cbo_input_GioiTinh.Name = "cbo_input_GioiTinh";
            this.cbo_input_GioiTinh.Size = new System.Drawing.Size(160, 24);
            this.cbo_input_GioiTinh.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(102, 415);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Địa chỉ";
            // 
            // txt_input_DiaChi
            // 
            this.txt_input_DiaChi.Location = new System.Drawing.Point(268, 419);
            this.txt_input_DiaChi.Name = "txt_input_DiaChi";
            this.txt_input_DiaChi.Size = new System.Drawing.Size(160, 22);
            this.txt_input_DiaChi.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(102, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "CCCD";
            // 
            // txt_input_CCCD
            // 
            this.txt_input_CCCD.Location = new System.Drawing.Point(268, 293);
            this.txt_input_CCCD.Name = "txt_input_CCCD";
            this.txt_input_CCCD.Size = new System.Drawing.Size(160, 22);
            this.txt_input_CCCD.TabIndex = 34;
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.Image = global::XML_QuanLyCoffeeShop.Properties.Resources.ic_restart;
            this.btn_TaiLai.InitialImage = global::XML_QuanLyCoffeeShop.Properties.Resources.ic_restart;
            this.btn_TaiLai.Location = new System.Drawing.Point(740, 39);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(40, 40);
            this.btn_TaiLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_TaiLai.TabIndex = 36;
            this.btn_TaiLai.TabStop = false;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // btn_TimKhachHang
            // 
            this.btn_TimKhachHang.Image = global::XML_QuanLyCoffeeShop.Properties.Resources.ic_search;
            this.btn_TimKhachHang.Location = new System.Drawing.Point(674, 35);
            this.btn_TimKhachHang.Name = "btn_TimKhachHang";
            this.btn_TimKhachHang.Size = new System.Drawing.Size(50, 50);
            this.btn_TimKhachHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_TimKhachHang.TabIndex = 36;
            this.btn_TimKhachHang.TabStop = false;
            this.btn_TimKhachHang.Click += new System.EventHandler(this.btn_TimKhachHang_Click);
            // 
            // btn_XoaKhachHang
            // 
            this.btn_XoaKhachHang.Image = global::XML_QuanLyCoffeeShop.Properties.Resources.id_delete;
            this.btn_XoaKhachHang.Location = new System.Drawing.Point(12, 304);
            this.btn_XoaKhachHang.Name = "btn_XoaKhachHang";
            this.btn_XoaKhachHang.Size = new System.Drawing.Size(50, 50);
            this.btn_XoaKhachHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_XoaKhachHang.TabIndex = 24;
            this.btn_XoaKhachHang.TabStop = false;
            this.btn_XoaKhachHang.Click += new System.EventHandler(this.btn_XoaKhachHang_Click);
            // 
            // btn_ThemKhachHang
            // 
            this.btn_ThemKhachHang.Image = global::XML_QuanLyCoffeeShop.Properties.Resources.ic_add;
            this.btn_ThemKhachHang.Location = new System.Drawing.Point(12, 112);
            this.btn_ThemKhachHang.Name = "btn_ThemKhachHang";
            this.btn_ThemKhachHang.Size = new System.Drawing.Size(50, 50);
            this.btn_ThemKhachHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_ThemKhachHang.TabIndex = 22;
            this.btn_ThemKhachHang.TabStop = false;
            this.btn_ThemKhachHang.Click += new System.EventHandler(this.btn_ThemKhachHang_Click);
            // 
            // btn_SuaKhachHang
            // 
            this.btn_SuaKhachHang.Image = global::XML_QuanLyCoffeeShop.Properties.Resources.ic_update;
            this.btn_SuaKhachHang.Location = new System.Drawing.Point(12, 206);
            this.btn_SuaKhachHang.Name = "btn_SuaKhachHang";
            this.btn_SuaKhachHang.Size = new System.Drawing.Size(50, 50);
            this.btn_SuaKhachHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_SuaKhachHang.TabIndex = 23;
            this.btn_SuaKhachHang.TabStop = false;
            this.btn_SuaKhachHang.Click += new System.EventHandler(this.btn_SuaKhachHang_Click);
            // 
            // btn_XemTrenWeb
            // 
            this.btn_XemTrenWeb.AutoSize = true;
            this.btn_XemTrenWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemTrenWeb.ForeColor = System.Drawing.Color.White;
            this.btn_XemTrenWeb.Location = new System.Drawing.Point(797, 54);
            this.btn_XemTrenWeb.Name = "btn_XemTrenWeb";
            this.btn_XemTrenWeb.Size = new System.Drawing.Size(144, 25);
            this.btn_XemTrenWeb.TabIndex = 26;
            this.btn_XemTrenWeb.Text = "Xem trên web";
            this.btn_XemTrenWeb.Click += new System.EventHandler(this.btn_XemTrenWeb_Click);
            // 
            // FormQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 523);
            this.Controls.Add(this.cbo_input_GioiTinh);
            this.Controls.Add(this.date_input_NgaySinh);
            this.Controls.Add(this.txt_input_DiaChi);
            this.Controls.Add(this.txt_input_CCCD);
            this.Controls.Add(this.txt_input_Sdt);
            this.Controls.Add(this.txt_input_HoTen);
            this.Controls.Add(this.txt_input_Id);
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.btn_TaiLai);
            this.Controls.Add(this.btn_TimKhachHang);
            this.Controls.Add(this.txt_input_Ten_TimKiem);
            this.Controls.Add(this.btn_XoaKhachHang);
            this.Controls.Add(this.btn_ThemKhachHang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_XemTrenWeb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_SuaKhachHang);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Name = "FormQuanLyKhachHang";
            this.Text = "FormQuanLyKhachHang";
            this.Load += new System.EventHandler(this.FormQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TaiLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TimKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_XoaKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ThemKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SuaKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input_Sdt;
        private System.Windows.Forms.TextBox txt_input_HoTen;
        private System.Windows.Forms.TextBox txt_input_Id;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.PictureBox btn_TimKhachHang;
        private System.Windows.Forms.TextBox txt_input_Ten_TimKiem;
        private System.Windows.Forms.PictureBox btn_XoaKhachHang;
        private System.Windows.Forms.PictureBox btn_ThemKhachHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btn_SuaKhachHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker date_input_NgaySinh;
        private System.Windows.Forms.ComboBox cbo_input_GioiTinh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_input_DiaChi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_input_CCCD;
        private System.Windows.Forms.PictureBox btn_TaiLai;
        private System.Windows.Forms.Label btn_XemTrenWeb;
    }
}