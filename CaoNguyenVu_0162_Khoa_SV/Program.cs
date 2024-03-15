using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_Khoa_SV
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Khoa> listFaculty = new List<Khoa>
                {
                    new Khoa ("CNS", "Khoa Cong nghe so", 29),
                    new Khoa ("XD", "Khoa Xay dung", 29),
                    new Khoa ("CK", "Khoa Co khi", 29),
                    new Khoa ("DDT", "Khoa Dien dien tu", 29)


                };
            List<SinhVien> listStudent = new List<SinhVien>
                {
                    new SinhVien ("00006", "Yen", 8, "CNS", "21T3" , DateTime.Parse("2004-11-22"),"Nu"),
                    new SinhVien ("00001", "Vu", 9, "CNS", "21T1" ,DateTime.Parse("2003-01-19"),"Nam"),
                    new SinhVien ("00009", "Thang", 2, "CK", "21CK1" , DateTime.Parse("2003-11-25"),"Nam"),
                    new SinhVien ("00005", "Nhu", 8, "CNS", "21T2" , DateTime.Parse("2003-08-24"),"Nu"),
                    new SinhVien ("10001", "Thong", 5, "DDT", "21THD1" , DateTime.Parse("2003-06-20"),"Nam"),
                    new SinhVien ("10002", "Khoa", 1, "XD", "21XD1" , DateTime.Parse("2005-02-25"),"Nam"),
                };

            var listSVwithKhoa = listStudent.OrderBy(sv => sv.MaKhoa).ThenBy(sv => sv.TenSinhVien).Select(group => new
            {
                tensinhvien = group.TenSinhVien,
                makhoa = group.MaKhoa
            });
            var listStudentWithScore7 = listStudent.Where(sv => sv.DiemTB > 7);
            var listStudentWithScore4 = listStudent.Where(sv => sv.DiemTB < 4);

            var checkStudentWithName = listStudent.Where(sv => sv.TenSinhVien.Equals("Khoa")).Any();
            var listStudentWithName = listStudent.Where(sv => sv.TenSinhVien.Equals("Khoa"));
            var printSV = listStudent.Join(listFaculty, sinhvien => sinhvien.MaKhoa, khoa => khoa.MaKhoa,
               (sv, kh) => new { tenSV = sv.TenSinhVien, tenKhoa = kh.TenKhoa });
            var studentHighScore = listStudent.OrderByDescending(sv => sv.DiemTB).First();
            
            
            
           

            Console.WriteLine("\n ------- Danh sach sinh vien theo khoa, sap xep ten ------- ");

            Console.WriteLine("+---------------+---------+");
            Console.WriteLine("| Ten sinh vien | Ma khoa |");
            Console.WriteLine("+---------------+---------+");
            foreach (var item in listSVwithKhoa)
                Console.WriteLine("| {0,-13} | {1,-7} |",item.tensinhvien, item.makhoa);

            Console.WriteLine("+--------------+---------+");

            ///////// 

            Console.WriteLine("\n ------- Danh sach sinh vien co diem trung binh > 7 ------- ");
            Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
            Console.WriteLine("| Ma sinh vien | Ten sinh vien | Diem trung binh | Ma khoa |  Lop  |        Ngay sinh       | Gioi tinh |");
            Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
            foreach (var item in listStudentWithScore7)
                 Console.WriteLine("| {0,-12} | {1,-13} | {2,-15} | {3,-7} | {4,-5} | {5,-22} | {6,-9} |", item.MaSinhVien, item.TenSinhVien,
                item.DiemTB, item.MaKhoa, item.Lop, item.NgaySinh, item.GioiTinh);

            Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
            
            ////////

            Console.WriteLine("\n ------- Danh sach sinh vien co diem trung binh < 4 ------- ");
            Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
            Console.WriteLine("| Ma sinh vien | Ten sinh vien | Diem trung binh | Ma khoa |  Lop  |        Ngay sinh       | Gioi tinh |");
            Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
            foreach (var item in listStudentWithScore4)
                Console.WriteLine("| {0,-12} | {1,-13} | {2,-15} | {3,-7} | {4,-5} | {5,-22} | {6,-9} |", item.MaSinhVien, item.TenSinhVien,
                item.DiemTB, item.MaKhoa, item.Lop, item.NgaySinh, item.GioiTinh);

            Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");

            ///////

            Console.WriteLine("\n ------- Danh sach sinh vien co ten 'Khoa' ------- ");
            if (checkStudentWithName == true)
            {
                Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
                Console.WriteLine("| Ma sinh vien | Ten sinh vien | Diem trung binh | Ma khoa |  Lop  |        Ngay sinh       | Gioi tinh |");
                Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
                foreach (var item in listStudentWithName)
                    Console.WriteLine("| {0,-12} | {1,-13} | {2,-15} | {3,-7} | {4,-5} | {5,-22} | {6,-9} |", item.MaSinhVien, item.TenSinhVien,
                item.DiemTB, item.MaKhoa, item.Lop, item.NgaySinh, item.GioiTinh);

                Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
            }

            /////////
            

            Console.WriteLine("\n ------- Danh sach sinh vien co thong tin Khoa ------- ");
            Console.WriteLine("+---------------+-------------------+");
            Console.WriteLine("| Ten sinh vien |      Ten khoa     |");
            Console.WriteLine("+---------------+-------------------+");
            foreach (var item in printSV)
                Console.WriteLine("| {0,-13} | {1,-17} |",item.tenSV, item.tenKhoa);
            Console.WriteLine("+---------------+-------------------+");



            Console.WriteLine(" ------- Sinh vien gioi nhat ------- ");
            Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
            Console.WriteLine("| Ma sinh vien | Ten sinh vien | Diem trung binh | Ma khoa |  Lop  |        Ngay sinh       | Gioi tinh |");
            Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
            Console.WriteLine("| {0,-12} | {1,-13} | {2,-15} | {3,-7} | {4,-5} | {5,-22} | {6,-9} |", studentHighScore.MaSinhVien, studentHighScore.TenSinhVien,
                studentHighScore.DiemTB, studentHighScore.MaKhoa, studentHighScore.Lop, studentHighScore.NgaySinh, studentHighScore.GioiTinh);

            Console.WriteLine("+--------------+---------------+-----------------+---------+-------+------------------------+-----------+");
            Console.ReadLine();

        }
    }
}
