# WEBMIN

- Cài đặt:

- IP 172.16.2.223/20

`yum -y install perl-Net-SSLeay`

- Tải bản mới nhất trên trang chủ : http://download.webmin.com/download/yum/

`yum -y install http://download.webmin.com/download/yum/webmin-1.991-1.noarch.rpm`

- Thêm dải mạng cho truy cập

`vi /etc/webmin/miniserv.conf`

- thêm vào:

`allow=127.0.0.1 172.16.0.0/20`

<img src="imgservices/23.png">

- Khởi động lại

`/etc/rc.d/init.d/webmin restart`


`firewall-cmd --zone=publicweb --add-port=10000/tcp --permanent`

`firewall-cmd --reload`

Mở trình duyệt truy cập:

https://172.16.2.223:10000/

<img src="imgservices/24.png">
