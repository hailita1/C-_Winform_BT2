using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class Form1 : Form
    {
        List<NguoiGui> listNguoiGui = new List<NguoiGui>();
        public Form1()
        {
            InitializeComponent();
        }
        private void AddComboBox()
        {
            cbTimeGui.Items.Add("1");
            cbTimeGui.Items.Add("3");
            cbTimeGui.Items.Add("6");
            cbTimeGui.Items.Add("12");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();
            this.KeyPreview = true;

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void LbKH_Click(object sender, EventArgs e)
        {

        }

        private void CbTimeGui_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TbSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonThemMoi_Click(object sender, EventArgs e)
        {
            tbMaKH.Text = "";
            tbHoTen.Text = "";
            tbDiaChi.Text = "";
            tbSoTienGui.Text = "";
            dateTimeNgayGui.Text = "";
            cbTimeGui.Text = "";
            cbTimeGui.SelectedIndex = -1;
            rbThuong.Checked = false;
            rbPhatLoc.Checked = false;
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
            {

            }
        }

        private void ButtonThemVaoDS_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (tbMaKH.TextLength < 6)
            {
                MessageBox.Show("Nhập sai vì mã nhỏ hơn 6 !!!");
                kt = 0;
            }
            if (tbHoTen.TextLength == 0 || tbDiaChi.TextLength == 0)
            {
                MessageBox.Show("Nhập sai vì tên hoặc địa chỉ rỗng !!!");
                kt = 0;
            }
            double tienlai = 0;
            if (kt == 1)
            {
                if (rbThuong.Checked == true)
                {

                    if (cbTimeGui.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.06;
                    }
                    if (cbTimeGui.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.07;
                    }
                    if (cbTimeGui.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.08;
                    }
                    if (cbTimeGui.SelectedItem == "12")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.09;
                    }
                }
            }
            else if (rbPhatLoc.Checked == true)
            {
                if (cbTimeGui.SelectedItem == "1")
                {
                    tienlai = Convert.ToInt32(tbSoTienGui) * 0.07;
                }
                if (cbTimeGui.SelectedItem == "3")
                {
                    tienlai = Convert.ToInt32(tbSoTienGui) * 0.08;
                }
                if (cbTimeGui.SelectedItem == "6")
                {
                    tienlai = Convert.ToInt32(tbSoTienGui) * 0.09;
                }
                if (cbTimeGui.SelectedItem == "12")
                {
                    tienlai = Convert.ToInt32(tbSoTienGui) * 0.1;
                }
            }
            listBoxDanhSach.Items.Add(tbMaKH.Text + " | " + tbHoTen.Text + " | " + tbDiaChi.Text + " | " + dateTimeNgayGui.Text + " | " +
            tbSoTienGui.Text + " | " + cbTimeGui.Text + " tháng | " + tienlai);

            listNguoiGui.Add(new NguoiGui(Convert.ToInt32(tbMaKH.Text), tbHoTen.Text, tbDiaChi.Text, Convert.ToInt32(tbSoTienGui.Text), dateTimeNgayGui.Text, cbTimeGui.Text, tienlai));
            StaticData._NguoiGui = listNguoiGui;
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.H))
                {
                    ButtonThoat_Click(null, null);
                }
               // if (e.KeyCode.Equals(Keys.M))
               // {
              //      ButtonThemMoi_Click(null, null);
               // }
            }
        }
    }
}
