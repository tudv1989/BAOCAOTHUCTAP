# Tìm hiểu Database
## I. Database
## 1. Database là gì?
- Database hay cơ sở dữ liệu là một tập hợp các dữ liệu có tổ chức, chúng được lưu trữ, truy cập và quản lý bởi hệ thống máy tính.
- DBMS( Database Managerment System) hay hệ quản trị cơ sở dữ liệu là phần mềm tương tác với người dùng để tạo lập, lưu trữ, quản lý database.

## 2. Phân loại cơ sở dữ liệu theo mục đích

- **Cơ sở dữ liệu dạng file**: dữ liệu được lưu trữ dưới dạng các file có thể là text, *.dbf.
- **Cơ sở dữ liệu quan hệ**: dữ liệu được lưu trữ trong các bảng dữ liệu gọi là các thực thể, giữa các thực thể này có mối liên hệ với nhau gọi là các quan hệ, mỗi quan hệ có các thuộc tính, trong đó có một thuộc tính là khóa chính lưu giá trị duy nhất không bị trùng lặp. Các hệ quản trị hỗ trợ cơ sở dữ liệu quan hệ như: MS SQL server, Oracle, MySQL...
- **Cơ sở dữ liệu hướng đối tượng**: dữ liệu cũng được lưu trữ trong các bảng dữ liệu nhưng các bảng có bổ sung thêm các tính năng hướng đối tượng như lưu trữ thêm các hành vi, nhằm thể hiện hành vi của đối tượng. Mỗi bảng xem như một lớp dữ liệu, một dòng dữ liệu trong bảng là một đối tượng. Các hệ quản trị có hỗ trợ cơ sở dữ liệu hướng đối tượng như: MS SQL server, Oracle, Postgres
- **Cơ sở dữ liệu bán cấu trúc**: dữ liệu được lưu dưới dạng XML, với định dạng này thông tin mô tả về đối tượng thể hiện trong các tag. Đây là cơ sở dữ liệu có nhiều ưu điểm do lưu trữ được hầu hết các loại dữ liệu khác nhau nên cơ sở dữ liệu bán cấu trúc là hướng mới trong nghiên cứu và ứng dụng.

## II. Một số cơ sở dữ liệu
## 1. MySQL
MySQL là một trong những cơ sở dữ liệu có khả năng mở rộng phổ biến nhất hiện nay. Tập hợp  nhiều tính năng, là một sản phẩm mã nguồn mở mạnh mẽ trên các website và các ứng dụng online. Việc bắt đầu với MySQL là cực kì dễ dàng và các nhà phát triển dễ dàng tiếp cận với một lượng lớn các thông tin về cơ sở dữ liệu trên internet.

 - Ưu điểm của MySQL

	-   **Dễ dàng sử dụng:**  MySQL có thể dễ dàng cài đặt. Với các công cụ bên thứ 3 làm cho nó càng dễ đơn giản hơn để có thể sử dụng.
	-   **Giàu tính năng:**  MySQL hỗ trợ rất nhiều chức năng SQL được mong chờ từ một hệ quản trị cơ sở dữ liệu quan hệ-cả trực tiếp lẫn gián tiếp.
	-   **Bảo mật:**  Có rất nhiều tính năng bảo mật, một số ở cấp cao đều được xây dựng trong MySQL.
	-   **Khả năng mở rộng và mạnh mẽ:**  MySQL có thể xử lý rất nhiều dữ liệu và hơn thế nữa nó có thể được mở rộng nếu cần thiết.
	-   **Nhanh:**  Việc đưa ra một số tiêu chuẩn cho phép MySQL để làm việc rất hiệu quả và tiết kiệm chi phí, do đó nó làm tăng tốc độ thực thi.

- Nhược điểm của MySQL
	-   **Dễ dàng sử dụng:**  MySQL có thể dễ dàng cài đặt. Với các công cụ bên thứ 3 làm cho nó càng dễ đơn giản hơn để có thể sử dụng.
	-  **Giàu tính năng:**  MySQL hỗ trợ rất nhiều chức năng SQL được mong chờ từ một hệ quản trị cơ sở dữ liệu quan hệ-cả trực tiếp lẫn gián tiếp.
	-   **Bảo mật:**  Có rất nhiều tính năng bảo mật, một số ở cấp cao đều 	được xây dựng trong MySQL.
	-   **Khả năng mở rộng và mạnh mẽ:**  MySQL có thể xử lý rất nhiều dữ liệu và hơn thế nữa nó có thể được mở rộng nếu cần thiết.
	-   **Nhanh:**  Việc đưa ra một số tiêu chuẩn cho phép MySQL để làm việc rất hiệu quả và tiết kiệm chi phí, do đó nó làm tăng tốc độ thực thi.

## 2. MariaDB

MariaDB là một nhánh của MySQL( một trong những CSDL phổ biến trên thế giới ), là máy chủ cơ sở dữ liệu cung cấp các chức năng thay thế cho MySQL. MariaDB được xây dựng bởi một số tác giả sáng lập ra MySQL được sự hỗ trợ của đông đảo cộng đồng các nhà phát triển phần mềm mã nguồn mở. Ngoài việc kế thừa các chức năng cốt lõi của MySQL, MariaDB cung cấp thêm nhiều tính năng cải tiến về cơ chế lưu trữ, tối ưu máy chủ.
MariaDB phát hành phiên bản đầu tiên vào 11/2008 bởi Monty Widenius, người đồng sáng lập MySQL. Widenius sau khi nghỉ công tác cho MySQL ( sau khi Sun mua lại MySQL ) đã thành lập công ty Monty Program AB và phát triển MariaDB.
, MariaDB có các phiên bản cho các hệ điều hành khác nhau: Windows, Linux,.. với các gói cài đặt tar, zip, MSI, rpm cho cả 32bit và 64bit. Hiện tại phiên bản mới nhất của MariaDB là 10.6.7, Release date: 2022-02-14.


 
