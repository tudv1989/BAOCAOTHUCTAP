# BÀI KIỂM TRA LÝ THUYẾT LẦN 1 ngày 2/4/2022
- 1.Mô hình OSI
- 2.Mô hình TCP/IP
- 3.Định nghĩa các giao thức cơ bản HTTP DNS FTP SSH DHCP ARP SNMP SMTP
- 4.Phân Biệt TCP/UDP
- 5.Định nghĩa và cấu trúc IPv4,IPv6
- 6.Định nghĩa về routing ,NAT,VLAN...



## 1.Mô Hình OSI

 Là mô hình truyền dữ liệu,nó chia làm 7 tầng, mỗi tầng thực hiện 1 chức năng ,nhiêm vụ để đảm bảo 1 gói tin truyền đi tìm đến được đích.

![2ba4804d27da9dc85d415381958b2205](https://uphinh.vn/images/2022/04/02/2ba4804d27da9dc85d415381958b2205.png)
### Chức năng và nhiệm vụ từng tầng
- Tầng 1: Tầng vật lý (Physical Layer) 
Em hiểu nó các thiết bị nhìn thấy trong mạng: Dây mạng,ổ điện,trang thiết bị phần cứng...

- Tầng 2: Tầng liên kết dữ liệu (Data-Link Layer)
Tầng liên kết dữ liệu cung cấp các phương tiện có tính chức năng và quy trình để truyền dữ liệu giữa các thực thể mạng (truy cập đường truyền, đưa dữ liệu vào mạng).
Tầng này theo em chỉ nên quan tâm đến các thiết bị như Switch,Hub,địa chỉ MAC của card mạng.

- Tầng 3: Tầng mạng (Network Layer)
Tầng mạng thực hiện chức năng định tuyến. Các thiết bị định tuyến (router) hoạt động tại tầng này ,1 gói tin khi đi ra khỏi router đi đường nào là do cấu hình giao thức định tuyến tại router này  (còn có thiết bị chuyển mạch (switch) tầng 3, còn gọi là chuyển mạch IP).Ở tầng 3 này em hiểu chỉ quan tâm đến địa chỉ IP là chính.

- Tầng 4: Tầng giao vận (Transport Layer)
Tầng giao vận cung cấp dịch vụ chuyên dụng chuyển dữ liệu giữa các người dùng tại đầu cuối, nhờ đó các tầng trên không phải quan tâm đến việc cung cấp dịch vụ truyền dữ liệu đáng tin cậy và hiệu quả. Tầng giao vận kiểm soát độ tin cậy của một kết nối được cho trước. Tầng này ta quan đến 2 giao thức TCP hoặc UDP

- Tầng 5: Tầng phiên (Session layer)
Tầng phiên kiểm soát các (phiên) hội thoại giữa các máy tính. Tầng này thiết lập, quản lý và kết thúc các kết nối giữa trình ứng dụng ở các địa điểm khác nhau

- Tầng 6: Tầng trình diễn (Presentation layer)
Theo em hiểu nó là tầng phiên dịch,
Tầng trình diễn hoạt động như tầng dữ liệu trên mạng. Tầng này trên máy tính truyền dữ liệu làm nhiệm vụ dịch dữ liệu được gửi từ tầng ứng dụng sang địng dạng chung. Và tại máy tính nhận, lại chuyển từ định dạng chung sang định dạng của tầng ứng dụng.Nói chung chung theo em hiểu nó là tầng phiên dịch ngôn ngữ tầng 7 sang ngôn ngữ máy( nhị phân)

- Tầng 7: Tầng ứng dụng (Application layer)
Tầng ứng dụng là tầng gần với người sử dụng nhất. Nó cung cấp phương tiện cho người dùng truy nhập các thông tin và dữ liệu trên mạng thông qua chương trình ứng dụng. Tầng này là giao diện chính để người dùng tương tác với máy tính thông qua chương trình ứng dụng. Một số ví dụ về các ứng dụng trong tầng này bao gồm HTTP, Telnet, FTP (giao thức truyền tập tin) và các giao thức truyền thư điện tử như SMTP, IMAP, POP3.

## 2.Mô Hình TCP/IP

Là mô hình truyền tin nhưng người ta đã rút gọn còn 4 tầng chồng lên nhau :
- Tầng 1: Tầng vật lý (Network Access Nó là sự kết hợp của tầng Data Link và Physical trong mô hình OSI 
Là tầng thấp nhất trong mô hình TCP/IP.Chịu trách nhiệm truyền dữ liệu giữa các thiết bị trong cùng một mạng. Tại đây, các gói dữ liệu được đóng vào khung (Frame) và được định tuyến đi đến đích được chỉ định ban đầu

- Tầng 2: Tầng mạng (Internet) Xử lý quá trình truyền gói tin trên mạng.
Định tuyến: tìm tuyến đường qua các nút trung gian để gửi dữ liệu từ nguồn tới đích.
Chuyển tiếp: chuyển tiếp gói tin từ cổng nguồn tới cổng đích theo tuyến đường.
Định địa chỉ : định danh cho các nút mạng.
Đóng gói dữ liệu: nhận dữ liệu từ giao thức ở trên, chèn thêm phần Header chứa thông tin của tầng mạng và tiếp tục được chuyển đến tầng tiếp theo.

- Tầng 3: Tầng giao vận (Transport) Chịu trách nhiệm duy trì liên lạc đầu cuối trên toàn mạng.
Tầng này có 2 giao thức chính là TCP ( Transmisson Control Protocol) và UDP ( User Datagram Protocol )
- Tầng 4: Tầng ứng dụng (Application). Nó cung cấp giao tiếp đến người dùng,cung cấp các ứng dụng cho phép người dùng trao đổi dữ liệu ứng dụng thông qua các dịch vụ mạng khác nhau (như duyệt web, chat, gửi email,...).Các giao thức tầng này : http, ftp,snmp,dns....

## 3.Tìm hiểu các giao thức :
- **HTTP**: là giao thức truyền tải siêu văn bản (web) không mã hóa dữ liệu khi truyền, sử dụng port mặc định TCP=80
- **DNS**: là là viết tắt của cụm từ Domain Name System, mang ý nghĩa đầy đủ là hệ thống phân giải tên miền
  Khi chúng ta truy cập vào 1 dịch vụ của 1 host nào đó chúng ta rất khó nhớ địa chỉ IP của nó, nên DNS được sinh ra.Port mặc định TCP và UDP đều =53
- **FTP**: là giao thức truyền dữ liệu (File tranfer protocol) không được mã hóa hoạt động theo kiểu Server-Client.Port mặc định TCP=21
- **SSH** là giao thức kết nối điều khiển thiết bị mạng được bảo mật ,dữ liệu được mã hóa rất an toàn.port TCP mặc định 22
- **DHCP** là giao thức cấp phát địa chỉ IP tự động,khi 1 host tham gia 1 mạng nếu chưa có địa chỉ IP thì host đó sẽ tiến hành 1 quá trình đi xin cấp địa chỉ do DHCP server cung cấp
- **ARP** (viết tắt của cụm từ Address Resolution Protocol) là giao thức mạng được dùng để tìm ra địa chỉ phần cứng (địa chỉ MAC) của thiết bị từ một địa chỉ IP nguồn
- **SNMP** là viết tắt của từ Simple Network Monitoring Protocol ,Là 1 giao thức dùng để giám sát các thiết bị quang trọng với các thông số cần thiết để giám sát.
- **SMTP** là giao thứ gửi thư đơn giản hoạt động ở port TCP=25 không mã hóa, Hoặc có mã hóa SSL/TLS là TCP 465
# 4.Phân Biệt TCP/UDP
- Định nghĩa: TCP là giao thức truyền tin tin cậy, còn UDP là không tin cậy
So sánh theo định nghĩa thì TCP là truyền tin theo dạng gói - ở giao thức này nếu gói tin bị rớt thì sẽ được gửi lại(đảm bảo tính trọn vẹn của bản tin), còn UDP là truyền tin theo thời gian thực(gói tin bị rớt sẽ không cần gửi lại, không thể khôi phục-dùng  streaming,truyền hình trực tiếp,gọi điện... ) chỉ có lưu lại hoặc xem lại.
# 5.IPv4
- Địa chỉ IPv4 là 1 dãy 32 bit nhị phân liên tiếp nhau,32 bít này chia làm 4 octet, mỗi octet là 8 bit, Mỗi octet này sẽ có vai trò tính chất là phần net hoặc host của địa chỉ.
- Có 5 lớp Ipv4 A,B,C,D,E.
Các tổ chức,doanh nghiệp có số lượng host tham gia mạng càng lớn thì địa chỉ càng gần các lớp A.Bit đầu tiên của địa chỉ lớp A luôn được chọn là 0. Dải địa chỉ mạng lớp A chạy từ 1.0.0.0 đến 126.0.0.0. Vì vậy lớp A sẽ có tổng cộng 126 mạng. Trong khi đó mạng Loopback là 127.0.0.0. Phần net của lớp A là 8 bit, host của lớp A có tất cả 24 bit
Lớp B của địa chỉ Ipv4 sử dụng 2 obtet đầu làm phần mạng và 2 obtet sau làm phần host. Hai bit đầu tiên của lớp B luôn là 1 và 0. Dải địa chỉ mạng lớp B chạy từ 128.0.0.0 đến 191.255.0.0. Như vậy lớp B sẽ có tổng cộng 214 mạng.Phần net và host của lớp B là 16 bit
Lớp C của địa chỉ Ipv4 dùng 3 octet đầu làm phần net và 1 octet sau làm phần host. Địa chỉ lớp C luôn có 3 bit đầu là 1 1 0. Dải mạng lớp C chạy từ 192.0.0.0 -> 223.255.255.0. Như vậy sẽ có 221 mạng trong lớp C.Phần net của lớp C sẽ là 24 bit, host chiếm 8 bit.