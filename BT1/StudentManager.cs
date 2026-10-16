using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace BT1
{
    public class StudentManager
    {

        public List<Student> DanhSach { get; set; }

        private string fileName = Path.Combine(Application.StartupPath, @"..\..\student.txt");

        public StudentManager()
        {
            DanhSach = new List<Student>();
        }

        public bool Them(Student sv)
        {
            foreach (Student x in DanhSach)
            {
                if (x.MSSV == sv.MSSV)
                    return false;
            }

            DanhSach.Add(sv);
            LuuFile();

            return true;
        }

        public void LuuFile()
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (Student sv in DanhSach)
                {
                    sw.WriteLine(
                        sv.MSSV + "|" +
                        sv.HoLot + "|" +
                        sv.Ten + "|" +
                        sv.NgaySinh.ToString("dd/MM/yyyy") + "|" +
                        sv.Lop + "|" +
                        sv.CMND + "|" +
                        sv.SDT + "|" +
                        sv.DiaChi + "|" +
                        sv.GioiTinh + "|" +
                        sv.MonHoc
                    );
                }
            }
        }

        public void DocFile()
        {
            DanhSach.Clear();

            if (!File.Exists(fileName))
                return;

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] p = line.Split('|');

                if (p.Length < 10)
                    continue;

                Student sv = new Student();

                sv.MSSV = p[0];
                sv.HoLot = p[1];
                sv.Ten = p[2];
                DateTime ngaySinh;

                if (DateTime.TryParseExact(
                    p[3],
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out ngaySinh))
                {
                    sv.NgaySinh = ngaySinh;
                }
                else
                {
                    continue;
                }
                sv.Lop = p[4];
                sv.CMND = p[5];
                sv.SDT = p[6];
                sv.DiaChi = p[7];
                sv.GioiTinh = p[8];
                sv.MonHoc = p[9];

                DanhSach.Add(sv);
            }
        }
        public bool CapNhat(string mssvCu, Student svMoi)
        {
            foreach (Student sv in DanhSach)
            {
                if (sv.MSSV == mssvCu)
                {
                    sv.MSSV = svMoi.MSSV;
                    sv.HoLot = svMoi.HoLot;
                    sv.Ten = svMoi.Ten;
                    sv.NgaySinh = svMoi.NgaySinh;
                    sv.Lop = svMoi.Lop;
                    sv.CMND = svMoi.CMND;
                    sv.SDT = svMoi.SDT;
                    sv.DiaChi = svMoi.DiaChi;
                    sv.GioiTinh = svMoi.GioiTinh;
                    sv.MonHoc = svMoi.MonHoc;

                    LuuFile();
                    return true;
                }
            }

            return false;
        }
        public List<Student> TimKiem(string tuKhoa)
        {
            List<Student> ketQua = new List<Student>();

            tuKhoa = tuKhoa.Trim().ToLower();

            foreach (Student sv in DanhSach)
            {
                if (sv.MSSV.ToLower().Contains(tuKhoa) ||
                    sv.Ten.ToLower().Contains(tuKhoa) ||
                    sv.Lop.ToLower().Contains(tuKhoa))
                {
                    ketQua.Add(sv);
                }
            }

            return ketQua;
        }
        public bool Xoa(string mssv)
        {
            Student svCanXoa = null;

            foreach (Student sv in DanhSach)
            {
                if (sv.MSSV == mssv)
                {
                    svCanXoa = sv;
                    break;
                }
            }

            if (svCanXoa == null)
                return false;

            DanhSach.Remove(svCanXoa);
            LuuFile();

            return true;
        }
        public void XoaNhieu(List<string> danhSachMSSV)
        {
            for (int i = DanhSach.Count - 1; i >= 0; i--)
            {
                if (danhSachMSSV.Contains(DanhSach[i].MSSV))
                {
                    DanhSach.RemoveAt(i);
                }
            }

            LuuFile();
        }
    }
}
