# Cài đặt mail zimbra

- Tắt selinux

- Xóa posfix là dịch vụ mail được cài sẵn trên máy centos 

```
systemctl stop postfix
yum remove postfix -y

```

<img src="imgservices/216.png">

- Sau đó bạn cập nhật hệ thống  và reboot lại máy chủ để áp dụng
```
 yum update -y 
 reboot

```

- Đổi tên máy :


```
hostnamectl set-hostname mail.tudv.xyz
exec bash

```

- Sau khi set hostname xong  thêm dòng sau vào file hosts .

```
vi /etc/host

```

<img src="imgservices/217.png">

- Chạy lệnh sau để install Zimbra & ZCS dependencies

<img src="imgservices/218.png">

- Sau khi download về ta giải nén file ra

```

tar zxpvf zcs*.tgz

```
- Truy cập vào thư mục vừa giải nén và chạy lệnh ./install

```
cd zcs* && ./install.sh

```
<img src="imgservices/219.png">

- Chon y toàn bộ , đó là những gói dịch vụ kèm theo

<img src="imgservices/220.png">

<img src="imgservices/221.png">

<img src="imgservices/222.png">

<img src="imgservices/223.png">

<img src="imgservices/224.png">

<img src="imgservices/225.png">