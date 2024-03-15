using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_Khoa_SV
{
    class SinhVien
    {
        private string maSinhVien;
        public string MaSinhVien
        {
            set { this.maSinhVien = value; }
            get { return this.maSinhVien; }
        }
        private string tenSinhVien;
        public String TenSinhVien
        {
            set { this.tenSinhVien = value; }
            get { return this.tenSinhVien; }
        }
        private double diemTB;
        public double DiemTB
        {
            set { this.diemTB = value; }
            get { return this.diemTB; }
        }

        private string maKhoa;
        public string MaKhoa
        {
            set { this.maKhoa = value; }
            get { return this.maKhoa; }
        }
        private string lop;
        public string Lop
        {
            set { this.lop = value; }
            get { return this.lop; }
        }
        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            set { this.NgaySinh = value; }
            get { return this.ngaySinh; }
        }
        private string gioiTinh;
        public string GioiTinh
        {
            set { this.gioiTinh = value; }
            get { return this.gioiTinh; }
        }
        public SinhVien(string maSinhVien, string tenSinhVien, double diemTB, string maKhoa, string lop
            , DateTime ngaySinh, string gioiTinh )
        {
            this.maSinhVien = maSinhVien;
            this.tenSinhVien = tenSinhVien;
            this.diemTB = diemTB;
            this.maKhoa = maKhoa;
            this.lop = lop;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
        }
         
    }
}
