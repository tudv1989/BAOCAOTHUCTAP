# Triển khai web wordpress window

Mô hình IIS,MySQL,PHP,Wordpress

- 2 website ``tudv1.tudv.xyz`` và ``tudv2.tudv.xyz``

- IP winserver: 103.124.93.26

- Chuẩn bị bản ghi

<img src="imgwindow/1020.png">

<img src="imgwindow/1021.png">

- Cấu hình windowserver chạy 2 web wordpress là tudv1.tudv.xyz và tudv2.tudv.xyz trên 1 máy chủ window có địa chỉ IP 103.124.93.26.

- Tạo IIS nhanh với các bổ trợ kèm theo

<img src="imgwindow/1022.png">
<img src="imgwindow/1023.png">
<img src="imgwindow/1024.png">
<img src="imgwindow/1025.png">
<img src="imgwindow/1026.png">
<img src="imgwindow/1027.png">
<img src="imgwindow/1028.png">
<img src="imgwindow/1029.png">
<img src="imgwindow/1030.png">
<img src="imgwindow/1031.png">
<img src="imgwindow/1032.png">
<img src="imgwindow/1033.png">

<img src="imgwindow/1034.png">


- Quá trình cài iis kết thúc

  - Ta tạo trong ổ C thư mục chứa mã nguồn web

  - Tạo 2 folder bên trong chứa web1 và web2

- <img src="imgwindow/1035.png">

<img src="imgwindow/1036.png">

- Trong mỗi folder ta tạo thử 2 bản index.html với nội dung để phân biệt 2 trang web

<img src="imgwindow/1037.png">

<img src="imgwindow/1038.png">

- Quay lại server manager click tool > iis

<img src="imgwindow/1039.png">

- Click tên máy của winserver

- Click Sites

- Và chuột phải tạo create site

- Tạo site đầu tiên là tudv1.tudv.xyz


<img src="imgwindow/1040.png">


<img src="imgwindow/1041.png">
<img src="imgwindow/1042.png">

- Click vào web 1 và chuột phải đẩy file index.html nãy mình tạo  lên hàng 1

<img src="imgwindow/1043.png">




- Làm tương tự cho web 2

- Test truy cập:

<img src="imgwindow/1048.png">

<img src="imgwindow/1049.png">

- Bước tiếp theo tìm kiếm webplatform tại trang chủ microsoft


<img src="imgwindow/1050.png">

<img src="imgwindow/1052.png">

- Tải về và setup

<img src="imgwindow/1053.png">

<img src="imgwindow/1054.png">

<img src="imgwindow/1055.png">

- Cài đặt xong ta tìm kiếm wordpress

<img src="imgwindow/1056.png">

<img src="imgwindow/1057.png">

- Add vào và cài đặt

<img src="imgwindow/1058.png">

- Máy chưa cài sql mình cứ điền mk của root mysql

<img src="imgwindow/1059.png">

- Máy sẽ cài php và mysql

<img src="imgwindow/1060.png">

<img src="imgwindow/1061.png">

# Quá trình cài đặt bị lỗi mất mấy tiếng nên em chuyển sang làm thủ công:



- Tải wordpress thủ công

- Tải PHP và phần mở rộng WinCache

- Cài đặt PHP và WinCache


  - Giải nén toàn bộ file cho PHP  .zip  bạn tải trước đó vào thư mục  cài đặt . C:\Program Files (x86)\PHP
  <img src="imgwindow/1066.png">

  - Giải nén WinCache( exe) vào thư mục ext của PHP: C:\Program Files (x86)\PHP\v7.4\ext :  Bạn sẽ có được file Php_wincache.dll

<img src="imgwindow/1067.png">

  - Mở Control Panel, click System and Security, click System, sau đó click Advanced system settings.

    Trong cửa sổ System Properties , chọn tab Advanced, sau đó click Environment Variables.

    Trong System variables, chọn Path, sau đó click Edit.

    Thêm đường dẫn vào thư mục PHP mà bạn đã cài đặt, như ở ví dụ là 

    C:\Program Files (x86)\PHP

    Sau đó Click OK.


<img src="imgwindow/1068.png">
 

  - Vào phần quản lý IIS chọn tên hosting trong bảng điều khiển nháy đúp (double-click) Handler Mappings.

  - Trong mục điều khiển Action, click Add Module Mapping.

  - Trong phần Request path, mục loại (type) thêm *.php.

  - Trên biểu mẫu (form) phần Module  chọn FastCgiModule

  - Trong hộp Executable chọn đường dẫn đầy đủ tới Php-cgi.exe. Ví dụ: C:\Program Files (x86)\PHP\Php-cgi.exe


  -  Trong phần Name nhập tên cho moudle mapping ví dụ: FastCGI

  - Click OK

  <img src="imgwindow/1075.png">

  - Chọn tên hosting trong mục điều khiển click đúp(double-click) Default Document.

  - Trong bảng điều khiển Action  chọn Add trong phần Name nhập index.php và click OK.

  <img src="imgwindow/1076.png">

- Tải Mysql về và đăng nhập root tạo ra 2 database cho 2 web wordpress:

  tạo 2 database wordpress1 và wordpress2 với 2 admin là tudv1 và tudv2

 
<img src="imgwindow/1072.png">


- Tải wordpress về cho vào `` C:\Webserver\tudv1.tudv.xyz``
và ``C:\Webserver\tudv2.tudv.xyz``
 
- Khai báo liên kết vào database 

<img src="imgwindow/1073.png">

- Làm tương tự cho web 2

# Kết quả: 

<img src="imgwindow/1074.png">

<img src="imgwindow/1077.png">

