# Giới thiệu về Github
Khi tham gia một dự án nào đấy thì việc phải làm việc với nhiều người là điều thường thấy. Kể cả làm việc một mìn thì việc quản lý source là vô cùng quan trọng

Github là một dịch vụ nổi tiếng cung cấp kho lưu trữ mã nguồn Git cho các dự án phần mềm. Github có đầy đủ những tính năng của Git như: 

- Là công cụ quản lý source tổ chức theo dạng dữ liệu phân tán.
- Giúp đồng bộ source của team lên 1 server.
- Hỗ trợ các thao tác kiểm tra source trong quá trình làm việc (diff, check modifications, show history, merge source).
**Respository**
- Repo: nơi chứa tất cả các mã nguồn cho một dự án
- Có 2 cấu trúc dữ liệu chính là Object và Index được lưu trữ ẩn trong git.
- Có 2 loại repo: 
	+ Local repo: được cài trên máy, động bộ hóa với remote bằng các lệnh
	+ Remote repo: cài trên server chuyên dụng, điền hình hiện nay là Github.

**Branch**

Là những phân nhánh ghi lại luồng thay đổi của lịch sử
- Có thể thực hiện nhiều branch cùng lúc trên một repo
- Khi tạo một repo, một branch mặc định là master được tạo ra.

- Có 3 loại branch : 

	+ Local Branch: Branch có thể quản lí trong local repo
	+ Remote Branch: Branch ở trong remote repo.
	+ Remote tracking branch: Branch để local repo theo dõi remote branch

***Một số thuật ngữ:***

- Working tree: Nơi người dùng edit, tạo file mới

- Index: Nơi bảo trì trạng thái sau khi edit trên working tree.

- Check out: triển khai branch ở repo lên working tree. Không chỉ branch mà tag, Specific commit cũng có thể check out.

- Commit: Cập nhật thông tin lên Local Repo.

- Tag: Tên được gắn vào để có thể dễ dàng tham chiếu commit

- Revision: Giá trị hash(hash value) được tạo ra mỗi lần commit, trên Git sử dụng hash value và thực hiện quản lí theo thế hệ.

- Head: Từ chỉ định commit mới nhất của branch đang check out hiện tại.

**Các luồng cơ bản khi sử dụng Git**

Clone project từ server về Local Repo

- Check-out 1 nhánh từ Local Repository về Working Tree
- Làm việc tại Working Tree
- Add : xác nhận sự thay đổi của các files (đưa đến vùng Staging Area)
- Commit: cập nhật sự thay đổi lên Local Repo
# 1.Cài đặt và tạo tài khoản Github
**Tải GitHub**

Truy cập vào đường dẫn https://desktop.github.com/ để tải GitHub về và cài đặt.

![1](https://user-images.githubusercontent.com/97416839/148877142-b1cccef9-3616-48fe-9ace-34196af1b6f2.png)

Thực hiện các cài đặt tương ứng sau đó Sign into GiHub.com và thực hiện đăng nhập hoặc đăng ký tài khoản

**Đăng ký tài khoản trên Github** 

Truy cập vào trang chủ https://github.com/ 
sau đó lựa chọn chức năng Sign in (nếu đã có tài khoản thì bạn có thể đăng nhập)

![Screenshot 2022-01-10 113147](https://user-images.githubusercontent.com/97416839/148719170-5d8f727e-8ae8-4780-8541-94510be37587.png)

Nếu bạn chưa có tài khoản bạn có thể lựa chọn vào create an account để tạo tài khoản.tại đó bạn điền các thông tin để đăng ký tài khoản bao gồm gmail, username, password như yêu cầu. Sau đó hoàn thành quá trình đăng ký tài khoản và bạn có thể Login 
# 2. Hướng dẫn tạo Respository và đưa về Local Respository
**Tạo Respository**

![Screenshot 2022-01-10 125157](https://user-images.githubusercontent.com/97416839/148723355-3443e324-99aa-400c-94b6-e50b8d943c23.png)

![Screenshot_2](https://user-images.githubusercontent.com/97416839/148918095-f950117c-5d10-4f7b-9776-e0b8f307d367.png)

**Kết quả sau khi tạo Respository**

![repo baocaothuctap](https://user-images.githubusercontent.com/97416839/148918565-5ff4f6da-b693-41f4-978d-11b284b4a314.png)

* Để đưa Clone Respository từ Server về Local Respository (Github desktop).Trước tiên ta cần tạo 1 thư mục trên máy tính để lưu trữ Respository được đưa từ Server về. Ở đây mình tạo thư mục Trần Dương ngoài Desktop

![Screenshot_3](https://user-images.githubusercontent.com/97416839/148919654-fcd73173-e1b0-4164-8661-705e18b3b6fb.png)

 Tại Github desktop vào mục File -> Clone Respository và đưa Respository từ Server về thư mục Trần Dương.

![Screenshot_4](https://user-images.githubusercontent.com/97416839/148920079-5f88ae5f-0a9f-406d-bd31-4ae41929f271.png)

Vậy là ta đã thực hiện thành công kết nối từ Respository từ Server và Local Respository. Từ đây ta có thể thao tác dữ liệu tại Github Desktop và có thể đưa dữ liệu từ GitHub Desktop lên Server

# 3. Hướng dẫn sử dụng GitHub Desk để thao tác qua lại giữa Local Respository và Git Server.

**Đưa dữ liệu vào local Respository đã tạo**

Ta có thể dùng Visual Studio Code đăng nhập với tài khoản Git đã tạo và viết project để nạp dữ liệu cho Local Respository trong GitHub Desktop 

![Screenshot_5](https://user-images.githubusercontent.com/97416839/148921456-07022cb8-44c0-4b0b-9d2f-38898e82c00c.png)

**Github đã nhận được thay đổi của local Respository**

![Screenshot_6](https://user-images.githubusercontent.com/97416839/148921725-842f85ad-8fc7-4e5a-a18f-fe07286450ce.png)

Ta có thể ghi chú cho dữ liệu và nhấn Commit để thực thi

 Sau đó để up dữ liệu từ local Respository lên Server thì ta nhấn Publish branch

![Screenshot_7](https://user-images.githubusercontent.com/97416839/148922033-d19aae4b-f850-4b19-bb79-122c2b779440.png)

Như thế là ta đã có thể đẩy dữ liệu từ Local Respository lên Git Server. Từ đó người dùng có thể tương tác qua lại giữa Local Respository và Git Serer.
