namespace BaiTap2
{
    partial class Form1
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTimeGui = new System.Windows.Forms.ComboBox();
            this.dateTimeNgayGui = new System.Windows.Forms.DateTimePicker();
            this.tbSoTienGui = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.buttonThemMoi = new System.Windows.Forms.Button();
            this.buttonThemVaoDS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPhatLoc = new System.Windows.Forms.RadioButton();
            this.rbThuong = new System.Windows.Forms.RadioButton();
            this.Lb6 = new System.Windows.Forms.Label();
            this.Lb5 = new System.Windows.Forms.Label();
            this.Lb4 = new System.Windows.Forms.Label();
            this.Lb3 = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonThoat_Click = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.listBoxDanhSach = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbTimeGui);
            this.groupBox1.Controls.Add(this.dateTimeNgayGui);
            this.groupBox1.Controls.Add(this.tbSoTienGui);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.tbHoTen);
            this.groupBox1.Controls.Add(this.tbMaKH);
            this.groupBox1.Controls.Add(this.buttonThemMoi);
            this.groupBox1.Controls.Add(this.buttonThemVaoDS);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Lb6);
            this.groupBox1.Controls.Add(this.Lb5);
            this.groupBox1.Controls.Add(this.Lb4);
            this.groupBox1.Controls.Add(this.Lb3);
            this.groupBox1.Controls.Add(this.Lb2);
            this.groupBox1.Controls.Add(this.Lb1);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "( Tháng )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "(VND)";
            // 
            // cbTimeGui
            // 
            this.cbTimeGui.FormattingEnabled = true;
            this.cbTimeGui.Location = new System.Drawing.Point(120, 227);
            this.cbTimeGui.Name = "cbTimeGui";
            this.cbTimeGui.Size = new System.Drawing.Size(45, 21);
            this.cbTimeGui.TabIndex = 13;
            this.cbTimeGui.SelectedIndexChanged += new System.EventHandler(this.CbTimeGui_SelectedIndexChanged);
            // 
            // dateTimeNgayGui
            // 
            this.dateTimeNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayGui.Location = new System.Drawing.Point(101, 195);
            this.dateTimeNgayGui.Name = "dateTimeNgayGui";
            this.dateTimeNgayGui.Size = new System.Drawing.Size(155, 20);
            this.dateTimeNgayGui.TabIndex = 12;
            // 
            // tbSoTienGui
            // 
            this.tbSoTienGui.Location = new System.Drawing.Point(101, 156);
            this.tbSoTienGui.Name = "tbSoTienGui";
            this.tbSoTienGui.Size = new System.Drawing.Size(155, 20);
            this.tbSoTienGui.TabIndex = 11;
            this.tbSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSoTienGui_KeyPress);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(101, 118);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(155, 20);
            this.tbDiaChi.TabIndex = 10;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(101, 76);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(155, 20);
            this.tbHoTen.TabIndex = 9;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(101, 34);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(155, 20);
            this.tbMaKH.TabIndex = 8;
            this.tbMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMaKH_KeyPress);
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.Location = new System.Drawing.Point(219, 346);
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.Size = new System.Drawing.Size(89, 29);
            this.buttonThemMoi.TabIndex = 7;
            this.buttonThemMoi.Text = "Thêm mới";
            this.buttonThemMoi.UseVisualStyleBackColor = true;
            this.buttonThemMoi.Click += new System.EventHandler(this.ButtonThemMoi_Click);
            // 
            // buttonThemVaoDS
            // 
            this.buttonThemVaoDS.Location = new System.Drawing.Point(91, 346);
            this.buttonThemVaoDS.Name = "buttonThemVaoDS";
            this.buttonThemVaoDS.Size = new System.Drawing.Size(89, 29);
            this.buttonThemVaoDS.TabIndex = 6;
            this.buttonThemVaoDS.Text = "Thêm vào DS";
            this.buttonThemVaoDS.UseVisualStyleBackColor = true;
            this.buttonThemVaoDS.Click += new System.EventHandler(this.ButtonThemVaoDS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPhatLoc);
            this.groupBox3.Controls.Add(this.rbThuong);
            this.groupBox3.Location = new System.Drawing.Point(6, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 61);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại gửi tiết kiệm";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // rbPhatLoc
            // 
            this.rbPhatLoc.AutoSize = true;
            this.rbPhatLoc.Location = new System.Drawing.Point(225, 29);
            this.rbPhatLoc.Name = "rbPhatLoc";
            this.rbPhatLoc.Size = new System.Drawing.Size(64, 17);
            this.rbPhatLoc.TabIndex = 1;
            this.rbPhatLoc.TabStop = true;
            this.rbPhatLoc.Text = "Phát lộc";
            this.rbPhatLoc.UseVisualStyleBackColor = true;
            // 
            // rbThuong
            // 
            this.rbThuong.AutoSize = true;
            this.rbThuong.Location = new System.Drawing.Point(74, 29);
            this.rbThuong.Name = "rbThuong";
            this.rbThuong.Size = new System.Drawing.Size(62, 17);
            this.rbThuong.TabIndex = 0;
            this.rbThuong.TabStop = true;
            this.rbThuong.Text = "Thường";
            this.rbThuong.UseVisualStyleBackColor = true;
            // 
            // Lb6
            // 
            this.Lb6.AutoSize = true;
            this.Lb6.Location = new System.Drawing.Point(35, 230);
            this.Lb6.Name = "Lb6";
            this.Lb6.Size = new System.Drawing.Size(68, 13);
            this.Lb6.TabIndex = 4;
            this.Lb6.Text = "Thời gian gửi";
            // 
            // Lb5
            // 
            this.Lb5.AutoSize = true;
            this.Lb5.Location = new System.Drawing.Point(36, 195);
            this.Lb5.Name = "Lb5";
            this.Lb5.Size = new System.Drawing.Size(49, 13);
            this.Lb5.TabIndex = 3;
            this.Lb5.Text = "Ngày gửi";
            // 
            // Lb4
            // 
            this.Lb4.AutoSize = true;
            this.Lb4.Location = new System.Drawing.Point(35, 156);
            this.Lb4.Name = "Lb4";
            this.Lb4.Size = new System.Drawing.Size(57, 13);
            this.Lb4.TabIndex = 1;
            this.Lb4.Text = "Số tiền gửi";
            // 
            // Lb3
            // 
            this.Lb3.AutoSize = true;
            this.Lb3.Location = new System.Drawing.Point(35, 118);
            this.Lb3.Name = "Lb3";
            this.Lb3.Size = new System.Drawing.Size(40, 13);
            this.Lb3.TabIndex = 2;
            this.Lb3.Text = "Địa chỉ";
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Location = new System.Drawing.Point(35, 76);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(61, 13);
            this.Lb2.TabIndex = 1;
            this.Lb2.Text = "Họ Tên KH";
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Location = new System.Drawing.Point(35, 37);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(40, 13);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "Mã KH";
            this.Lb1.Click += new System.EventHandler(this.LbKH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonThoat_Click);
            this.groupBox2.Controls.Add(this.buttonTimKiem);
            this.groupBox2.Controls.Add(this.listBoxDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(410, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 338);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // buttonThoat
            // 
            this.buttonThoat_Click.Location = new System.Drawing.Point(220, 282);
            this.buttonThoat_Click.Name = "buttonThoat";
            this.buttonThoat_Click.Size = new System.Drawing.Size(89, 29);
            this.buttonThoat_Click.TabIndex = 9;
            this.buttonThoat_Click.Text = "thoát";
            this.buttonThoat_Click.UseVisualStyleBackColor = true;
            this.buttonThoat_Click.Click += new System.EventHandler(this.ButtonThoat_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(58, 282);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(89, 29);
            this.buttonTimKiem.TabIndex = 8;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.ButtonTimKiem_Click);
            // 
            // listBoxDanhSach
            // 
            this.listBoxDanhSach.FormattingEnabled = true;
            this.listBoxDanhSach.Location = new System.Drawing.Point(8, 16);
            this.listBoxDanhSach.Name = "listBoxDanhSach";
            this.listBoxDanhSach.Size = new System.Drawing.Size(354, 238);
            this.listBoxDanhSach.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tinh Lai Suat Tien Gui Tiet Kiem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonThemMoi;
        private System.Windows.Forms.Button buttonThemVaoDS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPhatLoc;
        private System.Windows.Forms.RadioButton rbThuong;
        private System.Windows.Forms.Label Lb6;
        private System.Windows.Forms.Label Lb5;
        private System.Windows.Forms.Label Lb4;
        private System.Windows.Forms.Label Lb3;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Label Lb1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonThoat_Click;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.ListBox listBoxDanhSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTimeGui;
        private System.Windows.Forms.DateTimePicker dateTimeNgayGui;
        private System.Windows.Forms.TextBox tbSoTienGui;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbMaKH;
    }
}

