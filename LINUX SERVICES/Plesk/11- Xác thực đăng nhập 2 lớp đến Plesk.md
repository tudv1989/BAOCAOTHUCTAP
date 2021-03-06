# Google Authenticator
- Bảo vệ quyền truy cập vào Plesk bằng xác thực đa yếu tố. Khi ta cài đặt và bật Google Authenticator, người dùng phải cung cấp cả mật khẩu và mã dùng một lần được tạo ra bởi ứng dụng Google Authenticator được cài đặt trên thiết bị của họ để được đăng nhập

- Bảo mật 2 bước là một trong những giải pháp hữu hiệu nhất giúp bảo vệ tài khoản trước nguy cơ bị tin tặc tấn công và đánh cắp quyền truy cập. Bởi vì cho dù tin tặc có sử dụng thủ thuật nào đó để đánh cắp được username và password thì vẫn không thể có được mã bí mật để đăng nhập bước 2. Mã số này được thay đổi tự động và thường xuyên (30 giây một lần) nên mức độ an toàn gần như tuyệt đối

Bước 1: Cài đặt ứng dụng (App) Google Authenticator trên điện thoại 
Android: https://play.google.com/store/apps/details?id=com.google.android.apps.authenticator2&hl=vi
IOS: https://itunes.apple.com/us/app/google-authenticator/id388497605?mt=8

<img src="imgservices/504.png">

- Ứng dụng này dùng để Scan mã QR và kích hoạt xác thực 2 bước cho tài khoản đăng nhập Hosting. Sau khi thiết lập, chúng ta cần lấy mã xác minh 6 chữ số khi truy cập tài khoản Hosting	bằng ứng dụng này

Bước 2: Truy cập trang quản trị Plesk.
- Cài Google Authenticator cho domain của mình trong Extension serarch từ khóa Gooogle Authenticator

<img src="imgservices/505.png">

Cài đặt hoàn tất ta chọn  `Google Authenticator`

<img src="imgservices/506.png">

- Cài đặt xác minh 2 bước:
	+ Đầu tiên, click vào `Enable Multi-factor Authentication` để mở chức năng xác thực 2 bước 
	+ Dùng ứng dụng `Google Authenticator` trên điện thoại (đã tải ở Bước 1) để Scan mã QR 
	+ Sau khi Scan bằng ứng dụng trên điện thoại, ta sẽ được cung cấp mã 6 chữ số, hãy nhập mã này vào mục: Verification code
	+ Pre-select “Remember Device” checkbox: Click vào nếu muốn ghi nhớ thiết bị đã truy cập thành công bằng xác thực 2 bước, không cần nhập mã cho các lần truy cập sau
	+ Remember device in days: Là thời gian để ghi nhớ đăng nhập cho thiết bị đó, tính bằng ngày



- Sau khi hoàn tất cài đặt, chọn `OK`. Tài khoản quản trị đã được bật chế độ Bảo mật - xác minh 2 bước.

<img src="imgservices/507.png">

>> Sau khi điền thông tin đăng nhập ta cần phải xác thực 1 lần nữa bằng cách nhập mã 6 chữ số tại `Verification Code`

>> Nếu không muốn sử dụng chức năng này thì ta có thể bỏ check tại `Enable Multi-factor Authentication`

<img src="imgservices/508.png">