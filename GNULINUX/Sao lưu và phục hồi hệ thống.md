# Sao lưu và phục hồi hệ thống

### Sao lưu và phục hồi hệ thống với dd


Lệnh dd dùng để copy dữ liệu thô ở mức thấp » copy theo block, dd có thể copy 1 phân vùng ổ 
đĩa cứng lưu ra file và ngược lại, dd đọc dữ liệu từ một file và ghi ra thành một file theo một 
định dạng nào đó. File ở đây theo nghĩa rộng, thường là device file, không nhất thiết phải là file 
thông thường.

Cú pháp: dd if={input file} of={output file} bs={block size} count={how many blocks}

Các tham số của lệnh dd theo kiểu option=value

- if: đường dẫn file nguồn để đọc dữ liệu vào

- of: đường dẫn file đích mà dữ liệu ghi ra

Nếu không chỉ rõ if và of thì mặc định dd sẽ lấy các kí tự từ /dev/stdin (bàn phím) và ghi 
dữ liệu ra /dev/stdout (màn hình)

- bs: dữ liệu được đọc vào/ghi ra thành từng khối block, bs (block size) là kích thước của 
khối, block size mặc định là 512 byte. Ví dụ: bs=5 (5 byte), bs=5MB…

- count: số block được đọc vào và ghi ra. Nếu thiếu count lệnh dd sẽ đọc hết toàn bộ if và 
ghi toàn bộ dữ liệu ra of

Backup toàn bộ dữ liệu ổ cứng /dev/sda sang ổ cứng /dev/sdb

 - dd if=/dev/sda of=/dev/sdb

Ghi đĩa CD ra file .iso

 - dd if=/dev/cdrom of=cd.iso

Mount file ISO image

 - mount -o loop cd.iso /media

Lệnh cp không thể copy được: ổ cứng, phân vùng, MBR, boot sector

# Đồng bộ dữ liệu với Rsync

Rsync không chỉ đảm bảo một hoặc nhiều tập tin giống nhau ở thư mục nguồn và thư mục đích, 
nó sử dụng một thuật toán phức tạp để so sánh các phần của mỗi tập tin, do đó làm giảm đáng kể 
thời gian cần thiết để đồng bộ hóa. Ngoài ra, rsync nén dữ liệu để giảm băng thông và sử dụng 
ssh trên hệ thống Linux để bảo mật.

Cú pháp: rsync -options source destination

Đồng bộ dữ liệu: SERVER1: /var/www/html ›› SERVER2: /var/www

Thực hiện rsync trên SERVER2

 rsync -avzP --delete -e ssh root@SERVER1:/var/www/html /var/www

-a: (archive) các file backup có thể giữ nguyên các thuộc tính: sự phân quyền, chủ sở hữu, nhóm 
sở hữu, thời gian, recursive mode và các symbolic links

-v: để trình bày chi tiết

-z: nén dữ liệu để tiết kiệm băng thông

-P: hiển thị chi tiết quá trình rsync

--delete: nếu các file ở nguồn (source) bị xóa thì các file đó củng được xóa ở đích (destination)

-e ssh: chỉ định sử dụng ssh với rsync

--exclude=FOLDER_hay_FILE: loại trừ không đồng bộ các fil




