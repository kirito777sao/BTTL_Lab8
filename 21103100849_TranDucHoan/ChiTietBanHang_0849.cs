using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21103100849_TranDucHoan
{
    public partial class ChiTietBanHang_0849 : Form
    {
        KetNoiCSDL kncsdl = new KetNoiCSDL();
        public ChiTietBanHang_0849()
        {
            InitializeComponent();
        }

        private void btThem_0849_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Đơn Giá"); txtDonGia.Focus(); return; }
            if (txtSL_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Số Lượng"); txtSL_0849.Focus(); return; }
            if (txtMAKH_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Mã Khách Hàng"); txtMAKH_0849.Focus(); return; }
            if (txtMaMH_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Mã Mặt Hàng"); txtMaMH_0849.Focus(); return; }

            // Thêm vào tblBanHang
            int soHieuHD = kncsdl.ThemBanHang(int.Parse(txtMAKH_0849.Text), dtpNM_0849.Value);
            if (soHieuHD != -1)
            {
                // Thêm vào tblChiTietBanHang
                kncsdl.ThemChiTietBanHang(soHieuHD, int.Parse(txtMaMH_0849.Text), int.Parse(txtSL_0849.Text), int.Parse(txtDonGia.Text));
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại!", "Lỗi");
                return;
            }

            DuaDLVaoBang();
            ClearTexts();
            MessageBox.Show("Thêm Thành Công");
        }

        private void btSua_0849_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Đơn Giá"); txtDonGia.Focus(); return; }
            if (txtSL_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Số Lượng"); txtSL_0849.Focus(); return; }
            if (txtMAKH_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Mã Khách Hàng"); txtMAKH_0849.Focus(); return; }
            if (txtMaMH_0849.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Mã Mặt Hàng"); txtMaMH_0849.Focus(); return; }

            int soHieuHD = Convert.ToInt32(txtSLHD_0849.Text);
            int maMH = Convert.ToInt32(txtMaMH_0849.Text);
            int soLuong = Convert.ToInt32(txtSL_0849.Text);
            decimal donGia = Convert.ToDecimal(txtDonGia.Text);
            kncsdl.SuaChiTietBanHang(soHieuHD, maMH, soLuong, donGia);
            DuaDLVaoBang();
        }

        private void btXoa_0849_Click(object sender, EventArgs e)
        {
            if (txtSLHD_0849.Text.Trim() == "") { MessageBox.Show("Chưa chọn hóa đơn cần xóa"); return; }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int soHieuHD = Convert.ToInt32(txtSLHD_0849.Text);
                kncsdl.XoaBanHang(soHieuHD);
                DuaDLVaoBang();
            }
        }

        private void btThoat_0849_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void DuaDLVaoBang()
        {
            dgv2_0849.DataSource = kncsdl.getAllHD();
            ThanhTien();
            CapNhatSTT();
        }

        void ClearTexts()
        {
            txtMaMH_0849.Clear();
            txtDonGia.Clear();
            txtMAKH_0849.Clear();
            txtSLHD_0849.Clear();
            txtSL_0849.Clear();
        }

        private void ChiTietBanHang_0849_Load(object sender, EventArgs e)
        {
            DuaDLVaoBang();
        }

        private void dgv2_0849_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; //chỉ số của hàng ddang chọn 
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dgv2_0849.Rows[i];
                txtSLHD_0849.Text = r.Cells[2].Value.ToString();
                txtMaMH_0849.Text = r.Cells["tenMH"].Value.ToString();
                txtSL_0849.Text = r.Cells["donViTinh"].Value.ToString();
                txtDonGia.Text = r.Cells["Column1"].Value.ToString();
            }
        }

        // Hàm tính toán thành tiền
        private void ThanhTien()
        {
            // Kiểm tra xem có dữ liệu trong DataGridView không
            if (dgv2_0849.Rows.Count > 0)
            {
                // Duyệt qua từng dòng trong DataGridView
                foreach (DataGridViewRow row in dgv2_0849.Rows)
                {
                    // Lấy giá trị số lượng và đơn giá từ dòng hiện tại
                    int soLuong = Convert.ToInt32(row.Cells["donViTinh"].Value);
                    decimal donGia = Convert.ToDecimal(row.Cells["Column1"].Value);
                    // Tính toán thành tiền
                    decimal thanhTien = soLuong * donGia;
                    // Gán giá trị thành tiền vào cột "ThanhTien" của dòng hiện tại
                    row.Cells["Column2"].Value = thanhTien;
                }
            }
        }

        // Sự kiện thay đổi giá trị trong DataGridView
        private void dgv2_0849_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*// Kiểm tra xem ô được thay đổi có phải là "SoLuong" hoặc "DonGia" không
            if (e.ColumnIndex == dgv2_0849.Columns["SoLuong"].Index || e.ColumnIndex == dgv2_0849.Columns["DonGia"].Index)
            {
                // Tính toán thành tiền và cập nhật vào DataGridView
                ThanhTien();
            }*/
        }

        // Hàm cập nhật số thứ tự
        private void CapNhatSTT()
        {
            if (dgv2_0849.Rows.Count > 0)
            {
                for (int i = 0; i < dgv2_0849.Rows.Count; i++)
                {
                    dgv2_0849.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
        }
    }
}
