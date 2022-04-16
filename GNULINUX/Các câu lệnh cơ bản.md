# Làm quen với các câu lệnh trong linux.
### 1.Câu lệnh man

man là câu lệnh để hiển thị trang hướng dẫn sử dụng của các câu lệnh trên linux.

Nó cung cấp chi tiết về lệnh bao gồm: NAME, SYNOPSIS, DESCRIPTION, OPTIONS, EXIT STATUS, RETURN VALUES, ERRORS, FILES, VERSIONS, EXAMPLES, AUTHORS và SEE ALSO.

Mỗi manual có các section sau:

-  thông tin chung về câu lệnh

- system call

-  library function

- Các file đặc biệt(thường tìm thấy ở /dev) và driver

- Định dạng file

...

Cú pháp: # man [OPTION].. [COMMAND NAME]..

Không có option: nó sẽ in ra toàn bộ hướng dẫn cho câu lệnh.

Số section: vì hướng dẫn được chia thành nhiều section nên nếu option là số section thì nó chỉ hiển thị trang của section đó.

các option khác có thể xem ở trang hướng dẫn của man bằng lệnh man man



### 2.Làm việc với thư mục

2.1. Đường dẫn tuyệt đối và đường dẫn tương đối

- Đường dẫn tuyệt đối là đường dẫ n của một tệp tin hay thư mục phải bắt đầu từ / (root) và theo cây nhánh đến thư mục hay tệp mong muốn. Tóm lại, đường dẫn tuyệt đối là đường dẫn bắt đầu từ / Ví dụ: /usr/local

- Đường dẫn tương đối là đường dẫn của một thư mục hay tệp mà không bắt buộc phải bắt đầu từ / mà có thể tiếp cận với các thư mục, tệp đó từ working directory(thư mục hiện tại).

- Tên của một thư mục hoặc tệp tin.

- Hệ điều hành Linux dùng ký hiệu “.” chỉ thư mục hiện hành và ký hiệu “..” chỉ thư mục mẹ của thư mục hiện hành. Ví dụ: bạn đang ở thư mục /home/a và bạn muốn chuyển sang thư mục /home/b, bạn có thể sử dụng đường dẫn tương đối như lệnh sau: cd ../b

2.2. Một số lệnh làm việc với thư mục

- pwd - print working directory: in ra đường dẫn tuyệt đối đến thư mục hiện tại.

- cd - change directory: dùng để di chuyển đến thư mục khác.

- cd /root/Downloads: di chuyển đến thư mục /root/Downloads

- cd ..: di chuyển đến thư mục cha

- cd /: di chuyển đến thư mục root.

- cd -: di chuyển đến thư mục trước đó.

- mkdir make directory: là lệnh dung để tạo thư mục.

- mkdir -p: tạo cả thư mục và các thư mục con của nó. ví dụ mkdir -p z/y/x thì nó sẽ tạo cả thư mục z, z/y và z/y/x.

- rmdir remove directory: là lệnh dùng để xóa thư mục

- rmdir -p dùng để xóa cả thư mục cha và các thư mục con của nó. ví dụ rmdir -p a/b/c thì sẽ xoa cả thư mục a/b/c, a/b và a.

- rm: là lệnh dùng để xóa thư mục hoặc file.

- ls: dùng để liệt kê nội dung trong một thư mục.

- ls -a: Hiển thị tất cả các file và thư mục trong một thư mục kể các các file, thư mục bị ẩn.

- ls -l: Hiển thị chi tiết hơn về các thư mục , file trong một thư mục

- ls -lh: Hiển thị chi tiết về các thư mục, file trong một thư mục bao gồm thêm kích thước của chúng.

### 3.Một số lệnh làm việc với file.

3.1. Linux phân biệt HOA, thường.

- Các file trong linux phân biệt viết hoa, viết thường. Nó có nghĩa là FILE1 khác với File1, /etc/hosts khác với /etc/Hosts.

3.2. Tất cả đều là file

- Trong Linux, một thư mục là một loại file đặc biệt nhưng nó vẫn là 1 file. Mỗi cửa sổ terminal (ví dụ /dev/pts/4), bất kì ổ cứng hay phân vùng nào( ví dụ /dev/sda1) và mọi tiến trịnh đều được đại diện bởi một file ở đâu đó trong filesystem.

