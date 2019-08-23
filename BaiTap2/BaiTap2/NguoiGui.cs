using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class NguoiGui
    {
        private int MaKH;
        private string TenKH;
        private string DiaChi;
        private int SoTienGui;
        private string NgayGui;
        private string ThoiGianGui;
        private double Tien;
        public NguoiGui(int MaKH)
        {
            this.MaKH = MaKH;
        }
        public NguoiGui(int MaKH, string TenKH, string DiaChi, int SoTienGui, string NgayGui, string ThoiGianGui, double Tien)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.DiaChi = DiaChi;
            this.SoTienGui = SoTienGui;
            this.NgayGui = NgayGui;
            this.ThoiGianGui = ThoiGianGui;
            this.Tien = Tien;
        }

        public int MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int SoTienGui1 { get => SoTienGui; set => SoTienGui = value; }
        public string NgayGui1 { get => NgayGui; set => NgayGui = value; }
        public string ThoiGianGui1 { get => ThoiGianGui; set => ThoiGianGui = value; }
        public double Tien1 { get => Tien; set => Tien = value; }
    }
}
