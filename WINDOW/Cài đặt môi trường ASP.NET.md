# Cài đặt môi trường ASP.net

Windows, IIS, SQL, ASP.NET) Stack


## 1 - IIS ASP.net
- Add roll and features

<img src="imgwindow/1320.png">

<img src="imgwindow/1323.png">

<img src="imgwindow/1324.png">


<img src="imgwindow/1325.png">


<img src="imgwindow/1358.png">

- Test thử 

<img src="imgwindow/1359.png">

## 2 - Cài đặt sql server

<img src="imgwindow/1311.png">

<img src="imgwindow/1312.png">

- Tạo mới 1 server độc lập

<img src="imgwindow/1314.png">

- Hệ thống sẽ kiểm tra và tải về các bản cập nhật

<img src="imgwindow/1316.png">

- Next

<img src="imgwindow/1317.png">

- Next

<img src="imgwindow/1318.png">

<img src="imgwindow/1319.png">

<img src="imgwindow/1326.png">


<img src="imgwindow/1327.png">

- Tùy chọn xác thực windows hoặc cả tính năng kết nối = user pass sql

<img src="imgwindow/1328.png">

- Quá trình cài đặt bắt đầu 

<img src="imgwindow/1350.png">

## 3- Cài đặt SQL management studio

- Chạy file

<img src="imgwindow/1352.png">

<img src="imgwindow/1353.png">


## 4 USER,Restore database, backup , attach database.

- Mở phần mềm MSSMS lên kết nối quản lý database sql với xác thực là tài khoản máy tính:

<img src="imgwindow/1354.png">

<img src="imgwindow/1355.png">

<img src="imgwindow/1356.png">

- Chúng ta có thể tạo ra các database và user mang quyền với database đó

<img src="imgwindow/1360.png">

<img src="imgwindow/1361.png">

- Tạo user database và gán quyền owner

<img src="imgwindow/1362.png">

- các tùy chọn bao gồm tên, mật khẩu user database, chính sách về mật khẩu của user, default database khi user connect sẽ vào thẳng database đó

<img src="imgwindow/1363.png">

- Tiếp theo là gán quyền sở hữu SITE1 cho tudv1

<img src="imgwindow/1364.png">

<img src="imgwindow/1365.png">

<img src="imgwindow/1366.png">

- Backup database SITE1

<img src="imgwindow/1368.png">

- Các tùy chọn như backup full, thời gian backup, và chỗ lưu file backup

<img src="imgwindow/1369.png">

- Giờ ta xóa DATABASE SITE1 rồi tiến hành restore lại database:

<img src="imgwindow/1370.png">

<img src="imgwindow/1370.png">

<img src="imgwindow/1371.png">

<img src="imgwindow/1372.png">

<img src="imgwindow/1373.png">

<img src="imgwindow/1374.png">


- Attach và detach

  - Khi ta có 1 database muốn chuyển sang máy khác ta    sẽ phải làm thao tác detach trước để lấy 2 file mang đi máy khác: test với database SITE1

  <img src="imgwindow/1375.png">


  <img src="imgwindow/1376.png">

  - Check vào ô Drop Connections (để ngắt toàn bộ kết nối đến   database này) -> Nhấn OK


  - 2 File cần thiết để attach là file mặc định nằm trong 

  C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA

 <img src="imgwindow/1377.png">


<img src="imgwindow/1378.png">

<img src="imgwindow/1379.png">

- Bấm ok là xong


- Ngoài backup file.bak ra còn backup file.sql 


<img src="imgwindow/1380.png">

<img src="imgwindow/1381.png">

<img src="imgwindow/1382.png">

<img src="imgwindow/1383.png">

<img src="imgwindow/1384.png">

<img src="imgwindow/1385.png">

- Khi restore tạo lại database mới tên giống database cũ. rồi tìm đến file script , bôi đen toàn bộ dòng lệnh và chon excute .

<img src="imgwindow/1386.png">