3.3.Một số lệnh làm việc với file

- file: là lệnh dùng để xác định loại file. Trong Linux, nó không sử dụng các phần mở rộng(.txt,.png,...) để xác định loại file. Bạn nên sử dụng câu lệnh file để xác định loại file.

- touch -t là lệnh để tạo một file với thông tin về thời gian cho file đó.

- rm: dùng để xóa vĩnh viễn một file. Command line không có thùng rác để có thể khôi phục lại file. Một khi dùng rm để xóa file, file đó sẽ mất vĩnh viễn.

- rm -i: hỏi để đảm bảo việc xóa file không phải là erro.

- rm -rf: rm -r sẽ chỉ xóa các thư mục chống. Với rm -rf thì nó sẽ xóa tất cả mọi thứ(nếu nó có quyền để làm điều đó). Nếu bạn đăng nhập vào tài khoản root, bạn nên cẩn thận vì quyền không ảnh hưởng tới tài khoản root, rm -rf sẽ có thể xóa cả file hệ thống.

- cp là lệnh dùng để copy một file hay nhiều tại việc hoặc đến các thư mục khác.

- cp -r dùng để copy tất cả những file trong thư mục và cả các file trong thư mục con của nó

- cp -i dùng để ngăn chặn việc ghi đè lên một file đã tồn tại bằng cách hỏi khi file đã tồn tại.

- mv là lệnh dùng đề đổi tên, di chuyển file, thư mục

- mv -i: để hỏi lại nếu file hay thư mục đã tồn tại, có muốn ghi đè hay không.

4.Các lệnh thao tác với nội dung file.

- head:

Là lệnh để hiển thị phần đầu nội dung của file.

Cú pháp: $head [tên file]



Mặc định là lệnh head sẽ hiển thị 10 dòng đầu của file. Có thể tùy chỉ hiển thị n dòng bằng cú pháp: $head -[n] [tên file]


Cũng có thể hiện thị n ký tự đầu tiên với cú pháp:$head -c[n] [tên file]


- tail:

Là lệnh dùng để hiện thị phần cuối của một file.

Cú pháp: $tail [tên file]

Mặc định nó sẽ hiển thị 10 dòng cuối cùng của file


Có thể tùy chỉnh hiển thị n dòng cuối cùng của file bằng cú pháp: $tail -[n] [tên file]


Option -f thường xuyên được sử dụng để follow nội dung của tệp.

- cat:

Là lệnh dùng để hiển thị nội dung của file ra màn hình hoặc cũng có thể tạo file, copy nội dung file,...

Cú pháp: cat [option] [file]



Có thể hiển thị nhiều file một lúc bằng cú pháp:cat [option] [file1] [file2] [...]


Tạo file rỗng mới giống lệnh touch : cat > new_file.txt

Sử dụng option -n để hiển thị số thứ tự của mỗi dòng: cat -n [file]



- tac

Cũng để hiển thị toàn bộ nội dung file như cat, nhưng tac sẽ hiển thị file từ dưới lên trên.

Cú pháp: tac [option] [file]


- less

Lệnh less cho phép mở file để đọc tương tác, cho phép di chuyển lên xuống để tìm kiếm

Cú pháp: less [file]

Dùng space và b để di chuyển giữa các trang.

Dung phím mũi tên lên xuống để cuộn.

Phím G để di chuyển đến cuối tập tin, phím g để di chuyển đến đầu tập tin.
/[chuỗi] hoặc ?[chuỗi] để tìm kiếm trong file.

q để thoát

- more

dùng để mở một tệp để đọc tương tác, cho phép di chuyển xuống và tìm kiếm trong file.

Cú pháp: more [file]

Dùng Space để di chuyển xuống trang dưới

/[chuỗi] để tìm kiếm

phím q để thoát.

Khác với less, lệnh more không thể cuộn ngược lên các trang đã đọc.

- string

dùng để hiển thị tất cả các chuỗi ascii có thể đọc được trong một file.

thường dùng để hiển thị nội dung văn bản của các file binary.

- echo

là câu lệnh dùng để hiện thị một dòng văn bản

Cú pháp: echo "[text]" 