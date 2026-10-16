using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class frmTimKiem : Form
    {
        private StudentManager ql;

        public List<Student> KetQua { get; private set; }

        public frmTimKiem(StudentManager quanLy)
        {
            InitializeComponent();

            ql = quanLy;
            KetQua = new List<Student>();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            // Mặc định tìm theo tất cả điều kiện
            rdTatCaDieuKien.Checked = true;

            // Ngày sinh chỉ được dùng khi người dùng tích chọn
            dtpNgaySinh.ShowCheckBox = true;
            dtpNgaySinh.Checked = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            string mssv = mtxtMSSV.Text.Trim();
            string hoLot = txtHoLot.Text.Trim();
            string cmnd = mtxtCMND.Text.Trim();
            string lop = txtLop.Text.Trim();
            string ten = txtTen.Text.Trim();
            string sdt = mtxtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            // Kiểm tra giới tính có được chọn làm điều kiện hay không
            bool timGioiTinh = rdNam.Checked || rdNu.Checked;

            string gioiTinh = "";

            if (rdNam.Checked)
                gioiTinh = "Nam";
            else if (rdNu.Checked)
                gioiTinh = "Nữ";

            // Lấy các môn học được tích
            List<string> dsMonTim = new List<string>();

            foreach (object item in clbMonHoc.CheckedItems)
            {
                dsMonTim.Add(item.ToString());
            }

            // Kiểm tra người dùng có nhập ít nhất một điều kiện không
            bool coDieuKien =
                mssv != "" ||
                hoLot != "" ||
                cmnd != "" ||
                lop != "" ||
                ten != "" ||
                sdt != "" ||
                diaChi != "" ||
                dtpNgaySinh.Checked ||
                timGioiTinh ||
                dsMonTim.Count > 0;

            if (!coDieuKien)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một điều kiện tìm kiếm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            List<Student> ketQua = new List<Student>();

            // Tìm theo TẤT CẢ điều kiện
            if (rdTatCaDieuKien.Checked)
            {
                foreach (Student sv in ql.DanhSach)
                {
                    bool dung = true;

                    if (mssv != "" &&
                        !sv.MSSV.Contains(mssv))
                    {
                        dung = false;
                    }

                    if (hoLot != "" &&
                        !sv.HoLot.ToLower().Contains(hoLot.ToLower()))
                    {
                        dung = false;
                    }

                    if (cmnd != "" &&
                        !sv.CMND.Contains(cmnd))
                    {
                        dung = false;
                    }

                    if (lop != "" &&
                        !sv.Lop.ToLower().Contains(lop.ToLower()))
                    {
                        dung = false;
                    }

                    if (ten != "" &&
                        !sv.Ten.ToLower().Contains(ten.ToLower()))
                    {
                        dung = false;
                    }

                    if (sdt != "" &&
                        !sv.SDT.Contains(sdt))
                    {
                        dung = false;
                    }

                    if (diaChi != "" &&
                        !sv.DiaChi.ToLower().Contains(diaChi.ToLower()))
                    {
                        dung = false;
                    }

                    if (dtpNgaySinh.Checked &&
                        sv.NgaySinh.Date != dtpNgaySinh.Value.Date)
                    {
                        dung = false;
                    }

                    if (timGioiTinh &&
                        sv.GioiTinh != gioiTinh)
                    {
                        dung = false;
                    }

                    // Sinh viên phải có tất cả các môn đã chọn
                    foreach (string mon in dsMonTim)
                    {
                        if (!sv.MonHoc.ToLower().Contains(mon.ToLower()))
                        {
                            dung = false;
                            break;
                        }
                    }

                    if (dung)
                        ketQua.Add(sv);
                }
            }

            // Tìm theo MỘT điều kiện
            else if (rdMotDieuKien.Checked)
            {
                foreach (Student sv in ql.DanhSach)
                {
                    bool dung = false;

                    if (mssv != "" && sv.MSSV.Contains(mssv))
                    {
                        dung = true;
                    }

                    if (hoLot != "" && sv.HoLot.ToLower().Contains(hoLot.ToLower()))
                    {
                        dung = true;
                    }

                    if (cmnd != "" && sv.CMND.Contains(cmnd))
                    {
                        dung = true;
                    }

                    if (lop != "" && sv.Lop.ToLower().Contains(lop.ToLower()))
                    {
                        dung = true;
                    }

                    if (ten != "" && sv.Ten.ToLower().Contains(ten.ToLower()))
                    {
                        dung = true;
                    }

                    if (sdt != "" && sv.SDT.Contains(sdt))
                    {
                        dung = true;
                    }

                    if (diaChi != "" && sv.DiaChi.ToLower().Contains(diaChi.ToLower()))
                    {
                        dung = true;
                    }

                    if (dtpNgaySinh.Checked && sv.NgaySinh.Date == dtpNgaySinh.Value.Date)
                    {
                        dung = true;
                    }

                    if (timGioiTinh && sv.GioiTinh == gioiTinh)
                    {
                        dung = true;
                    }

                    foreach (string mon in dsMonTim)
                    {
                        if (sv.MonHoc.ToLower().Contains(mon.ToLower()))
                        {
                            dung = true;
                            break;
                        }
                    }

                    if (dung)
                        ketQua.Add(sv);
                }
            }

            KetQua = ketQua;

            if (KetQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên phù hợp!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }

}

