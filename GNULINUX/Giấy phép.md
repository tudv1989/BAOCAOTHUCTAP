
# Giấy phép

- Read r=4
- Write w=2
- Execute x=1


Đối với thư mục:

  - Read: chỉ cho phép sử dụng lệnh ls để xem tên các đối tượng có trong thư mục, nếu muốn xem thêm các thông tin như: kích thước, quyền hạn truy cập, chủ sở hữu, ngày khởi tạo… bạn cần cấp thêm cho thư mục quyền execute.

  - Write: cho phép tạo và xóa các đối tượng trong thư mục.

  - Execute: chỉ cho phép chuyển vào thư mục sử dụng lệnh cd.

Đối với file:

  - Read: cho phép xem nội dung của file.

  - Write: cho phép chỉnh sửa nội dung, xóa file.

  - Excute: cho phép chạy file, quyền này thường được gán các file nhị phân thực thi (tương tự như file .exe trong Windows).

Các trường hợp

- X=1: cd đc vào trong thư mục, chạy đc các file thực thi.

- W = 2: Không làm được gì  = 0. 

- W+X = 3: đc cd,Tạo đối tượng trong Folder, ko được phép ghi nội dung vào file, chỉ được ghi đè, không liệt kê đc thông tin trong thư mục (ls), được quyền xóa cả file và thư mục.

- R = 4: Người dùng chỉ được liệt kê trong folder có những file hoặc thư mục  gì (Không liệt kê đc thông tin của file hoặc thư mục ), không đọc được nội dung trong file. ko cd đc vào trong thư mục.

- R+X =5: CD vào trong thư mục  và biết thông tin file,Người  dùng được phép đọc nội dung file (cat), không thay đổi đc nội dung file.

- W+R =6 : chỉ liệt kê tên file, còn lại ko làm đc gì.

- R+W+X =7: Ghi nội dung vào File
