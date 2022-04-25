# Tạo Database SERVER

- Cài mariadb

```

yum install mariadb-server -y

systemctl start mariadb.service

systemctl enable mariadb

service mariadb restart

```

- Thao tác tạo root và 1 vài tùy chọn mẫu

```
mysql_secure_installation

```


Khi được nhắc nhập mật khẩu, ta có thể nhấn Enter để trống hoặc cập nhật mật khẩu mới
Sau đó làm các bước để thiết lập mật khẩu. Cuối cùng, tập lệnh sẽ yêu cầu định cấu hình một số biện pháp bảo mật, bao gồm:

    - Xóa người dùng ẩn danh?

    - Không cho phép đăng nhập từ xa?

    - Xóa cơ sở dữ liệu thử nghiệm và truy cập vào nó?

    - Tải lại bảng đặc quyền ngay bây giờ










# Xóa 1 DATABASE

 Xóa MySQL/MariaDB user

- Bước 1 Đăng nhập vào MySQL shell bằng quyền root
```
mysql -u root -p 

```

- Bước 2: Liệt kê danh sách MySQL user

```
SELECT User,Host FROM mysql.user;

```

- Bước 3: List grants mysql user

```
mariadb> SHOW GRANTS FOR 'ten_user'@'localhost';

```

- Bước 4: Revoke all grants mysql user

```

mariadb> REVOKE ALL PRIVILEGES, GRANT OPTION FROM 'ten_user'@'localhost';

```

- Bước 5: Xóa user

```
mariadb> DROP USER 'ten_user'@'localhost';

```

- Bước 6: Xóa cơ sở dữ liệu,

```

mariadb> DROP DATABASE ten_db;

```
Lưu ý: Trước khi thực hiện các bạn nên sao lưu trước các cơ sở dữ liệu quan trọng, tránh sự cố đáng tiếc bị mất dữ liệu, hoặc đăng ký thuê một vps giá rẻ để test trước, chúc các bạn thành công,

# Các lệnh cơ bản

- Hiển thị toàn bộ users:

mysql> SELECT * FROM mysql.user;

- Xóa null user:

mysql> DELETE FROM mysql.user WHERE user = ' ';

- Xóa tất cả user mà không phải root:

mysql> DELETE FROM mysql.user WHERE NOT (host="localhost" AND user="root");

- Đổi tên tài khoản root :

mysql> UPDATE mysql.user SET user="toor" WHERE user="root";

- Gán full quyền cho một user mới:

mysql> GRANT ALL PRIVILEGES ON *.* TO 'username'@'localhost' IDENTIFIED BY 'mypass' WITH GRANT OPTION;

- Phân quyền chi tiết cho một user mới:

mysql> GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, DROP, INDEX, ALTER, CREATE TEMPORARY TABLES, LOCK TABLES ON mydatabase.* TO 'username'@'localhost' IDENTIFIED BY 'mypass';

- Gán full quyền cho một user mới trên một database nhất định:

mysql> GRANT ALL PRIVILEGES ON mydatabase.* TO 'username'@'localhost' IDENTIFIED BY 'mypass' WITH GRANT OPTION;

- Thay đổi mật khẩu user:

mysql> UPDATE mysql.user SET password=PASSWORD("newpass") WHERE User='username';

- Xóa user:

mysql> DELETE FROM mysql.user WHERE user="username";

- Reload user:

mysql> FLUSH PRIVILEGES;