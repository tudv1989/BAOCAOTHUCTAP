# Build PHP + Nginx trên DirectAdmin
- Vào thư mục CustomBuild
```sh
cd /usr/local/directadmin/custombuild
```

- Kiểm tra các phiên bản PHP đang được build
```sh
vi /usr/local/directadmin/custombuild/options.conf
```

<img src="imgservices/420.png">

- Ta thấy có thể build đồng thời 4 phiên bản PHP trên DirectAdmin. Và đã có sẵn 1 phiên bản php 7.4 mode_php chạy apache
- Để build thêm 1 phiên bản PHP 8.0 mod php-fpm , web server nginx và phpMyAdmin ta cần chỉnh sửa thông tin trong file `/usr/local/directadmin/custombuild/option.conf` như sau


<img src="imgservices/421.png">


- Thoát và lưu

- Sau đó ta chạy các lệnh để build đúng như thiết lập
```sh
./build update
./build nginx
./build php n
./build rewrite_confs
```
- Khi buid nginx dễ gặp lỗi IPv6 bind 

<img src="imgservices/362.png">


Khi gặp phải lỗi nginx: [emerg] bind() to [::1]:80 failed (99: Cannot assign requested address) khi build từ apache sang nginx
Lỗi là do không bind được localhost Ipv6



- Khắc phục

```
vi /etc/sysctl.conf

thêm dòng : net.ipv6.ip_nonlocal_bind = 1

reboot

```

<img src="imgservices/363.png">

- Sau khi máy khởi động xong,chúng ta tiếp tục di chuyển trở lại custombuid : 

```
cd /usr/local/directadmin/custombuild

```

 và tiếp tục với câu lệnh buid nginx. vì trước đó đã chạy lệnh tải về php 7.2

```

./build nginx

```
<img src="imgservices/422.png">



```

./build php n

```
- Kiểm tra xem website hiện tại đang dùng phiên bản php nào




<img src="imgservices/424.png">

- Mặc định đang chạy 7.4


- Đổi sang 8.0

<img src="imgservices/425.png">







- Vào `File Manager` tạo một file `info.php` trong thư mục `public_html` để kiểm tra phiên bản

<img src="imgservices/427.png">

