namespace BT1
{
    partial class frmTimKiem
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
            this.btnDong = new System.Windows.Forms.Button();
            this.goiY = new System.Windows.Forms.ToolTip(this.components);
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdMotDieuKien = new System.Windows.Forms.RadioButton();
            this.loiNhap = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCMND = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.rdTatCaDieuKien = new System.Windows.Forms.RadioButton();
            this.nhomKieuTim = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.loiNhap)).BeginInit();
            this.nhomKieuTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(514, 498);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 34);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(151, 160);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.ShowCheckBox = true;
            this.dtpNgaySinh.Size = new System.Drawing.Size(185, 28);
            this.dtpNgaySinh.TabIndex = 30;
            this.goiY.SetToolTip(this.dtpNgaySinh, "Đánh dấu ô vuông khi muốn tìm theo ngày sinh; bỏ dấu để không dùng điều kiện ngày" +
        ".");
            this.goiY.SetToolTip(this.dtpNgaySinh, "Đánh dấu ô vuông khi muốn tìm theo ngày sinh; bỏ dấu để không dùng điều kiện ngày" +
        ".");
            // 
            // rdMotDieuKien
            // 
            this.rdMotDieuKien.Location = new System.Drawing.Point(28, 27);
            this.rdMotDieuKien.Name = "rdMotDieuKien";
            this.rdMotDieuKien.Size = new System.Drawing.Size(279, 26);
            this.rdMotDieuKien.TabIndex = 1;
            this.rdMotDieuKien.Text = "Một điều kiện";
            // 
            // loiNhap
            // 
            this.loiNhap.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.loiNhap.ContainerControl = this;
            // 
            // lblMSSV
            // 
            this.lblMSSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(25, 24);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(120, 23);
            this.lblMSSV.TabIndex = 15;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblHo
            // 
            this.lblHo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHo.Location = new System.Drawing.Point(25, 66);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(120, 23);
            this.lblHo.TabIndex = 17;
            this.lblHo.Text = "Họ và tên lót:";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoLot.Location = new System.Drawing.Point(150, 61);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(185, 28);
            this.txtHoLot.TabIndex = 18;
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(367, 114);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(100, 23);
            this.lblTen.TabIndex = 19;
            this.lblTen.Text = "Tên:";
            // 
            // lblLop
            // 
            this.lblLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(367, 66);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(100, 23);
            this.lblLop.TabIndex = 22;
            this.lblLop.Text = "Lớp:";
            // 
            // lblCMND
            // 
            this.lblCMND.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(25, 116);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(120, 23);
            this.lblCMND.TabIndex = 23;
            this.lblCMND.Text = "Số CMND:";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(367, 165);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(100, 23);
            this.lblDienThoai.TabIndex = 25;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(25, 212);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(120, 23);
            this.lblDiaChi.TabIndex = 27;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(367, 24);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(91, 23);
            this.lblGioiTinh.TabIndex = 29;
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 165);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(88, 23);
            this.lblNgaySinh.TabIndex = 31;
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMon
            // 
            this.lblMon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.Location = new System.Drawing.Point(21, 273);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(120, 23);
            this.lblMon.TabIndex = 33;
            this.lblMon.Text = "Môn đăng ký:";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(362, 498);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 34);
            this.btnTim.TabIndex = 35;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(473, 109);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 28);
            this.txtTen.TabIndex = 36;
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(473, 63);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(187, 28);
            this.txtLop.TabIndex = 37;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(473, 23);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 38;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(580, 24);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 39;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(151, 207);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(509, 28);
            this.txtDiaChi.TabIndex = 40;
            // 
            // mtxtMSSV
            // 
            this.mtxtMSSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtMSSV.Location = new System.Drawing.Point(150, 15);
            this.mtxtMSSV.Mask = "0000000";
            this.mtxtMSSV.Name = "mtxtMSSV";
            this.mtxtMSSV.Size = new System.Drawing.Size(185, 28);
            this.mtxtMSSV.TabIndex = 41;
            // 
            // mtxtCMND
            // 
            this.mtxtCMND.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCMND.Location = new System.Drawing.Point(150, 109);
            this.mtxtCMND.Mask = "000000000";
            this.mtxtCMND.Name = "mtxtCMND";
            this.mtxtCMND.Size = new System.Drawing.Size(185, 28);
            this.mtxtCMND.TabIndex = 42;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSDT.Location = new System.Drawing.Point(473, 159);
            this.mtxtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.mtxtSDT.Mask = "0000.000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(187, 29);
            this.mtxtSDT.TabIndex = 43;
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.CheckOnClick = true;
            this.clbMonHoc.ColumnWidth = 250;
            this.clbMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "Mạng máy tính",
            "Hệ điều hành",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Đồ án cơ sở",
            "Phương pháp NCKH",
            "Lập trình trên thiết bị di động",
            "An toàn và bảo mật hệ thống"});
            this.clbMonHoc.Location = new System.Drawing.Point(142, 253);
            this.clbMonHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(542, 100);
            this.clbMonHoc.TabIndex = 44;
            // 
            // rdTatCaDieuKien
            // 
            this.rdTatCaDieuKien.Checked = true;
            this.rdTatCaDieuKien.Location = new System.Drawing.Point(326, 28);
            this.rdTatCaDieuKien.Name = "rdTatCaDieuKien";
            this.rdTatCaDieuKien.Size = new System.Drawing.Size(285, 26);
            this.rdTatCaDieuKien.TabIndex = 0;
            this.rdTatCaDieuKien.TabStop = true;
            this.rdTatCaDieuKien.Text = "Tất cả điều kiện";
            // 
            // nhomKieuTim
            // 
            this.nhomKieuTim.Controls.Add(this.rdTatCaDieuKien);
            this.nhomKieuTim.Controls.Add(this.rdMotDieuKien);
            this.nhomKieuTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhomKieuTim.Location = new System.Drawing.Point(29, 403);
            this.nhomKieuTim.Name = "nhomKieuTim";
            this.nhomKieuTim.Size = new System.Drawing.Size(615, 70);
            this.nhomKieuTim.TabIndex = 34;
            this.nhomKieuTim.TabStop = false;
            this.nhomKieuTim.Text = "Ghép các điều kiện";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 553);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.mtxtCMND);
            this.Controls.Add(this.mtxtMSSV);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.lblHo);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.nhomKieuTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnDong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTimKiem";
            this.Text = "Tìm kiếm sinh viên";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loiNhap)).EndInit();
            this.nhomKieuTim.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ToolTip goiY;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdMotDieuKien;
        private System.Windows.Forms.ErrorProvider loiNhap;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.MaskedTextBox mtxtCMND;
        private System.Windows.Forms.MaskedTextBox mtxtMSSV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.GroupBox nhomKieuTim;
        private System.Windows.Forms.RadioButton rdTatCaDieuKien;
    }
}