# Cài đặt centos 7 trên VMware workstation

Em thực hiện cách cài 1 phiên bản linux là centos7 sử dụng VMware

Các thao tác được khoanh tròn đỏ

Open VMware

Chọn create new virtual machine

<img src="img/129.png">

<img src="img/130.png">
<img src="img/131.png">

<img src="img/132.png">
<img src="img/133.png">

Chọn linux và centos 7

<img src="img/134.png">

Chọn nhân cpu

<img src="img/135.png">

Chọn ram cho máy ảo 

<img src="img/136.png">
<img src="img/137.png">
<img src="img/138.png">
<img src="img/139.png">
<img src="img/140.png">
<img src="img/141.png">
<img src="img/142.png">
<img src="img/143.png">
<img src="img/144.png">
<img src="img/145.png">
<img src="img/146.png">
<img src="img/147.png">
<img src="img/148.png">
<img src="img/149.png">
<img src="img/150.png">
<img src="img/151.png">

Phân vùng ổ cứng theo tiêu chuẩn



<img src="img/152.png">

có công thức lấy ổ cứng làm ram ảo

nếu máy ảo có ram <2B thì ram ảo x2 ram thật
còn >=2G thì ram ảo làm ram thật
phân vùng swap này có tác dụng chống treo máy khi máy bị đầy bộ nhớ ram, nó hoạt động tốc độ rất chậm và hiệu suất rất thấp

<img src="img/153.png">

<img src="img/154.png">

<img src="img/155.png">

<img src="img/156.png">

<img src="img/157.png">

Tùy chọn card mạng, đổi tên host

<img src="img/158.png">

Set pass cho root và 1 user

<img src="img/159.png">

Bản minimal không paste được lệnh nên phải cài ssh thao tác cho nhanh.



