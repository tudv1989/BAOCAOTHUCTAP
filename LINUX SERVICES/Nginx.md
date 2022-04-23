# Tìm hiểu NGINX.

## 1. NGINX là gì?

**NGINX** là một phần mềm mã nguồn mở để làm web server, reverse proxying, caching, load balancing, media streaming,... 
Nó được thiết kế để làm một web server có hiệu năng cao và ổn định. 
Thêm vào đó nó có chức năng của một HTTP server, NGINX cũng có chức năng như là một [reverse proxing](./07.NGINX-as-reverse-proxying.md), một proxy server cho email (IMAP, POP3, and SMTP) và [cân bằng tải](./05.Load-balacer.md) HTTP, TCP, UPD.

## 2. Lịch sử 

NGINX được viết bởi *Igor Sysoev* để giải quyết [vấn đề C10k - một vấn đề liên quan đến việc sử lý một lượng lớn yêu cầu (10 nghìn) cùng một thời điểm. 
=> Được thiết kế để có hiệu năng cao.

Sau khi mở mã nguồn năm 2004, Sysoev đồng sáng lập **NGINX, Inc.** để hỗ trợ tiếp tục phát triển NGINX và tiếp thị **NGINX Plus** như một sản phẩm thương mại với các tính năng bổ sung được thiết kế cho khách hàng doanh nghiệp. Ngày nay, NGINX và NGINX Plus có thể xử lý hàng trăm ngàn kết nối đồng thời và cung cấp năng lượng cho hơn 50% các trang web bận rộn nhất trên web.

## NGINX là một Máy chủ Web

Mục tiêu đằng sau NGINX là tạo ra máy chủ web nhanh nhất và duy trì sự xuất sắc đó vẫn là mục tiêu trung tâm của dự án . NGINX luôn đánh bại Apache và các máy chủ khác trong các tiêu chuẩn đánh giá hiệu năng của máy chủ web . Kể từ khi NGINX phát hành ban đầu, các trang web đã mở rộng từ các trang HTML đơn giản sang nội dung động, nhiều mặt. NGINX đã phát triển cùng với nó và hiện hỗ trợ tất cả các thành phần của Web hiện đại, bao gồm WebSocket, HTTP / 2 và phát trực tuyến nhiều định dạng video (HDS, HLS, RTMP và các định dạng khác).

## NGINX ngoài mục đích làm máy chủ web

Mặc dù NGINX trở nên nổi tiếng là máy chủ web nhanh nhất, kiến ​​trúc cơ bản có thể mở rộng đã chứng minh lý tưởng cho nhiều tác vụ web ngoài việc phục vụ nội dung. Do có thể xử lý khối lượng kết nối lớn, NGINX thường được sử dụng làm **reverce proxy** và **cân bằng tải** để quản lý lưu lượng đến và phân phối đến các upstream servers - mọi thứ từ máy chủ cơ sở dữ liệu kế thừa đến microservice.

NGINX cũng thường được đặt giữa máy khách và máy chủ web thứ hai, để phục vụ như **một bộ cung cấp SSL/TLS** hoặc máy gia tốc web. Hoạt động như một trung gian, NGINX xử lý hiệu quả các tác vụ có thể làm chậm máy chủ web của bạn, chẳng hạn như đàm phán SSL/TLS hoặc nén và lưu trữ nội dung để cải thiện hiệu suất. Các trang web động, được xây dựng bằng cách sử dụng mọi thứ từ Node.js đến PHP, thường triển khai NGINX làm content caching và reverse proxy để giảm tải cho các máy chủ ứng dụng và sử dụng phần cứng cơ bản hiệu quả nhất.

## NGINX và NGINX Plus

NGINX Plus và NGINX là các giải pháp phân phối ứng dụng và máy chủ web tốt nhất được sử dụng bởi các trang web có lưu lượng truy cập cao như Dropbox, Netflix và Zynga. Hơn 400 triệu trang web trên toàn thế giới, bao gồm phần lớn trong số 100.000 trang web bận rộn nhất , dựa vào NGINX Plus và NGINX để cung cấp nội dunVg của họ một cách nhanh chóng, đáng tin cậy và an toàn.

NGINX làm cho bộ cân bằng tải phần cứng trở nên lỗi thời. Là một bộ cân bằng tải nguồn mở chỉ có phần mềm, NGINX ít tốn kém hơn và có thể cấu hình hơn các bộ cân bằng tải phần cứng và được thiết kế cho các kiến ​​trúc đám mây hiện đại. NGINX Plus hỗ trợ cấu hình lại nhanh chóng và tích hợp với các công cụ DevOps hiện đại để theo dõi dễ dàng hơn.
NGINX là một công cụ đa chức năng. Với NGINX, bạn có thể sử dụng cùng một công cụ như bộ cân bằng tải, reverse proxy, caching và máy chủ web, giảm thiểu số lượng công cụ và cấu hình mà tổ chức của bạn cần duy trì. NGINX cung cấp các hướng dẫn, hội thảo trên web và một loạt các tài liệu để giúp bạn trên đôi chân của mình. NGINX Plus bao gồm hỗ trợ khách hàng phản ứng nhanh , do đó bạn có thể dễ dàng nhận trợ giúp chẩn đoán bất kỳ phần nào trong ngăn xếp của bạn sử dụng NGINX hoặc NGINX Plus.
NGINX tiếp tục phát triển. Trong thập kỷ qua, NGINX luôn đi đầu trong việc phát triển Web hiện đại và đã giúp dẫn đường cho mọi thứ từ HTTP/2 đến hỗ trợ microservice. Khi việc phát triển và phân phối các ứng dụng web tiếp tục phát triển, NGINX Plus tiếp tục bổ sung các tính năng để cho phép phân phối ứng dụng hoàn hảo, từ hỗ trợ được công bố gần đây về cấu hình bằng cách sử dụng triển khai JavaScript được tùy chỉnh cho NGINX , để hỗ trợ cho các mô-đun động . Sử dụng NGINX Plus đảm bảo bạn sẽ luôn đi đầu trong hiệu suất web.