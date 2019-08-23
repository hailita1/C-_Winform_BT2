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
    public partial class Form2 : Form
    {
        List<NguoiGui> ListNguoiGui = new List<NguoiGui>();
        public Form2()
        {
            InitializeComponent();
            ListNguoiGui = StaticData._NguoiGui;
        }

        private void BtTimKiem_Click(object sender, EventArgs e)
        {
            int timKiem = 0;
            foreach (NguoiGui i in ListNguoiGui)
            {
                if(i.TenKH1 == (textBox1.Text))
                {
                    timKiem = 1;
                    MessageBox.Show("Tìm thấy khách hàng !!!");
                    tbTimKiem.Items.Add ( "Khách hàng " + i.MaKH1 + " phải trả " + i.Tien1 + " nghìn đồng");
                }
            }
            if(timKiem ==0)
            {
                MessageBox.Show("Không tìm thấy khách hàng !!!");
            }

        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
