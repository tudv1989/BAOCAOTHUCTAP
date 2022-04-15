# Quản trị người dùng Linux

1. Quản trị tài khoản người dùng

Có hai loại tài khoản:

- Tài khoản quản trị root: có quyền quản trị cao nhất trong hệ thống, được phép làm mọi việc mà 
không bị kiểm soát

- Các tài khoản thông thường được tạo ra cho các mục đích:

  - Cung cấp tài khoản truy nhập cho người sử dụng hệ thống

  - Cung cấp tài khoản dùng bởi các dịch vụ hệ thống như http, samba, mysql,…

Chú ý: tránh làm việc dưới tài khoản của root cho các công việc thông thường hàng ngày

Với Linux, mỗi user có một định danh duy nhất, gọi là UID (User ID).

- 0 – 99: user có quyền quản trị

- >99: user khác. >= 500: không phải user hệ thống

-  UID có khả năng sử dụng lại

Mỗi user thuộc ít nhất một group. Mỗi group cũng có một định danh duy nhất là GID 

Mỗi users cần có những thông tin: tên user, UID, tên group, GID, home directory… 

Windows quản lý thông tin bằng LDAP, Kerberos. Linux quản lý thông tin bằng file text. 

Có thể chỉnh sửa thông tin của users bằng công cụ, hoặc sửa trực tiếp bằng text file.

Quản lý người dùng hệ thống bằng lệnh

- useradd: tạo user mới

- usermod: chỉnh sửa thông tin user.

- userdel -r: xóa user khỏi hệ thống

- passwd: đổi mật khẩu, chính sách thay đổi mật khẩu

- groupadd: tạo group mới

- groupdel: xóa group khỏi hệ thống

- groupmod: chỉnh sửa thông tin group.