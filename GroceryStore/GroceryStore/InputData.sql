INSERT INTO USERS(UserName, Password, Email, PhoneNumber, Gender, Role) VALUES
(N'admin', N'$2a$11$UH0jJk3tm5bVzRHV5CvWF.8ysGqEYGfih3ubrXq9e2TzGcYSUz61C', N'admin@gmail.com', '0123564737', 0, 1),
(N'nhanvien', N'$2a$11$UH0jJk3tm5bVzRHV5CvWF.8ysGqEYGfih3ubrXq9e2TzGcYSUz61C', N'nhanvien@gmail.com', '0516546453', 0, 0)


INSERT INTO CATEGORY(CName, Description) VALUES
(N'Đồ uống', N'Nước ngọt, cà phê, trà, bia, rượu'),  
(N'Đồ ngọt', N'Bánh, kẹo'), 
(N'Sản phẩm từ sữa', N'Phô mai, sữa chua, sữa đặc'), 
(N'Ngũ cốc', N'Ngũ cốc, yến mạch, hạt'), 
(N'Thịt', N'Thịt heo, thịt gà,'), 
(N'Trái cây', N'Trái cây các loại: xoài, ổi, chuối'), 
(N'Đồ ăn nhanh', N'Mì gói, tokbokki, bánh bao'),
(N'Hàng tiêu dùng', N'Bàn chải, băng keo, các đồ dùng hàng ngày')

INSERT INTO SUPPLIER(SupplierName, Email, Address, Contact)
VALUES
('Coca-Cola', 'coca-cola@email.com', '123 Coca-Cola Street', '123456789'),
('Pepsi', 'pepsi@email.com', '456 Pepsi Avenue', '987654321'),
('Heineken', 'heineken@email.com', '789 Heineken Road', '192837465'),
('Tiger Beer', 'tigerbeer@email.com', '101 Tiger Lane', '564738291'),
('Budweiser', 'budweiser@email.com', '202 Budweiser Blvd', '847362910'),
('Sapporo', 'sapporo@email.com', '303 Sapporo Street', '283746192'),
('Corona', 'corona@email.com', '404 Corona Road', '736291847'),
('Vinamilk', 'vinamilk@email.com', '505 Vinamilk Ave', '184736295'),
('Dutch Lady', 'dutchlady@email.com', '606 Dutch Lady Street', '927364182'),
('TH True Milk', 'thtruemilk@email.com', '707 TH True Milk Rd', '102938475');

INSERT INTO SUPPLIER(SupplierName, Email, Address, Contact)
VALUES
('Oishi', 'oishi@gmail.com', '808 Oishi Road', '1234567881'),
('King Food', 'kfood@gmail.com', '909 KFood Street', '324342342'),
('King Tool', 'ktool@gmail.com', '111 KTool Avenue', '311111111')

INSERT INTO SUPPLIER(SupplierName, Email, Address, Contact)
VALUES
('Other', 'other@gmail.com', 'Other Food', '1233211231')

INSERT INTO PRODUCT(ProductName, CategoryID, SellPrice, Description, Stock, SupplierID)
VALUES
('Pepsi Can 320ml', 1, 9360, '320ml can', 90, 2),
('Pepsi Bottle 330ml', 1, 8400, 'small 330ml bottle', 250, 2),
('Pepsi Bottle 1.5l', 1, 16080, 'large 1.5l bottle', 300, 2),
('7 Up Can 330ml', 1, 14160, '330ml can', 150, 2),
('Mirinda', 1, 13200, '330ml can', 200, 2),
('Sprite', 1, 12240, '330ml can', 200, 1),
('Fanta', 1, 12240, '330ml can', 300, 1),
('Sting', 1, 12240, '330ml can', 230, 1),
('Dr Pepper', 1, 15120, '500ml bottle', 210, 1),
('Coca Cola', 1, 15120, '500ml bottle', 260, 1);

INSERT INTO PRODUCT(ProductName, CategoryID, SellPrice, Description, Stock, SupplierID)
VALUES
('Schweppes', 1, 13200, '500ml bottle', 300, 1),
('Zero Degree Green Tea', 1, 11280, '500ml bottle', 200, 12),
('TH Orange Juice', 1, 11280, '500ml bottle', 170, 10),
('TH Watermelon Juice', 1, 11280, '500ml bottle', 210, 10),
('TH Guava Juice', 1, 11280, '500ml bottle', 300, 10),
('TH Sugarcane Juice', 1, 11280, '500ml bottle', 280, 10),
('TH Centella Juice', 1, 11280, '500ml bottle', 230, 10),
('TH Mangosteen Juice', 1, 11280, '500ml bottle', 190, 10),
('TH Pineapple Juice', 1, 11280, '500ml bottle', 200, 10),
('TH Grapefruit Juice', 1, 11280, '500ml bottle', 250, 10);

INSERT INTO PRODUCT(ProductName, CategoryID, SellPrice, Description, Stock, SupplierID)
VALUES
('Saigon Beer', 1, 14160, 'box of 24 cans, 330ml can', 300, 4),
('Heineken Beer', 1, 23520, 'box of 24 cans, 330ml can', 350, 3),
('Tiger Beer', 1, 18720, 'box of 24 cans, 330ml can', 270, 4),
('Larue Beer', 1, 17040, 'box of 24 cans, 330ml can', 250, 4),
('Budweiser Beer', 1, 28320, 'box of 24 cans, 330ml can', 320, 5),
('Sapporo Beer', 1, 32880, 'box of 24 cans, 330ml can', 280, 6),
('Corona Beer', 1, 32880, 'box of 24 cans, 330ml can', 310, 7),
('Wine', 1, 329520, '500ml bottle', 400, 12),
('Grape Wine', 1, 282240, '500ml bottle', 360, 12),
('Sake', 1, 423600, '500ml bottle', 330, 12);

