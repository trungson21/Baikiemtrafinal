CREATE DATABASE MobileShop;

USE MobileShop;

CREATE TABLE SanPham (
    id VARCHAR(255) PRIMARY KEY,
    tenSP VARCHAR(255),
    gia DECIMAL(10, 2),
    hangSX VARCHAR(255)
);


CREATE TABLE KhachHang (
    id VARCHAR(255) PRIMARY KEY,
    tenKH VARCHAR(255),
    diachi VARCHAR(255),
    sdt VARCHAR(15)
);

CREATE TABLE DonHang (
    id VARCHAR(255) PRIMARY KEY,
    khachhangid VARCHAR(255),
    sanphamid VARCHAR(255),
    soluong INT,
    ngaymua DATE,
    FOREIGN KEY (khachhangid) REFERENCES KhachHang(id),
    FOREIGN KEY (sanphamid) REFERENCES SanPham(id)
);

CREATE TABLE NguoiDung (
    id INT PRIMARY KEY,
    tendangnhap VARCHAR(50),
    matkhau VARCHAR(255)
);

INSERT INTO NguoiDung (id, tendangnhap, matkhau)
VALUES 
(1, 'admin', '123456'),
(2, 'user1', '654789'), 
(3, 'user2', '321654'); 

INSERT INTO KhachHang (id, tenKH, diachi, sdt)
VALUES 
(1, 'Nguyen Van A', 'Ha Noi', '0123456789'),
(2, 'Le Thi B', 'Da Nang', '0987654321'),
(3, 'Tran Van C', 'Ho Chi Minh', '0911223344'),
(4, 'Pham Thi D', 'Hai Phong', '0932112233'),
(5, 'Nguyen Hoang E', 'Can Tho', '0944556677');

INSERT INTO SanPham (id, tenSP, gia, hangSX)
VALUES 
(1, 'iPhone 15', 25000000, 'Apple'),
(2, 'Galaxy S23', 20000000, 'Samsung'),
(3, 'Xiaomi 13', 15000000, 'Xiaomi'),
(4, 'Oppo Find X6', 18000000, 'Oppo'),
(5, 'Sony Xperia 5', 22000000, 'Sony');

INSERT INTO DonHang (id, khachhangid, sanphamid, soluong, ngaymua)
VALUES 
(1, 1, 1, 2, '2024-11-20'), 
(2, 2, 2, 1, '2024-11-18'), 
(3, 1, 3, 3, '2024-11-15'), 
(4, 3, 2, 5, '2024-11-10'), 
(5, 2, 1, 1, '2024-11-09'); 
