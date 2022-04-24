# Thực hành NGINX MYSQL PHP WORDPRESS

- Máy chủ chạy nginx 192.168.1.223

- Trước tiên tắt selinux

```
vi /etc/sysconfig/selinux  :  selilux=disabled

```

## 1 - Cài NGINX

- Update yum và mở rộng thư viện :

```yum update -y

yum install epel-release -y

```

- Cài đặt nginx

<img src="imgservices/48.png">

```
yum install nginx -y

```

- Khởi động dịch vụ

```
systemctl start nginx
systemctl enable nginx

```
- Cài đặt Mariadb

```
yum install mariadb-server mariadb -y

```

<img src="imgservices/50.png">

- Chạy maria

```
systemctl start mariadb

systemctl enable mariadb

service mariadb restart

```
- Khai báo maria

```
mysql_secure_installation

```

 Enter current password for root (enter for none): ``Enter``

...khai báo 1 vài thông số...

<img src="imgservices/51.png">

- Download và cài đặt remi 7 

```
mkdir /data && cd /data

wget http://rpms.remirepo.net/enterprise/remi-release-7.rpm

rpm -Uvh remi-release-7.rpm

```

<img src="imgservices/52.png">

- Cài yum utils

```
yum install yum-utils

```
<img src="imgservices/53.png">

- Tải php 5.4.16

```
yum install php php-mysql php-xml php-imap php-fpm php-cli php-curl php-xmlrpc php-common php-gd php-devel php-intl php-process php-zts -y

```

<img src="imgservices/54.png">

- Cài phpMyAdmin

```
yum -y install phpmyadmin

```
<img src="imgservices/55.png">

- Cài đặt nginx :File cấu hình tên default.conf( mặc định chưa có) của nginx sẽ là :``/etc/nginx/conf.d/default.conf``

ta sẽ tạo file default.conf và chỉnh thông số.

```
vi /etc/nginx/conf.d/default.conf

```
- Dán vào

```
server {
    listen   80;
    server_name  your_server_ip;

    # note that these lines are originally from the "location /" block
    root   /usr/share/nginx/html;
    index index.php index.html index.htm;

    location / {
        index index.php index.html index.htm; 
        try_files $uri $uri/ =404;
    }    

    location /fileweb {
         index index.php index.html index.htm;          
      } 

    error_page 404 /404.html;
    error_page 500 502 503 504 /50x.html;
    location = /50x.html {
        root /usr/share/nginx/html;
    }

    location ~ .php$ {
        try_files $uri =404;
        fastcgi_pass unix:/var/run/php-fpm/php-fpm.sock;
        fastcgi_index index.php;
        fastcgi_param SCRIPT_FILENAME $document_root$fastcgi_script_name;
        include fastcgi_params;
    }
}

```

- Khởi động lại nginx

``` 
systemctl restart nginx

```

- Tạo shortlink phpMyAdmin vào trong ``/usr/share/nginx/html``
```
 ln -s /usr/share/phpMyAdmin /usr/share/nginx/html

 ```


- Config  ``/etc/php-fpm.d/www.conf ``

```
vi /etc/php-fpm.d/www.conf 

```

```
user = apache to user = nginx
group = apache to group = nginx
listen.owner = nobody to listen.owner = nginx
listen.group = nobody to listen.group = nginx
listen = 127.0.0.1:9000 to listen = /var/run/php-fpm/php-fpm.sock

```
<img src="imgservices/63.png">

```
systemctl start php-fpm.service

systemctl enable php-fpm.service

systemctl restart nginx

```

- Kiểm tra firewalld

``` 
firewall-cmd --get-active-zones

systemctl status firewalld.service

firewall-cmd --zone=public --add-service=http  --permanent

firewall-cmd --reload
```
<img src="imgservices/62.png">


- Truy cập phpMyAdmin

- Nếu có cảnh báo

```
chown -R nginx:nginx /var/lib/php/session/

```

<img src="imgservices/64.png">

- Đăng nhập root maria tạo ban nãy

<img src="imgservices/65.png">

- Tạo database tên website 



<img src="imgservices/66.png">

- Tạo tài khoản admin databese:

<img src="imgservices/67.png">

- Check all ,tích hết là full quyền = root ,và roll xuống click Go

<img src="imgservices/69.png">

<img src="imgservices/70.png">

- Giờ đi kiếm wordpress

- Do cài php thấp nên em cũng tìm wpress thấp, và sẽ nâng cấp sau, em có sẵn 1 wp , giờ đẩy đến = stfp

<img src="imgservices/71.png">

<img src="imgservices/72.png">

<img src="imgservices/73.png">

- Cài thêm php7.1

```
yum-config-manager --enable remi-php71 [Default]

yum install php php-common php-fpm 

yum install php-mysql php-pecl-memcache php-pecl-memcached php-gd php-mbstring php-mcrypt php-xml php-pecl-apc php-cli php-pear php-pdo

```
<img src="imgservices/74.png">

- Sau khi cài xong ta cần phải khai báo  trong file ``wp-config.php`` để kết nối database


và 

```
chown -R nginx:nginx /var/lib/php/session/

```

<img src="imgservices/75.png">


<img src="imgservices/76.png">

- Khai báo vào database tên website ban nãy tạo

```
vi /usr/share/nginx/html/wp-config.php

```
<img src="imgservices/77.png">

<img src="imgservices/81.png">

- Truy cập lại 192.168.1.223 tạo web wordpress ,admin wpress và mail nhận đăng ký thông tin wpress

<img src="imgservices/78.png">

<img src="imgservices/79.png">

- Bước cuối cùng là viết bài

- Trang trí

- Chọn theme phù hợp

<img src="imgservices/80.png">