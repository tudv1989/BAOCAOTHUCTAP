# Trong hệ điều hành Linux phân chia thành 3 trường hợp: 

- TH1: Nén (dữ liệu được nén lại với kích thước nhỏ hơn dữ liệu
gốc) 
- TH2: Đóng gói (để phục vụ cho nhiều dữ liệu nhỏ không bị phân
mảnh, chúng ta gom lại thành 1 khối) 
- TH3: Đóng gói và nén (Dữ liệu vừa được gói và nén lại, vừa đảm
bảo sự đồng bộ 1 khối cũng như thu gọn lại kích thước dữ liệu 



### Nén và giải nén:


Có 3 định dạng nén là: *.zip; *.gz; *.bz2
## *.zip: 
Đây là định dạng thông dụng nhất đối với Linux, dễ sử dụng và nhiều phần
mềm hỗ trợ.

Cấu trúc Nén:

zip -r <Ten_file_nen>.zip <file hay folder cần nén>

-r: thuật toán đệ quy (recurse)

Giải Nén:

unzip <Ten_file_nen>.zip

Đặt password

zip --password <pass> <Ten_file_nen>.zip <file hay folder cần nén>


## *.gz Đóng gói 

GZIP được dùng khá phổ biến trong nền tảng Unix/Linux. GZIP chỉ có thể làm việc trên 1 tập tin hoặc 1 dòng dữ liệu. Do đó nó không thể lưu trữ được nhiều tập tin. Vì vậy nếu muốn sử dụng cho nhiều tập tin thì chúng ta phải sử dụng TAR
đóng gói chúng lại trước.

Cấu trúc Nén:

gzip <Ten_file_nen>

-c: compress - nén

Giải Nén:

gzip -dv <Ten_file_nen>.gz

Hoặc #gunzip <Ten_file_nen>.gz

-d: decompress: giải nén

V: Xem quá trình extract(Verbose)

## *.bz2:

Cấu trúc Nén:

#bzip2 -c <Ten_file_nen>

-c: compress - nén

Giải Nén:

#bzip2 -dv <Ten_file_nen>.bz2

Hoặc #bunzip <Ten_file_nen>.bz2

-d: decompress: giải nén

V: Xem quá trình extract

##  Đóng gói và nén:

-  Nén & giải nén với định dạng *tar.gz.

File *tar.gz là file nén mặc định của linux, điểm mạnh là tiết kiệm dung lượng sau
khi nén.

Để nén một thư mục ta sử dụng lệnh sau:

tar -czvf < Ten_file_nen >.tar.gz < file hay folder cần nén >

- Giải nén:

tar -zxvf < Ten_file_nen >.tar.gz

- Nén & giải nén với định dạng *tar.bz2.  Loại file nén này cũng tương tự như tar.gz.  Để nén một thư mục ta sử dụng lệnh sau:

tar -cjvf < Ten_file_nen >.tar.bz2 < file hay folder cần nén >

- Giải nén:

tar -jxvf < Ten_file_nen >.tar.bz2