INSERT INTO PRODUCT(ProductName, CategoryID, SellPrice, Description, Stock, SupplierID)
VALUES
('Mr. Brown Coffee', 1, 11280, '500ml can', 200, 12),
('Highland Coffee Milk Can', 1, 15120, '500ml can', 190, 12),
('Highland Coffee Milk Box', 1, 12240, '500ml can', 180, 12),
('Highland Black Coffee Box', 1, 14160, '500ml can', 220, 12),
('Highland Black Coffee Can', 1, 17040, '500ml can', 250, 12),
('Winter Melon Tea', 1, 13200, '500ml can', 270, 12),
('Butter Cookies Cosan', 2, 11520, NULL, 123, 12),
('Oatmeal Cookies Kinh Do', 2, 14400, NULL, 75, 12),
('Sweet Bread Vinabread', 2, 19200, NULL, 245, 12),
('Donut', 2, 14400, NULL, 184, 12);
-- USERS

--Customers

INSERT INTO CUSTOMER (CustomerName, PhoneNumber, Gender)
VALUES
    (N'Nguyễn Văn A', '0912345678', 0),
    (N'Nguyễn Thị B', '0912345679', 1),
    (N'Trần Văn C', '0912345680', 0),
    (N'Lê Thị D', '0912345681', 1),
    (N'Phạm Văn E', '0912345682', 0),
    (N'Huỳnh Thị F', '0912345683', 1),
    (N'Vũ Văn G', '0912345684', 0),
    (N'Bùi Thị H', '0912345685', 1),
    (N'Hoàng Văn I', '0912345686', 0),
    (N'Doãn Thị K', '0912345687', 1),
    (N'Nguyễn Văn L', '0912345688', 0),
    (N'Nguyễn Thị M', '0912345689', 1),
    (N'Trần Văn N', '0912345690', 0),
    (N'Lê Thị O', '0912345691', 1),
    (N'Phạm Văn P', '0912345692', 0),
    (N'Huỳnh Thị Q', '0912345693', 1),
    (N'Vũ Văn R', '0912345694', 0),
    (N'Bùi Thị S', '0912345695', 1),
    (N'Hoàng Văn T', '0912345696', 0),
    (N'Doãn Thị U', '0912345697', 1),
    (N'Nguyễn Văn V', '0912345698', 0),
    (N'Nguyễn Thị X', '0912345699', 1),
    (N'Trần Văn Y', '0912345700', 0),
    (N'Lê Thị Z', '0912345701', 1),
    (N'Phạm Văn AA', '0912345702', 0),
    (N'Huỳnh Thị BB', '0912345703', 1),
    (N'Vũ Văn CC', '0912345704', 0),
    (N'Bùi Thị DD', '0912345705', 1),
    (N'Hoàng Văn EE', '0912345706', 0),
    (N'Doãn Thị FF', '0912345707', 1),
    (N'Nguyễn Văn GG', '0912345708', 0),
    (N'Nguyễn Thị HH', '0912345709', 1),
    (N'Trần Văn II', '0912345710', 0),
    (N'Lê Thị JJ', '0912345711', 1),
    (N'Phạm Văn KK', '0912345712', 0),
    (N'Huỳnh Thị LL', '0912345713', 1),
    (N'Vũ Văn MM', '0912345714', 0),
    (N'Bùi Thị NN', '0912345715', 1),
    (N'Hoàng Văn OO', '0912345716', 0),
    (N'Doãn Thị PP', '0912345717', 1);

-- Guest - Customer đặc biệt
SET IDENTITY_INSERT CUSTOMER ON;

INSERT INTO CUSTOMER (CustomerID, CustomerName, PhoneNumber, Gender)
VALUES (0, N'Guest', '0100000000', 0);

SET IDENTITY_INSERT CUSTOMER OFF;

INSERT INTO USERS (UserName, Password, FullName, Email, PhoneNumber, Gender, CreatedAt, Role)
VALUES
('user1', 'password1', 'User One', 'user1@example.com', '1234567890', 1, GETDATE(), 0),
('user2', 'password2', 'User Two', 'user2@example.com', '1234567891', 0, GETDATE(), 0),
('user3', 'password3', 'User Three', 'user3@example.com', '1234567892', 1, GETDATE(), 0),
('user4', 'password4', 'User Four', 'user4@example.com', '1234567893', 0, GETDATE(), 0),
('user5', 'password5', 'User Five', 'user5@example.com', '1234567894', 1, GETDATE(), 0),
('user6', 'password6', 'User Six', 'user6@example.com', '1234567895', 0, GETDATE(), 0),
('user7', 'password7', 'User Seven', 'user7@example.com', '1234567896', 1, GETDATE(), 0),
('user8', 'password8', 'User Eight', 'user8@example.com', '1234567897', 0, GETDATE(), 0),
('user9', 'password9', 'User Nine', 'user9@example.com', '1234567898', 1, GETDATE(), 0),
('user10', 'password10', 'User Ten', 'user10@example.com', '1234567899', 0, GETDATE(), 0);


update PRODUCT set ImageLink = N'imagename.png' where ProductName  = N'productname';
