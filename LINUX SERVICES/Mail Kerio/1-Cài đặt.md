#  Cài đặt mail Kerio
- Đổi tên máy chủ và cập nhật file /etc/hosts
- Stop postfix

```
systemctl disable postfix
systemctl stop postfix

```

- Check timezone: và set timezone HCM
 ```
 timedatectl
 ```
 
 ```
 timedatectl set-timezone Asia/Ho_Chi_Minh

 ```


<img src="imgservices/901.png">

<img src="imgservices/902.png">


- Đăng ký và tải về bản phù hợp

https://www.gfi.com/products-and-solutions/email-and-messaging-solutions/kerio-connect/download/

- Dùng WinSCP upload lên máy chủ

<img src="imgservices/903.png">

- Cài đặt

<img src="imgservices/904.png">

```

rpm -ivh ker*

```

<img src="imgservices/905.png">


- Cài đặt sysstat và   cryptsetup

```
 yum install sysstat

 yum install  cryptsetup

 ```

<img src="imgservices/906.png">

<img src="imgservices/907.png">

- Tiến hành cài đặt tiếp KERIO

 <img src="imgservices/908.png">


 - Mở firewall

```
firewall-cmd --zone=public --add-port=4040/tcp --permanent

firewall-cmd --reload

```



 <img src="imgservices/909.png">

<img src="imgservices/910.png">



- Đăng nhập vào máy chủ port 4040 và tiến hành khai báo các thông số như tên miền, vùng cài đặt,đồng ý điều khoản, nhập liense free...

<img src="imgservices/911.png">
<img src="imgservices/912.png">
<img src="imgservices/913.png">
<img src="imgservices/914.png">
<img src="imgservices/915.png">
<img src="imgservices/916.png">
<img src="imgservices/917.png">

- Finish xong dịch vụ sẽ khởi động lại 

- Tiến hành đăng nhập lại

<img src="imgservices/918.png">
<img src="imgservices/919.png">

- Lệnh khởi động lại dịch vụ

```
service kerio-connect restart


```


- Test gửi thư:

<img src="imgservices/922.png">

