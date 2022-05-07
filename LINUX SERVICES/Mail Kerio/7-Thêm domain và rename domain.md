# Các thao tác cơ bản trên mail server Kerio-connect
## 1. Add domain mới 

Bước 1: Vào `configuration` -> `domain` -> `add` -> `local domain`

<img src="imgservices/975.png">

- Domain: Tên domain cần add
- Description: Mô tả thông tin liên quan đến domain
- User count: Giới hạn số user cho domain



Bước 2: Tab Security
- Chọn theo hình dưới. 2 thông số dưới nhằm đảm bảo vấn đề liên quan đến password

<img src="imgservices/976.png">
Bước 3: Tab Message
- Giới hạn dung lượng gửi ra 50MB
- Ngoài ra có thể cấu hình thêm phần `Item clean-out` mục đích nhằm tối ưu hóa hệ thống dung lượng của user

<img src="imgservices/977.png">

Bước 4: Tab Custom Logo
- Chọn Logo và upload. Kích thước đề nghị 220x50

<img src="imgservices/978.png">

- Cài đặt thành công cho 1 domain

<img src="imgservices/979.png">

Bước 5: Set domain `tudv1.tudv.xyz` thành domain chính để dễ quản lí
- Chuột phải vào domain `tudv1.tudv.xyz` chọn `Set as Primary`

<img src="imgservices/980.png">



## 2. Add user cho domain tudv1.tudv.xyz vừa tạo 
Bước 1: Vào `Account` -> `User` -> chọn `Domain`


Bước 2: Add user vào domain trên 
- Chọn `add` -> điền thông tin user

Bước 3: Tab `General`
- Điền thông tin user



Bước 4: Tab `Contact` 
- Ở phần này có thể điền thông tin tùy ý hoặc bỏ qua 



Bước 5: Tab Groups
- Nếu có group riêng thì ta nên vào phần group để cấu hình. Ví dụ: Group Nhân sự, group IT, group Kế toán...

Bước 5: Tab Quota
- Giới hạn dung lượng và cho mỗi user thì ta nên vào đây để cấu hình


Bước 6: Kiểm tra lại user vừa tạo có hoạt động hay không

<img src="imgservices/981.png">


<img src="imgservices/982.png">

<img src="imgservices/983.png">


# Rename domain tudv.xyz sang tudv10.tudv.xyz

Trong Kerio Connect, bạn có thể đổi tên miền của mình trong giao diện quản trị. Khi một miền được đổi tên, tên ban đầu sẽ trở thành bí danh

- Đảm bảo các bản ghi dns domain mới

- Cần backup dữ liệu dự phòng

- Thao tác:

Vào mục domain click rename

<img src="imgservices/984.png">

- Dùng giao diện để restart dịch vụ;

<img src="imgservices/990.png">


