


INSERT INTO Categories(Name, Description) VALUES
(N'Đồ uống', N'Nước ngọt, cà phê, trà, bia, rượu'),  
(N'Đồ ngọt', N'Bánh, kẹo'), 
(N'Sản phẩm từ sữa', N'Phô mai, sữa chua, sữa đặc'), 
(N'Ngũ cốc', N'Ngũ cốc, yến mạch, hạt'), 
(N'Thịt', N'Thịt heo, thịt gà,'), 
(N'Trái cây', N'Trái cây các loại: xoài, ổi, chuối'), 
(N'Đồ ăn nhanh', N'Mì gói, tokbokki, bánh bao'),
(N'Hàng tiêu dùng', N'Bàn chải, băng keo, các đồ dùng hàng ngày')

INSERT INTO Suppliers (Name, Email, Address, FAX)
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

INSERT INTO Suppliers (Name, Email, Address, FAX)
VALUES
('Oishi', 'oishi@gmail.com', '808 Oishi Road', '1234567881'),
('King Food', 'kfood@gmail.com', '909 KFood Street', '324342342'),
('King Tool', 'ktool@gmail.com', '111 KTool Avenue', '311111111')

INSERT INTO Products (Name, CategoryID, SellPrice, Description, Quantity, SupplierID)
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

INSERT INTO Products (Name, CategoryID, SellPrice, Description, Quantity, SupplierID)
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

INSERT INTO Products (Name, CategoryID, SellPrice, Description, Quantity, SupplierID)
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

INSERT INTO Products (Name, CategoryID, SellPrice, Description, Quantity, SupplierID)
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

--Customers

INSERT INTO Customers (Name, Email, Address, PhoneNumber, Gender, DateJoin)
VALUES
(N'Nguyễn Văn A', N'nguyenvana@example.com', N'123 Phố X, Hà Nội', N'091234567', 0, '2023-12-01'),
(N'Phạm Thị B', N'phamthib@example.com', N'456 Đường Y, HCM', N'0987654321', 1, '2023-12-03'),
(N'Lê Minh C', N'leminhc@example.com', N'789 Đường Z, Đà Nẵng', N'0922334455', 0, '2023-12-05'),
(N'Trần Thị D', N'tranthid@example.com', N'101 Đường M, Hà Nội', N'0933445566', 1, '2023-12-07'),
(N'Vũ Quang E', N'vuquange@example.com', N'202 Đường B, HCM', N'0944556677', 0, '2023-12-09'),
(N'Hoàng Lan F', N'hoanglanf@example.com', N'303 Đường C, Đà Nẵng', N'0955667788', 2, '2023-12-11'),
(N'Nguyễn Thị G', N'nguyenthig@example.com', N'404 Đường K, Hà Nội', N'0966778899', 1, '2023-12-13'),
(N'Phan Quang H', N'phanquangh@example.com', N'505 Đường L, HCM', N'0977889900', 0, '2023-12-15'),
(N'Bùi Lan I', N'builani@example.com', N'606 Đường N, Đà Nẵng', N'0988990011', 1, '2023-12-17'),
(N'Đặng Minh J', N'dangminhj@example.com', N'707 Đường O, Hà Nội', N'0999001122', 0, '2023-12-19'),
(N'Trần Đình K', N'trandinhk@example.com', N'808 Đường P, HCM', N'0810012233', 1, '2023-12-21'),
(N'Ngô Hữu L', N'ngohul@example.com', N'909 Đường Q, Đà Nẵng', N'0820123344', 2, '2023-12-23'),
(N'Phạm Lâm M', N'phamlamm@example.com', N'1010 Đường R, Hà Nội', N'0831234455', 0, '2023-12-25'),
(N'Võ Minh N', N'vominhn@example.com', N'1111 Đường S, HCM', N'0842344566', 1, '2023-12-27'),
(N'Nguyễn Thiên O', N'nguyenthieno@example.com', N'1212 Đường T, Đà Nẵng', N'0853455677', 0, '2023-12-29'),
(N'Hồ Thanh P', N'hothanhp@example.com', N'1313 Đường U, Hà Nội', N'0864566788', 1, '2023-12-31'),
(N'La Đức Q', N'laduq@example.com', N'1414 Đường V, HCM', N'0875677899', 0, '2024-01-02'),
(N'Nguyễn Vũ R', N'nguyenvur@example.com', N'1515 Đường W, Đà Nẵng', N'0886789900', 2, '2024-01-04'),
(N'Toàn Thị S', N'toanthis@example.com', N'1616 Đường X, Hà Nội', N'0897890011', 1, '2024-01-06'),
(N'Hải Đăng T', N'haidangt@example.com', N'1717 Đường Y, HCM', N'0909011122', 0, '2024-01-08'),
(N'Kim Tiến U', N'kimtienu@example.com', N'1818 Đường Z, Đà Nẵng', N'0910122233', 1, '2024-01-10'),
(N'Vũ Ngọc V', N'vungocv@example.com', N'1919 Đường A, Hà Nội', N'0921233344', 0, '2024-01-12'),
(N'Lâm Thiên W', N'lamthienw@example.com', N'2020 Đường B, HCM', N'0932344455', 2, '2024-01-14'),
(N'Bùi Hữu X', N'buihux@example.com', N'2121 Đường C, Đà Nẵng', N'0943455566', 1, '2024-01-16'),
(N'Nguyễn Thanh Y', N'nguyenthanhy@example.com', N'2222 Đường D, Hà Nội', N'0954566677', 0, '2024-01-18'),
(N'Đỗ Minh Z', N'dominhz@example.com', N'2323 Đường E, HCM', N'0965677788', 1, '2024-01-20'),
(N'Vũ Đức A1', N'vuduca1@example.com', N'2424 Đường F, Đà Nẵng', N'0976788899', 2, '2024-01-22'),
(N'Trần Quang B2', N'tranquangb2@example.com', N'2525 Đường G, Hà Nội', N'0987899900', 0, '2024-01-24'),
(N'Ngô Hòa C3', N'ngohoc3@example.com', N'2626 Đường H, HCM', N'0998900011', 1, '2024-01-26'),
(N'Hồ Hải D4', N'hohaid4@example.com', N'2727 Đường I, Đà Nẵng', N'0810122233', 2, '2024-01-28');

-- Guest - Customer đặc biệt
SET IDENTITY_INSERT Customers ON;

INSERT INTO Customers (CustomerId, Name, Email, Address, PhoneNumber, Gender, DateJoin)
VALUES (0, N'Guest', NULL, NULL, N'0000000000', 0, GETDATE());

SET IDENTITY_INSERT Customers OFF;

INSERT INTO Customers (Name, Email, Address, PhoneNumber, Gender, dateJoin)
VALUES ('Test User', NULL, NULL, '123456789', 1, GETDATE());
