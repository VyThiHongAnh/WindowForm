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
    public partial class frmSinhVien : Form
    {
        private string mssvCu = "";
        private bool dangHienThiSinhVien = false;
        StudentManager ql = new StudentManager();
        public frmSinhVien()
        {
            InitializeComponent();
        }

        //1. Lấy dữ liệu từ form
        private Student GetStudentFromForm()
        {
            Student sv = new Student();

            sv.MSSV = mtxtMSSV.Text.Trim();
            sv.HoLot = txtHoLot.Text.Trim();
            sv.Ten = txtTen.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.Lop = cboLop.Text.Trim();
            sv.CMND = mtxtCMND.Text.Trim();
            sv.SDT = mtxtSDT.Text.Trim();
            sv.DiaChi = txtDiaChi.Text.Trim();

            sv.GioiTinh = rdNam.Checked ? "Nam" : "Nữ";

            List<string> dsMon = new List<string>();

            foreach (object item in clbMonHoc.CheckedItems)
            {
                dsMon.Add(item.ToString());
            }

            sv.MonHoc = string.Join(",", dsMon);
            return sv;
        }

        //2. Kiểm tra dữ liệu nhập vào
        private bool KiemTraDuLieu()
        {
            if (!mtxtMSSV.MaskFull)
            {
                MessageBox.Show("Vui lòng nhập đủ 7 chữ số MSSV!");
                mtxtMSSV.Focus();
                return false;
            }

            if (txtHoLot.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên lót!");
                txtHoLot.Focus();
                return false;
            }

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!");
                txtTen.Focus();
                return false;
            }

            if (cboLop.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                cboLop.Focus();
                return false;
            }

            if (!mtxtCMND.MaskFull)
            {
                MessageBox.Show("Vui lòng nhập đủ 9 chữ số CMND!");
                mtxtCMND.Focus();
                return false;
            }

            if (!mtxtSDT.MaskFull)
            {
                MessageBox.Show("Vui lòng nhập đủ 10 chữ số điện thoại!");
                mtxtSDT.Focus();
                return false;
            }

            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ liên lạc!");
                txtDiaChi.Focus();
                return false;
            }

            if (!rdNam.Checked && !rdNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return false;
            }

            if (clbMonHoc.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một môn học!");
                return false;
            }

            return true;
        }
        private void mtxtMSSV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (dangHienThiSinhVien)
                return;

            string mssv = mtxtMSSV.Text.Replace(" ", "");

            if (mssv.Length >= 2)
            {
                int aa;

                if (int.TryParse(mssv.Substring(0, 2), out aa))
                {
                    int khoa = aa + 24;

                    cboLop.Text = "CTK" + khoa;
                }
            }
        }
        private void ChonLopTheoKhoa(string khoa)
        {
            for (int i = 0; i < cboLop.Items.Count; i++)
            {
                if (cboLop.Items[i].ToString().Contains(khoa))
                {
                    cboLop.SelectedIndex = i;
                    break;
                }
            }
        }
        //3. Tạo 1 dòng listviewitem từ 1 sinh viên
        private ListViewItem TaoItem(Student sv)
        {
            ListViewItem item = new ListViewItem(sv.MSSV);

            item.SubItems.Add(sv.HoLot);
            item.SubItems.Add(sv.Ten);
            item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.CMND);
            item.SubItems.Add(sv.SDT);
            item.SubItems.Add(sv.DiaChi);

            item.Tag = sv;

            return item;
        }

        //4. Hiển thị danh sách sinh viên
        private void HienThiDanhSach()
        {
            HienThiDanhSach(ql.DanhSach);
        }

        private void HienThiDanhSach(List<Student> danhSach)
        {
            lvSinhVien.Items.Clear();

            foreach (Student sv in danhSach)
            {
                lvSinhVien.Items.Add(TaoItem(sv));
            }
        }

        //5. Hiểm thị sv lên form
        private void HienThiThongTin(Student sv)
        {
            dangHienThiSinhVien = true;

            mssvCu = sv.MSSV;

            mtxtMSSV.Text = sv.MSSV;
            txtHoLot.Text = sv.HoLot;
            txtTen.Text = sv.Ten;
            dtpNgaySinh.Value = sv.NgaySinh;
            cboLop.Text = sv.Lop;
            mtxtCMND.Text = sv.CMND;
            mtxtSDT.Text = sv.SDT;
            txtDiaChi.Text = sv.DiaChi;

            rdNam.Checked = sv.GioiTinh == "Nam";
            rdNu.Checked = sv.GioiTinh == "Nữ";

            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }

            string[] dsMon = sv.MonHoc.Split(',');

            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                foreach (string mon in dsMon)
                {
                    if (clbMonHoc.Items[i].ToString().Trim() == mon.Trim())
                    {
                        clbMonHoc.SetItemChecked(i, true);
                        break;
                    }
                }
            }

            dangHienThiSinhVien = false;
        }

        //6. Load form
        private void frmSinhVien_Load(object sender, EventArgs e)
        {

            ql.DocFile();
            HienThiDanhSach();
        }

        //7. Chọn sinh viên
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
                return;

            Student sv = (Student)lvSinhVien.SelectedItems[0].Tag;

            HienThiThongTin(sv);
            //không cho sửa mssv, cmnd
            //mtxtMSSV.ReadOnly = true;
            mtxtCMND.ReadOnly = true;
        }

        //8. Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            Student sv = GetStudentFromForm();

            if (ql.Them(sv))
            {
                MessageBox.Show("Thêm sinh viên thành công!");
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("MSSV đã tồn tại!");
            }
        }

        //9. Tìm kiếm sinh viên
        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem(ql);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhSach(frm.KetQua);
            }
            else
            {
                HienThiDanhSach();
            }
        }

        //10. Xóa sinh viên
        private void XoaSinhVienDaChon()
        {
            if (lvSinhVien.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn sinh viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa các sinh viên đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            List<string> dsMSSV = new List<string>();

            foreach (ListViewItem item in lvSinhVien.CheckedItems)
            {
                dsMSSV.Add(item.Text);
            }

            ql.XoaNhieu(dsMSSV);

            HienThiDanhSach();

            MessageBox.Show("Xóa sinh viên thành công!");
        }

        private bool KiemTraMSSV(string mssv)
        {
            // MSSV phải đủ 7 số
            if (mssv.Length != 7 || !mssv.All(char.IsDigit))
            {
                MessageBox.Show("MSSV phải gồm đúng 7 chữ số!");
                return false;
            }

            // Định dạng AA10CCC
            if (mssv.Substring(2, 2) != "10")
            {
                MessageBox.Show("MSSV phải đúng định dạng AA10CCC!");
                return false;
            }

            return true;
        }
        //11. Cập nhật sinh viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (mssvCu == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật!");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            string mssvMoi = mtxtMSSV.Text.Trim();

            // Kiểm tra định dạng AA10CCC
            if (!KiemTraMSSV(mssvMoi))
                return;

            // Kiểm tra MSSV mới có trùng sinh viên khác không
            foreach (Student sv in ql.DanhSach)
            {
                if (sv.MSSV == mssvMoi && sv.MSSV != mssvCu)
                {
                    MessageBox.Show(
                        "MSSV " + mssvMoi + " đã tồn tại!",
                        "Trùng MSSV",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    mtxtMSSV.Focus();
                    return;
                }
            }

            Student svMoi = GetStudentFromForm();

            if (ql.CapNhat(mssvCu, svMoi))
            {
                MessageBox.Show("Cập nhật sinh viên thành công!");

                HienThiDanhSach();

                mssvCu = svMoi.MSSV;
            }
        }

        //12. Thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Bạn có chắc chắn muốn thoát chương trình không?",
       "Xác nhận thoát",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //13. Tạo MSSV theo lớp
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangHienThiSinhVien)
                return;

            string lop = cboLop.Text;

            if (lop.Contains("K48"))
                mtxtMSSV.Text = "2410";
            else if (lop.Contains("K47"))
                mtxtMSSV.Text = "2310";
            else if (lop.Contains("K46"))
                mtxtMSSV.Text = "2210";
            else if (lop.Contains("K45"))
                mtxtMSSV.Text = "2110";
        }

        //14. Thêm môn học
        private void mnuThemMon_Click(object sender, EventArgs e)
        {
            Form formThemMon = new Form();

            formThemMon.Text = "Thêm môn học";
            formThemMon.Width = 350;
            formThemMon.Height = 150;
            formThemMon.StartPosition = FormStartPosition.CenterParent;

            Label lblTenMon = new Label();
            lblTenMon.Text = "Nhập tên môn học:";
            lblTenMon.Left = 10;
            lblTenMon.Top = 15;
            lblTenMon.AutoSize = true;

            TextBox txtTenMon = new TextBox();
            txtTenMon.Left = 10;
            txtTenMon.Top = 40;
            txtTenMon.Width = 300;

            Button btnThemMon = new Button();
            btnThemMon.Text = "Thêm";
            btnThemMon.Left = 220;
            btnThemMon.Top = 70;
            btnThemMon.Width = 90;
            btnThemMon.DialogResult = DialogResult.OK;

            formThemMon.Controls.Add(lblTenMon);
            formThemMon.Controls.Add(txtTenMon);
            formThemMon.Controls.Add(btnThemMon);

            formThemMon.AcceptButton = btnThemMon;

            if (formThemMon.ShowDialog() == DialogResult.OK)
            {
                string tenMon = txtTenMon.Text.Trim();

                if (tenMon == "")
                {
                    MessageBox.Show("Vui lòng nhập tên môn học!");
                    formThemMon.Dispose();
                    return;
                }

                foreach (object mon in clbMonHoc.Items)
                {
                    if (mon.ToString().Equals(
                        tenMon,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Môn học này đã tồn tại!");
                        formThemMon.Dispose();
                        return;
                    }
                }

                clbMonHoc.Items.Add(tenMon);

                MessageBox.Show("Thêm môn học thành công!");
            }

            formThemMon.Dispose();
        }

        //15. Xóa môn học
        private void mnuXoaMon_Click(object sender, EventArgs e)
        {
            if (clbMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!");
                return;
            }

            string tenMon = clbMonHoc.SelectedItem.ToString();

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa môn " + tenMon + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                clbMonHoc.Items.RemoveAt(clbMonHoc.SelectedIndex);
                MessageBox.Show("Xóa môn học thành công!");
            }
        }

        //16. Xóa sinh viên
        private void mnuXoaSinhVien_Click(object sender, EventArgs e)
        {
           XoaSinhVienDaChon();
        }
    }
}
