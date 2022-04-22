# Datacenter FPT 17 duy tân HN ( tầng 2 và tầng 3)

- Khi phát sinh công việc ở DC :nâng cấp, di chuyển dữ liệu, khắc phục sự cố trên máy chủ , trên đường mạng...

- Chuẩn bị đủ đồ cần thiết như dây mạng. kéo.dây thít hoặc các đồ của máy chủ nếu đến sửa hoặc...

# Quy trình chung:

- Đăng ký với DC khai báo thông tin nhân viên đến ,cái này thông báo trước qua mail với nhóm quản lý hạ tầng FPT (cmtnd + tên+ngày giờ+ khu vực tủ rack của cty)

- Mang hàng đến DC, khai báo với phòng hạ tầng DC ( khu vực 1)để nhận giấy đăng ký đi lên .Giấy tờ này bao gồm thông tin hàng hóa mang đến (nếu có) ,không có hàng mang theo thì cũng vẫn phải có giấy đi lên.


- Xuất trình giấy tờ cho bảo vệ

- Đi lên khu vực 2 lễ tân  xuất trình giấy tờ đã đăng ký trước đó( nhóm tối đa 4 người) để nhận thẻ mở các cổng , thẻ này chỉ mở đc các cửa đi đến khu vực tủ rack của cty và lấy phụ kiện ( dây nguồn...)

# Hệ thống datacenter

- Thông thường các trung tâm dữ liệu đều được xây dựng theo 1 quy chuẩn quốc tế về các thông số: xây dựng, điện áp, điều hòa,phòng cháy chữa cháy...

Hầu hết các thông số này đều được monitor truyền ra phòng giám sát. Ví dụ nhiệt độ tại 1 điểm nào đó đều có hệ thống hiển thị 3D...

# Làm việc

- Đi đến chỗ cần đặt máy chủ hoặc xử lý sự cố :

  - Gắn máy chủ đúng tỉ lệ U nhằm tiết kiệm không gian tủ nhưng vẫn đảm bảo không ảnh hưởng đến các máy chủ kế cạnh : như khoảng cách mà các máy chủ khác vẫn có thể trượt, độ chặt bắt ốc của giá ...

- Sau khi gắn máy xong thì  đấu dây:

  - Dây nguồn : cắm 2 dây nguồn ( 1 sợi chỉ dự phòng )

  - Dây mạng IDRAC, IP này dùng để giám sát, nâng cấp, cập nhật ... cho máy chủ dạng có thể kết nối từ xa tùy từng loại liense.

  - Dây mạng IP public, công ty có thể đăng ký 1 dải IPv4/23 và dùng dần các địa chỉ /32, gắn với sw core chắc định tuyến  với firewall DC

  - Và 1 sợi là local dùng backup, sợi này đấu với sw và các máy chủ khác mình tự cắm thêm vào tủ để có thể làm nhiệm vụ backup đến 1 storage nào đó bên mình đặt ở đó).

  - Test máy chủ với internet, với remote storage chứa bản backup ?, có thể test dịch vụ hoặc báo về nhà để test các loại.

  - Hoàn tất các công việc : dán nhãn dây : Tên mã máy chủ ,chủ sở hữu, nhãn đánh dấu 2 đầu các dây mạng, dây nguồn... để công việc bảo trì hoặc xử lý sự cố lần sau đỡ mất thời gian.

# Kết thúc làm việc 

- Đem trả thẻ, lấy cmt căn cước, đồ gửi..và ra về




