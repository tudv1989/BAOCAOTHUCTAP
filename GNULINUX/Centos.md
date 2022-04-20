# Thực hành cài centos 7 trên vmw 


Mở phần mềm ảo hóa Phầnvmw workstation 16 pro 


<img src="imgcentos7/1.png">

- Click Create a New Vitual machine

- Typical là cài đặt tự động do app vmw tự đề xuất cho mình về các thông số...
- Custom - cài đặt tùy chọn theo ý muốn,tạo 1 máy ảo tùy chọn option, như là trình điều khiển SCSI,loại dữ liệu trên đĩa,tương thích với các sản phầm vmw cũ hơn.
<img src="imgcentos7/2.png">

- Phần cứng máy ảo tương thích cho phiên bản vmw 16         và cũng tương thích esx server ( vmw sphere), cột Limitation thế hiện phần cứng hỗ trợ tối đa của 1 máy ảo như 128 GB ram, 32 CPU,10 card mạng...

<img src="imgcentos7/3.png">



Tùy chọn cài hệ điều hành cuối cùng

<img src="imgcentos7/4.png">







Chọn loại hệ điều hành và phiên bản muốn cài, ở đây mình cài centos nên chọn Linux và chọn Centos7 64bit

<img src="imgcentos7/5.png">





Tiếp theo ta chọn đường dẫn lưu các file của hệ điều hành

<img src="imgcentos7/6.png">




Chọn số lượng cpu cài lên và số core trên cpu cài lên

vì thực tế có những bo mạch chủ chạy nhiều cpu, trên mỗi cpu lại có nhiều nhân.

<img src="imgcentos7/7.png">


Tùy chọn ram theo gợi ý: hỗ trợ max 128GB ram, phiên bản centos7 test 1 gb ram là đủ



<img src="imgcentos7/8.png">

Tùy chọn card mạng. 
  - Bridge là biến máy ảo như 1 máy thật với môi trường bên ngoài( giống như 1 máy vật lý thường)
  - NAT : Giao tiếp với host và đi ra được internet
  - Host Only : chỉ giao tiếp với host và ko ra internet
  - Custom cũng có tùy chọn VM switch khi ta có nhiều máy ảo muốn connect với nhau và ko giao tiếp bên ngoài ta sẽ chọn các sw ảo.
  - Tùy chọn cuối cùng : ko kết nối với cái j hết

<img src="imgcentos7/9.png">


Next

<img src="imgcentos7/10.png">

Next

<img src="imgcentos7/11.png">

Chọn loại đĩa mà bạn muốn tạo chọn theo khuyến nghị:

- Chọn tạo 1 đĩa ảo mới,
  Đĩa ảo bao gồm một hoặc nhiều tệp trên hệ thống tệp máy chủ. Đĩa ảo xuất hiện như 1 đĩa cứng trên hdh host.Bạn có thể sao chép hoặc di chuyển các đĩa ảo trên cùng một máy chủ hoặc giữa các máy chủ.
- Chọn đĩa ảo hiện có( đã đc cấu hình trước)
- Sử dụng đĩa vật lý



<img src="imgcentos7/12.png">

Chọn dung lượng đĩa ảo, trong đó
  - Tùy chọn 1 là fix cứng dung lượng lấy từ host (allocate...), nếu ko tích thì đĩa ảo sẽ lấy dần dung lượng trong số 20GB ấy
  - Tùy chọn 2 là để đĩa ảo đó là 1 file .
  - Tùy chọn 3 là chia đĩa ảo thành nhiều file để tiện copy, di chuyển sang máy pc khác


<img src="imgcentos7/13.png">

Next

<img src="imgcentos7/14.png">

Finish


<img src="imgcentos7/15.png">

Bấm tùy chọn tìm file iso của ubuntu
và finish

<img src="imgcentos7/16.png">


<img src="imgcentos7/17.png">



Sau khi hoàn tất các chọn lựa ta power on máy ảo

<img src="imgcentos7/18.png">

Giao diện khởi động

<img src="imgcentos7/19.png">

Chọn ngôn ngữ hệ thống và bàn phím loại US

Ta chọn múi giờ , thời gian
<img src="imgcentos7/20.png">


<img src="imgcentos7/21.png">

Tùy vào mục đích sử dụng, ở đây mình cài bản không có giao diện


<img src="imgcentos7/22.png">



<img src="imgcentos7/23.png">


Đến tùy chọn phân vùng ổ cứng tự động hoặc thủ công, mình chọn thủ công

<img src="imgcentos7/24.png">


<img src="imgcentos7/25.png">


Chọn phân vùng tiêu chuẩn

<img src="imgcentos7/26.png">


<img src="imgcentos7/27.png">

Định dạng ổ đĩa dạng xfs, 
- Phần vùng boot chứa các file boot loader để khởi động

- Phân vùng swap là phân vùng Ram ảo, lấy ổ cứng làm ram ảo tránh trường hợp bị treo máy khi ram bị đầy.hiệu suất của nó rất thấp ,chỉ mục đích dự phòng

- Phân vùng / là toàn bộ phần dữ liệu theo cây thư mục /

<img src="imgcentos7/28.png">

Accept

<img src="imgcentos7/29.png">

On /off card mạng , đổi tên máy hoặc chọn IP tĩnh

<img src="imgcentos7/30.png">
Begin

<img src="imgcentos7/31.png">

Đặt mật khẩu cho root và tạo 1 tài khoản user

<img src="imgcentos7/32.png">

Quá trình hoàn tất , login root và mật khẩu




<img src="imgcentos7/35.png">

Cài đặt ssh

chỉnh sửa ssh tại

/etc/ssh/sshd_config

<img src="imgcentos7/36.png">






Tùy chọn root login

<img src="imgcentos7/37.png">

Disabled selinux tại

/etc/sysconfig/selinux

<img src="imgcentos7/38.png">

Cho SSH khởi động cùng hệ thống mỗi khi reboot

<img src="imgcentos7/39.png">

Cấu hình IP tĩnh

/etc/sysconfig/network-scrip/ifcfg-enss33

<img src="imgcentos7/40.png">




<img src="imgcentos7/41.png">

CÀi bind

<img src="imgcentos7/42.png">


<img src="imgcentos7/43.png">


<img src="imgcentos7/45.png">
