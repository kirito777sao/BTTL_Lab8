CREATE DATABASE QuanLyBanHang_0849;
GO

USE QuanLyBanHang_0849;
GO

CREATE TABLE tblKhachHang (
    MaKH INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    DiaChi NVARCHAR(255) NOT NULL,
    DienThoai VARCHAR(15) NOT NULL
);
GO

INSERT INTO tblKhachHang (HoTen, GioiTinh, DiaChi, DienThoai) VALUES
    (N'Nguyễn Văn A', N'Nam', N'123 Nguyễn Trãi, Hà Nội', '0987654321'),
    (N'Trần Thị B', N'Nữ', N'456 Lê Lợi, TP. HCM', '0123456789'),
    (N'Vũ Minh C', N'Nam', N'789 Trần Hưng Đạo, Đà Nẵng', '0345678901'),
    (N'Lê Thị D', N'Nữ', N'101112 Lý Thường Kiệt, Hải Phòng', '0812345678'),
    (N'Phạm Anh E', N'Nam', N'131415 Lê Duẩn, Huế', '0912345678');
GO

CREATE TABLE tblMatHang (
    MaMH INT PRIMARY KEY IDENTITY(1,1),
    TenMatHang NVARCHAR(100) NOT NULL,
    DVT NVARCHAR(10) NOT NULL
);
GO

INSERT INTO tblMatHang (TenMatHang, DVT) VALUES
    (N'Áo sơ mi', N'Cái'),
    (N'Quần jean', N'Cái'),
    (N'Giày thể thao', N'Đôi'),
    (N'Túi xách', N'Cái'),
    (N'Nước hoa', N'Chai');
GO

CREATE TABLE tblBanHang (
    SoHieuHD INT PRIMARY KEY IDENTITY(1,1),
    MaKH INT NOT NULL,
    NgayMuaBan DATE NOT NULL,
    CONSTRAINT FK_tblBanHang_tblKhachHang FOREIGN KEY (MaKH) REFERENCES tblKhachHang(MaKH)
);
GO

INSERT INTO tblBanHang (MaKH, NgayMuaBan) VALUES
    (1, '2023-03-01'),
    (2, '2023-03-05'),
    (3, '2023-03-10'),
    (4, '2023-03-15'),
    (5, '2023-03-20');
GO

CREATE TABLE tblChiTietBanHang (
    SoHieuHD INT NOT NULL,
    MaMH INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_tblChiTietBanHang_tblBanHang FOREIGN KEY (SoHieuHD) REFERENCES tblBanHang(SoHieuHD),
    CONSTRAINT FK_tblChiTietBanHang_tblMatHang FOREIGN KEY (MaMH) REFERENCES tblMatHang(MaMH)
);
GO

INSERT INTO tblChiTietBanHang (SoHieuHD, MaMH, SoLuong, DonGia) VALUES
    (1, 1, 2, 150000),
    (1, 2, 1, 300000),
    (2, 3, 1, 500000),
    (3, 4, 2, 200000),
    (4, 5, 1, 1000000);
GO