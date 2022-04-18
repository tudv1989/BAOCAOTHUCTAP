# Tìm hiểu KVM

**1. Khái niệm của KVM.**

KVM (Kernel-base Virtual Machine) là một module ảo hóa mã nguồn mở được tích hợp vào Linux. Nó biến Linux thành một hypervisor và cho phép máy chủ có thể chạy nhiều máy ảo độc lập. KVM được tích hợp vào linux kernel từ bản 2.6.20, nó yêu cầu bộ sử lý với chức năng ảo hóa phần cứng, như Intel VT hay AMD-V. KVM cung cấp ảo hóa phần cứng cho rất nhiều hệ điều hành khách bao gồm Window, Linux, BSD, Solaris, Haiku, ReactOS và hệ điều hành nghiên cứu AROS. Sử dụng kết hợp với QEMU, KVM có thể chạy Mac OS X.

KVM biến Linux thành hypervisor loại 1( Bare Metal). Tất cả các hypervisor đều cần một số thành phần ở mức độ hệ điều hành như trình quản lý bộ nhớ, trình lập lịch cho các tiến trình, input/output stack, driver cho các thiết bị, trình quản lý bảo mật, quản lý mạng,... để chạy máy ảo. Ảo hóa với KVM có tất cả nhưng thành phần đó vì KVM là một module của Linux Kernel.


**2. Cấu trúc của kvm.**

Trong kiến trúc kvm, máy ảo được coi như là những tiến trình được lập lịch bởi Linux Schedule. Thực tế thì mỗi cpu ảo xuất hiện như làm một tiến trình trong Linux, điều này cho phép kvm sử dụng được tất cả các tính năng của Linux kernel.

Cấu trúc tổng quan:

   <img src="img/128.png">

Trong môi trường Linux, mỗi process thường chạy ở hai chế độ là user-mode hoặc kernel-mode. KVM đưa ra một chế độ thứ 3, đó là guest-mode. Nó dựa trên CPU có khả năng ảo hóa với kiến trúc Intel VT hoặc AMD SVM, một process trong guest-mode bao gồm cả kernel-mode và user-mode.

**Trong cấu trúc tổng quan của ảo hóa sử dụng KVM bao gồm 3 thành phần chính:**

- KVM kernel module:

    Là một module được tích hợp vào Linux kernel.
      Cung cấp giao diện chung cho Intel VMX và AMD SVM (thành phần hỗ trợ ảo hóa phần cứng)
- quemu – kvm: là chương trình dòng lệnh để tạo các máy ảo, thường được vận chuyển dưới dạng các package “kvm” hoặc “qemu-kvm”.
    Có 3  chức năng chính:
    Thiết lập VM và các thiết bị ra vào (input/output) Thực thi mã khách thông qua KVM kernel module Mô phỏng các thiết bị ra vào (I/O) và di chuyển các guest từ host này sang host khác
- libvirt management stack:
    là một lớp quản lý, nó chịu trách nhiệm cung cấp API thực hiện các nhiệm vụ quản lý như cung cấp máy ảo, tạo, sửa đổi, giám sát, kiểm soát, di chuyển, v.v
    libvirtd là một daemon chạy ngầm để cung cấp dịch vụ quản lý ảo hóa cho các tool như là virsh hay virt-manager.
Cung cấp chế độ quản lí từ xa an toàn.
Chi tiết

**3. Tính năng của KVM**

**3.1 Security – Bảo mật**

 KVM sử dụng kết hợp giữa SELinux và sVirt (secure virtualization) để tăng cường bảo mật và cô lập máy ảo. SELinux thiết lập danh giới bảo mật xung quanh máy ảo. sVirt mở rộng khả năng của SELinux để cung cấp cơ chế Mandatory Access Control (MAC - Kiểm soát truy cập bắt buộc) để có thể kiểm soát truy cập giữa các process, hay các máy ảo.

