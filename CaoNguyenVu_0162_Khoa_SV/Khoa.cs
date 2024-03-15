using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_Khoa_SV
{
    class Khoa
    {
        private string maKhoa;
        public string MaKhoa
        {
            set { this.maKhoa = value; }
            get { return this.maKhoa; }
        }
        private string tenKhoa;
        public String TenKhoa
        {
            set { this.tenKhoa = value; }
            get { return this.tenKhoa; }
        }

        private int soLuongGiangVien;
        public int SoLuongGiangVien
        {
            set { this.soLuongGiangVien = value; }
            get { return this.soLuongGiangVien; }
        }
        public Khoa(string maKhoa, string tenKhoa, int soLuongGiangVien)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.soLuongGiangVien = soLuongGiangVien;
        }

    }
}
