using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _21103100849_TranDucHoan
{
    internal class KetNoiCSDL
    {
        SqlConnection conn;

        public void MoKetNoi()
        {
            string sql = @"Data Source=-pc;Initial Catalog=QuanLyBanHang_0849;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
        }

        public void DongKetNoi()
        {
            conn.Close();
        }

        // FORM MẶT HÀNG=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public DataTable getAllMH()
        {
            DataTable dt = new DataTable();
            MoKetNoi();
            string sql1 = "select * from tblMatHang";
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            DongKetNoi();
            return dt;
        }

        public bool TonTaiMH(string ma)
        {
            bool kt = false;
            MoKetNoi();
            string sql = "select * form tblMatHang where MaMH=@MaMH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaMH", ma);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows) { kt = true; };
            DongKetNoi();
            return kt;
        }

        public void ThemMH(string ma, string ten, string dvt)
        {
            MoKetNoi();
            string sql = "insert into tblMatHang values(@TenMatHang,@DVT)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("TenMatHang", ten);
            cmd.Parameters.AddWithValue("DVT", dvt);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }

        public void XoaMH(string ma)
        {
            MoKetNoi();
            string sql = "delete tblMatHang where MaMH = @MaMH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaMH", ma);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }

        // Sửa dữ liệu mặt hàng
        public void SuaMatHang(string ma, string ten, string dvt)
        {
            MoKetNoi();
            string sqlUpdate = "UPDATE tblMatHang SET TenMatHang = @TenMatHang, DVT = @DVT WHERE MaMH = @MaMH";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("@TenMatHang", ten);
            cmd.Parameters.AddWithValue("@DVT", dvt);
            cmd.Parameters.AddWithValue("@MaMH", ma);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }

        // Tìm kiếm thông tin mặt hàng
        public DataTable TimKiemMatHang(int mamh)
        {
            MoKetNoi();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblMatHang WHERE MaMH = @ma";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            cmd.Parameters.AddWithValue("@ma", mamh);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang = null;
            DongKetNoi();
            return bang;
        }

        // Kiểm tra mã mặt hàng
        public Boolean KiemTraMatHang(int maMH)
        {
            Boolean kiemTra = false;
            MoKetNoi();
            string sql = "SELECT * FROM tblMatHang WHERE MaMH = @mamh";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mamh", maMH);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            DongKetNoi();
            return kiemTra;
        }

        // FORM HÓA ĐƠN BÁN HÀNG=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        // Hàm thêm hóa đơn
        public int ThemBanHang(int maKH, DateTime ngayMuaBan)
        {
            try
            {
                conn.Open(); // Mở kết nối
                SqlCommand cmd = new SqlCommand("INSERT INTO tblBanHang (MaKH, NgayMuaBan) VALUES (@MaKH, @NgayMuaBan)", conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@NgayMuaBan", ngayMuaBan);
                cmd.ExecuteNonQuery();

                // Lấy SoHieuHD vừa được thêm
                SqlCommand cmdGetID = new SqlCommand("SELECT @@IDENTITY", conn);
                int soHieuHD = Convert.ToInt32(cmdGetID.ExecuteScalar());

                conn.Close(); // Đóng kết nối

                return soHieuHD; // Trả về SoHieuHD nếu thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Trả về -1 nếu có lỗi
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close(); // Đảm bảo đóng kết nối trong trường hợp có lỗi
                }
            }
        }

        // Hàm thêm chi tiết hóa đơn
        public void ThemChiTietBanHang(int soHieuHD, int maMH, int soLuong, int donGia)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblChiTietBanHang (SoHieuHD, MaMH, SoLuong, DonGia) VALUES (@SoHieuHD, @MaMH, @SoLuong, @DonGia)", conn);
                cmd.Parameters.AddWithValue("@SoHieuHD", soHieuHD);
                cmd.Parameters.AddWithValue("@MaMH", maMH);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@DonGia", donGia);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm sửa chi tiết hóa đơn
        public void SuaChiTietBanHang(int soHieuHD, int maMH, int soLuong, decimal donGia)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tblChiTietBanHang SET MaMH = @MaMH, SoLuong = @SoLuong, DonGia = @DonGia WHERE SoHieuHD = @SoHieuHD", conn);
                cmd.Parameters.AddWithValue("@SoHieuHD", soHieuHD);
                cmd.Parameters.AddWithValue("@MaMH", maMH);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@DonGia", donGia);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xóa hóa đơn
        public void XoaBanHang(int soHieuHD)
        {
            try
            {
                conn.Open();
                // 1. Xóa chi tiết hóa đơn
                SqlCommand cmdDeleteCT = new SqlCommand("DELETE FROM tblChiTietBanHang WHERE SoHieuHD = @SoHieuHD", conn);
                cmdDeleteCT.Parameters.AddWithValue("@SoHieuHD", soHieuHD);
                cmdDeleteCT.ExecuteNonQuery();

                // 2. Xóa hóa đơn
                SqlCommand cmdDeleteHD = new SqlCommand("DELETE FROM tblBanHang WHERE SoHieuHD = @SoHieuHD", conn);
                cmdDeleteHD.Parameters.AddWithValue("@SoHieuHD", soHieuHD);
                cmdDeleteHD.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable getAllHD()
        {
            DataTable dt = new DataTable();
            MoKetNoi();
            string sql1 = "select * from tblChiTietBanHang";
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            DongKetNoi();
            return dt;
        }

        // FORM KHÁCH HÀNG=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        public DataTable getAllKH()
        {
            DataTable dt = new DataTable();
            MoKetNoi();
            string sql1 = "select * from tblKhachHang";
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            DongKetNoi();
            return dt;
        }

        public bool TonTaiKH(string ma)
        {
            bool kt = false;
            MoKetNoi();
            string sql = "select * form tblKhachHang where MaKH=@makh";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("makh", ma);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows) { kt = true; };
            DongKetNoi();
            return kt;
        }

        public void ThemKH(string ma, string ten, string gt, string dc, string dt)
        {
            MoKetNoi();
            string sql = "insert into tblKhachHang values(@tenkh,@gt,@dc,@dt)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("tenkh", ten);
            cmd.Parameters.AddWithValue("gt", gt);
            cmd.Parameters.AddWithValue("dc", dc);
            cmd.Parameters.AddWithValue("dt", dt);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }

        public void XoaKH(string ma)
        {
            MoKetNoi();
            string sql = "delete tblKhachHang where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaKH", ma);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }

        // Sửa dữ liệu khách hàng
        public void SuaKhachHang(string hoTen, string gioiTinh, string diaChi, string dienThoai, string maKH)
        {
            MoKetNoi();
            string sqlUpdate = "UPDATE tblKhachHang SET Hoten =@ht, Gioitinh = @gt, Diachi = @dc, Dienthoai = @dt WHERE MaKH = @makh";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("@ht", hoTen);
            cmd.Parameters.AddWithValue("@gt", gioiTinh);
            cmd.Parameters.AddWithValue("@dc", diaChi);
            cmd.Parameters.AddWithValue("@dt", dienThoai);
            cmd.Parameters.AddWithValue("@makh", maKH);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }

        // Tìm kiếm thông tin khách hàng
        public DataTable TimKiemKhachHang(int makh)
        {
            MoKetNoi();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblKhachHang WHERE MaKH = @ma";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            cmd.Parameters.AddWithValue("@ma", makh);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang = null;
            DongKetNoi();
            return bang;
        }

        // FORM TÌM KIẾM KHÁCH HÀNG=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        public DataTable TimKiemKhachHangTheoMa(int makh)
        {
            MoKetNoi();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblKhachHang WHERE MaKH = @ma";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            cmd.Parameters.AddWithValue("@ma", makh);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang = null;
            DongKetNoi();
            return bang;
        }

        public DataTable TimKiemKhachHangTheoTen(string ten)
        {
            MoKetNoi();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblKhachHang WHERE Hoten LIKE N'%" + ten + "%'"; // Sử dụng LIKE để tìm kiếm một phần chuỗi
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang = null;
            DongKetNoi();
            return bang;
        }

        public DataTable TimKiemKhachHangTheoSDT(string sdt)
        {
            MoKetNoi();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblKhachHang WHERE Dienthoai LIKE N'%" + sdt + "%'"; // Sử dụng LIKE để tìm kiếm một phần chuỗi
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang = null;
            DongKetNoi();
            return bang;
        }

        // FORM TÌM KIẾM MẶT HÀNG=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        public DataTable TimKiemMatHangTheoMa(int mamh)
        {
            MoKetNoi();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblMatHang WHERE MaMH = @ma";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            cmd.Parameters.AddWithValue("@ma", mamh);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang = null;
            DongKetNoi();
            return bang;
        }

        public DataTable TimKiemMatHangTheoTen(string ten)
        {
            MoKetNoi();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblMatHang WHERE TenMatHang LIKE N'%" + ten + "%'"; // Sử dụng LIKE để tìm kiếm một phần chuỗi
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang = null;
            DongKetNoi();
            return bang;
        }

        // FORM TÌM KIẾM THÔNG TIN BÁN HÀNG>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        // Tìm kiếm theo mã khách hàng
        public DataTable TimKiemBanHangTheoMaKH(int maKH)
        {
            MoKetNoi();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT bh.SoHieuHD, bh.NgayMuaBan, mh.TenMatHang, cth.SoLuong " +
                "FROM tblBanHang bh " +
                "JOIN tblChiTietBanHang cth ON bh.SoHieuHD = cth.SoHieuHD " +
                "JOIN tblMatHang mh ON cth.MaMH = mh.MaMH " +
                "WHERE bh.MaKH = @ma";

            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            cmd.Parameters.AddWithValue("@ma", maKH);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang = null;
            DongKetNoi();
            return bang;
        }

        // Tìm kiếm theo tên khách hàng
        public DataTable TimKiemBanHangTheoTenKH(string tenKH)
        {
            MoKetNoi();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT bh.SoHieuHD, bh.NgayMuaBan, mh.TenMatHang, cth.SoLuong " +
                "FROM tblBanHang bh " +
                "JOIN tblChiTietBanHang cth ON bh.SoHieuHD = cth.SoHieuHD " +
                "JOIN tblMatHang mh ON cth.MaMH = mh.MaMH " +
                "JOIN tblKhachHang kh ON bh.MaKH = kh.MaKH " +
                "WHERE kh.Hoten LIKE N'%" + tenKH + "%'";

            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang = null;
            DongKetNoi();
            return bang;
        }
    }
}
