Create database QL_SinhVien
use QL_SinhVien

Create table TTSinhVien
(
	id int primary key,
	name NVARCHAR(50),
) 

INSERT INTO TTSinhVien
VALUES('1',N'Nguyễn Kế Bảo')
INSERT INTO TTSinhVien
VALUES('2',N'Phạm Thanh Lâm')
INSERT INTO TTSinhVien
VALUES('3',N'Hồ Hoàng Khắc Dũng')
INSERT INTO TTSinhVien
VALUES('4',N'Bồ Quang Diệu')
INSERT INTO TTSinhVien
VALUES('5',N'Trương Hải Yến')

Select * from TTSinhVien	
