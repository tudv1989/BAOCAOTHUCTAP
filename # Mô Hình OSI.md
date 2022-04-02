# Mô Hình OSI

 Là mô hình truyền dữ liệu,nó chia làm 7 tầng, mỗi tầng thực hiện 1 chức năng ,nhiêm vụ để đảm bảo 1 gói tin truyền đi tìm đến được đích.

![2ba4804d27da9dc85d415381958b2205](https://uphinh.vn/images/2022/04/02/2ba4804d27da9dc85d415381958b2205.png)
### Chức năng và nhiệm vụ từng tầng
- Tầng 1: Tầng vật lý (Physical Layer) 
Là các thiết bị nhìn thấy trong mạng: Dây mạng,ổ điện,trang thiết bị phần cứng...

- Tầng 2: Tầng liên kết dữ liệu (Data-Link Layer)
Tầng liên kết dữ liệu cung cấp các phương tiện có tính chức năng và quy trình để truyền dữ liệu giữa các thực thể mạng (truy cập đường truyền, đưa dữ liệu vào mạng).
Tầng này ta chỉ nên quan tâm đến các thiết bị như Switch,Hub,địa chỉ MAC của card mạng.

- Tầng 3: Tầng mạng (Network Layer)
Tầng mạng thực hiện chức năng định tuyến. Các thiết bị định tuyến (router) hoạt động tại tầng này ,1 gói tin khi đi ra khỏi router đi đường nào là do cấu hình giao thức định tuyến tại router này  (còn có thiết bị chuyển mạch (switch) tầng 3, còn gọi là chuyển mạch IP). tầng 3 chúng ta quan tâm đến địa chỉ IP.

- Tầng 4: Tầng giao vận (Transport Layer)
Tầng giao vận cung cấp dịch vụ chuyên dụng chuyển dữ liệu giữa các người dùng tại đầu cuối, nhờ đó các tầng trên không phải quan tâm đến việc cung cấp dịch vụ truyền dữ liệu đáng tin cậy và hiệu quả. Tầng giao vận kiểm soát độ tin cậy của một kết nối được cho trước. Tầng này ta quan đến 2 giao thức TCP hoặc UDP

- Tầng 5: Tầng phiên (Session layer)
Tầng phiên kiểm soát các (phiên) hội thoại giữa các máy tính. Tầng này thiết lập, quản lý và kết thúc các kết nối giữa trình ứng dụng địa phương và trình ứng dụng ở xa.

- Tầng 6: Tầng trình diễn (Presentation layer)
Tầng trình diễn hoạt động như tầng dữ liệu trên mạng. Tầng này trên máy tính truyền dữ liệu làm nhiệm vụ dịch dữ liệu được gửi từ tầng ứng dụng sang địng dạng chung. Và tại máy tính nhận, lại chuyển từ định dạng chung sang định dạng của tầng ứng dụng.

- Tầng 7: Tầng ứng dụng (Application layer)
Tầng ứng dụng là tầng gần với người sử dụng nhất. Nó cung cấp phương tiện cho người dùng truy nhập các thông tin và dữ liệu trên mạng thông qua chương trình ứng dụng. Tầng này là giao diện chính để người dùng tương tác với chương trình ứng dụng, và qua đó với mạng. Một số ví dụ về các ứng dụng trong tầng này bao gồm HTTP, Telnet, FTP (giao thức truyền tập tin) và các giao thức truyền thư điện tử như SMTP, IMAP, POP3.

# Mô Hình TCP/IP

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

# Tìm hiểu các giao thức :
- HTTP là giao thức truyền tải siêu văn bản (web) không mã hóa dữ liệu khi truyền, sử dụng port TCP=80
- DNS là là viết tắt của cụm từ Domain Name System, mang ý nghĩa đầy đủ là hệ thống phân giải tên miền
  Khi chúng ta truy cập vào 1 dịch vụ của 1 host nào đó chúng ta rất khó nhớ địa chỉ IP của nó, nên DNS được sinh ra





