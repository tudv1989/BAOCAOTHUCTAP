# Giới thiệu
- Port :
  - Server dùng SMTP port 25 với kiểu ko mã hóa data và mã hóa dùng port 465
  - Kiểu đọc mail POP3 ko mã hóa là 110 và 995 = mã hóa
  - Imap dùng 143 làm port đọc mail ko mã hóa và 993 làm port mã hóa
 - Port remote admin =1000 dùng để quản trị từ xa

<img src="imgservices/1202.png">

- Có tính năng quét antivirus của hãng 

- Ứng dụng chống spam port 783

<img src="imgservices/1203.png">

- Port webmail client = 3000 ko SSL
và 443 nêu có SSL

# Giao diện quản trị

<img src="imgservices/1205.png">

<img src="imgservices/1206.png">

# Lập user và group

- Mở giao diện trên window và click vào biểu tượng user

<img src="imgservices/1065.png">

- Tên user và mật khẩu

<img src="imgservices/1066.png">

- Sử dụng 2 phương pháp đọc mail là POP và IMAP

<img src="imgservices/1067.png">

- Một vài chính sách cho tài khoản như : 
  - Truy cập webmail
  - Truy cập từ xa vào sv
  - Kích hoạt chát nhanh
  - Đổi mật khẩu
  ...

<img src="imgservices/1068.png">

- Trả lời tự động

<img src="imgservices/1069.png">


- Chuyển tiếp mail 

<img src="imgservices/1070.png">

- Chính sách như 
  - Một lần gửi tối đa 30 địa chỉ
  - Quota mail =100Mb
  - Một ngày chỉ gửi đc 50 thư

<img src="imgservices/1071.png">


- Lọc mail để phân loại

<img src="imgservices/1072.png">

- Tạo chữ ký

<img src="imgservices/1073.png">

- Kích hoạt là tài khoản admin

<img src="imgservices/1074.png">

- White list là danh mục những địa chỉ thư ko cần lọc trong danh bạ

 <img src="imgservices/1075.png">

- Một vài setting thêm 


 <img src="imgservices/1076.png">

# Tạo group :

<img src="imgservices/1200.png">

<img src="imgservices/1201.png">

# Xem log gửi thư:

Tại giao diện quản trị mail từ xa: ``mail.domain:1000``

- Dannh mục Log lưu trữ nhật ký của hệ thống và nhiều thao tác

<img src="imgservices/1332.png">


- Tin nhắn bị máy chủ gmail drop vì ko đủ độ tin cậy( Thiếu bản ghi DKim SPF,DMACRC)

<img src="imgservices/1331.png">


- 1 thư gửi thành công đến gmail

<img src="imgservices/1333.png">

