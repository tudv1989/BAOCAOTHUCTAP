# Sử dụng phần mềm ảo hóa VMware workstation cài đặt window server 2016

Có 2 loại winserver mỗi phiên bản, loại Standar ít tính năng hơn loại Datacenter.

loại có giao diện(desktop) hoặc ko có giao diện(nano)

Em sẽ trình bày cách cài đặt ws2016 bản doanh nghiệp



- Mở chương trình vmw chọn create a new virtual machine , chúng ta cứ click theo dấu khoanh tròn đỏ lần lượt

<img src="img/15.png">

<img src="img/16.png">

<img src="img/17.png">

Bước này chúng ta chọn chèn file iso sau

<img src="img/18.png">

<img src="img/19.png">

<img src="img/20.png">
- Ở đây phần location là mục lưu máy winserver 2016 ở đâu. ta chọn 1 nơi nào đó để lưu. click browse

ở đây mình chọn ổ E và tạo folder WINSV2016 để lưu máy ảo

<img src="img/21.png">

<img src="img/22.png">

- Cứ next

<img src="img/23.png">

- Bước này chọn số nhân CPU , mình chọn 2

<img src="img/24.png">

- Chọn ram mình chọn ram 2GB

<img src="img/25.png">

- Bước tiếp chọn card mạng có 4 tùy chọn
  - Bridged : máy ảo như máy host giao tiếp mạng LAN và internet

  - NAT     : giao tiếp với host và internet ,ko giao tiếp với LAN ngoài

  - Host only : Giống như switch các máy ảo giao tiếp với nhau,ko có internet, ko kết nối với host

  - Custom  : Tùy chọn nhiều sw ảo...khi cài nhiều máy ảo sẽ dùng.
  

<img src="img/26.png">  

- Để mặc định và next

<img src="img/27.png">

- Tùy dạng ổ cứng của host nên ta cứ chọn mặc định và next thôi, 

<img src="img/28.png">

<img src="img/29.png">

- Bước này ta chọn tùy chọn như vậy để chọn ổ cứng theo kiểu dùng đến đâu trong 60GB thì lấy tới đó và là 1 file duy nhất vì định dạng dữ liệu ổ cứng của host là NTFS

<img src="img/30.png">

<img src="img/31.png">

<img src="img/32.png">

<img src="img/33.png">

<img src="img/34.png">

- Ở đây em ko có iso win2016 nên em chọn phiên bản winsv 2019. winsv 2016 và winsv 2019 gần như ko có sự khác biệt.

<img src="img/35.png">

<img src="img/36.png">

<img src="img/37.png">

<img src="img/38.png">

<img src="img/39.png">

<img src="img/40.png">

<img src="img/41.png">

<img src="img/42.png">

<img src="img/43.png">

<img src="img/44.png">

- Nhập mk administrator 

<img src="img/45.png">

- Kết thúc 

<img src="img/46.png">