**3.2 : Memory management – Quản lý bộ nhớ**

 KVM kế thừa những tính năng quản lý bộ nhớ của linux, bao gồm non-uniform memory access (NUMA) cho phép tận dụng hiệu quả bộ nhớ cho hệ thông đa xử lý và Kernel same-page merging cho phép các máy ảo chia sẻ vùng nhớ, các yêu cầu bộ nhớ giống nhau trên các máy ảo có thể được xử lý chung để tiết kiệm bộ nhớ để xử lý.

**3.3 : Storage – Lưu trữ**
  KVM có thể sử dụng được bất kỳ bộ nhớ lưu trữ nào mà Linux hỗ trợ, bao gồm các đĩa lữu trữ cục bộ hay các hệ thống lưu trữ qua mạng. Multipath I/O có thể được sử dụng để cải thiện việc lưu trữ và cung cấp dự phòng. KVM cũng hỗ trợ chia sẻ file systems nêm image của máy ảo có thể được chia sẻ với nhiều host khác. Disk image trong KVM hỗ trợ thin provisioning, cho phép phân bố lưu trữ theo yêu cầu chứ không phải là fix cứng dung lượng lưu trữ. Định dạng image tự nhiên của KVM là QCOW2 – hỗ trợ việc snapshot cho phép snapshot nhiều mức, nén và mã hóa dữ liệu.

**3.4 : Live migration**
 KVM hỗ trợ tính năng live migration để cho phép di chuyển các máy ảo đang chạy giữa các host vật lý mà không bị gián đoạn dịch vụ. Máy ảo vẫn được bật, kết nối mạng vẫn duy trì, ứng dụng vẫn chạy trong khi máy ảo được di chuyển. KVM cũng lưu lại trạng thái của máy ảo tại thời điểm đó để có thể lưu trữ và chạy lại sau này.

**3.5. Hardware support - Hỗ trợ phần cứng.**
 KVM có thể sử dụng nhiều nền tảng phần cứng mà được Linux hỗ trợ. Do các nhà phát triển phần cứng thường xuyên đóng góp cho sự phát triển của kernel, nên các tính năng phần cứng mới nhất thường được áp dụng một cách nhanh chóng cho Linux cũng như KVM.

**3.6 : Performance and scalability**

KVM kế thừa hiệu năng và khả năng mở rộng của Linux, hỗ trợ các máy ảo với 16 CPUs ảo, 256GB RAM và hệ thống máy chủ lên tới 256 cores và trên 1TB RAM.


### **4. Các chế độ mạng trong KVM**

Trong KVM có 3 chế độ card mạng là NAT (routing with iptables), Public Bridge và Private Bridge.\

**4.1. Private Bridge**

Trường hợp sử dụng: Để tạo một mạng nội bộ giữa 2 hay nhiều máy ảo. Mạng này sẽ không thấy được từ các máy ảo khác cũng như mạng bên ngoài.

**4.2. Public Bridge**

Trường hợp sử dụng: Gán bridge với một card mạng để giúp các máy ảo kết nối với public bridge có thể giao tiếp trực tiếp với mạng như một thiết bị trong mạng.

**4.3. NAT (routing with iptables)**

Đây là chế độ mạng mặc định của KVM. Các máy ảo được cấp phát ip và sẽ được định tuyến để có thể ra được mạng ngoài bằng iptables.


### **5. Các file cấu hình của KVM**

Thư mục chưa máy ảo

Thông tin cấu hình của máy ảo nằm ở thư mục /etc/libvirt/qemu/. Trong thư mục này sẽ chứa tất cả các file cấu hình của từng máy ảo hiện có trong KVM dưới dạng file xml. Chúng ta có thể chỉnh sửa thông tin của máy ảo trực tiếp từ file này hoặc bằng lệnh virsh edit <tên máy ảo>

Thư mục chứ các file storage của máy ảo như image thường sẽ được để ở /var/lib/libvirt/image

File log của KVM

Các file log của KVM nằm trong /var/log/libvirt/

Log ghi lại hoạt động của từng máy ảo nằm trong thư mục /var/log/libvirt/qemu/. Khi một máy ảo được tạo thì sẽ tự động tạo một file log cho máy ảo đó và được lưu trong thư mục này

Thư mục chứa image /var/lib/libvirt/image