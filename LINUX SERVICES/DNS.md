# Cấu hình DNS server trên Centos 7

## 1. Các khái niệm liên quan đến dns.
DNS - Domain Name System là dịch vụ phân giải tên miền ra địa chỉ ip và ngược lại.


### 1.1 Lịch sử
Trước khi có DNS, người ta tải và sử dụng file host.txt trên ftp server ở Stanford.

Năm 1984, Paul Mockapetris đã tạo ra dns, một cơ sở dữ liệu phân cấp có khả năng phân tán.
Ngày nay, dns hoặc hệ thống tên miền là một cơ sở dữ liệu phân cấp phân tán trên toàn thế giới được kiểm soát bởi ICANN. Chức năng chính của nó là phân giải tên thành địa chỉ IP và trỏ đến các máy chủ internet cung cấp dịch vụ smtp hoặc ldap. 
Tệp hosts.txt cũ vẫn còn hoạt động cho đến ngày nay trên hầu hết các hệ thống máy tính dưới tên / etc / hosts (hoặc C: / Windows / System32 / Driver / etc / hosts). Chúng tôi sẽ thảo luận về tập tin này sau, vì nó có thể ảnh hưởng đến độ phân giải tên.

### 1.2. Forward và reverse lookup query
Những câu hỏi của client gửi đến dns server được gọi là query (yêu cầu). Những yêu cầu để lấy địa chỉ ip từ tên miền được gọi là **forward lookup query**. Những yếu cầu để phân giải tên từ địa chỉ ip được gọi là **reverse lookup query**.

### 1.3. /etc/resolv.conf
Một máy client cần biết địa chỉ ip của dns server để có thể gửi query đến nó. Nó thường được cấu hình qua dhcp hay là cấu hình thủ công.

Linux client giữ thông tin đó trong file /etc/resolv.conf.

## 2. DNS namespace.
### Cấu trúc phân cấp.
DNS namespace là cấu trúc phân cấp dạng cây, với **root server** (dot server). **Root server** thường được biểu diễn bởi dấu chấm.



Dưới **root server** là các **Top Level Domain** hay **tld's**.
Hiện tại 200 nước trên thế giới đều có một tld. và có cả những tld chung như  .com, .edu, .org, .gov, .net, .mil, .int,....

### Root server.
Có 13 root server trên internet, tên được đặt từ A đến M. Chúng thường được coi là các máy chủ chính của internet vì nếu những server này không hoạt động, không ai có thể sử dụng tên để truy cập các website.
13 root server đó không phải là 13 máy chủ vật lý. Ví dụ như root server F có tổng cộng 46 máy vật lý hoạt động như một sử dụng any cast.




# Cài DNS server.




```
yum install bind bind-utils -y

```

- Cấu hình Dns server 
```
vi /etc/named.conf
```
Nội dung
```conf
//
// named.conf
//
// Provided by Red Hat bind package to configure the ISC BIND named(8) DNS
// server as a caching only nameserver (as a localhost DNS resolver only).
//
// See /usr/share/doc/bind*/sample/ for example named configuration files.
//
// See the BIND Administrators Reference Manual (ARM) for details about the
// configuration located in /usr/share/doc/bind-{version}/Bv9ARM.html

options {
        listen-on port 53 { 127.0.0.1; 192.168.111.40; };
        listen-on-v6 port 53 { ::1; };
        directory       "/var/named";
        dump-file       "/var/named/data/cache_dump.db";
        statistics-file "/var/named/data/named_stats.txt";
        memstatistics-file "/var/named/data/named_mem_stats.txt";
        recursing-file  "/var/named/data/named.recursing";
        secroots-file   "/var/named/data/named.secroots";
        allow-query     { localhost; 192.168.111.0/24; };
        allow-transfer {localhost; 8.8.8.8; };

        /* 
         - If you are building an AUTHORITATIVE DNS server, do NOT enable recursion.
         - If you are building a RECURSIVE (caching) DNS server, you need to enable 
           recursion. 
         - If your recursive DNS server has a public IP address, you MUST enable access 
           control to limit queries to your legitimate users. Failing to do so will
           cause your server to become part of large scale DNS amplification 
           attacks. Implementing BCP38 within your network would greatly
           reduce such attack surface 
        */
        recursion yes;

        dnssec-enable yes;
        dnssec-validation yes;

        /* Path to ISC DLV key */
        bindkeys-file "/etc/named.iscdlv.key";

        managed-keys-directory "/var/named/dynamic";

        pid-file "/run/named/named.pid";
        session-keyfile "/run/named/session.key";
};

logging {
        channel default_debug {
                file "data/named.run";
                severity dynamic;
        };
};

zone "." IN {
        type hint;
        file "named.ca";
};

zone "linux2.vn" IN {
type master;
file "forward.linux2";
allow-update { none; };
};

zone "111.168.192.in-addr.arpa" IN {
type master;
file "reverse.linux2";
allow-update { none; };
};



include "/etc/named.rfc1912.zones";
include "/etc/named.root.key";

```
- Tạo file zone vừa xác định trong file /etc/named.conf
```
vi /var/named/forward.unixmen

```

```
$TTL 86400
@ IN SOA masterdns.linux2.vn. root.linux2.vn. (
 2011071001 ;Serial
 3600 ;Refresh
 1800 ;Retry
 604800 ;Expire
 86400 ;Minimum TTL
)
@ IN NS masterdns.linux2.vn.
@ IN  A 192.168.111.40
@ IN  A 192.168.111.10
@ IN  A 192.168.111.50
@ IN  A 192.168.111.30
@ IN  A 192.168.111.5
masterdns IN A 192.168.111.40
web IN A 192.168.111.30
nfs IN A 192.168.111.5
```
- Tạo file reverse:
```
vi /var/named/reverse.linux2
```
```
$TTL 86400
@ IN SOA masterdns.unixmen.local. root.unixmen.local. (
 2011071001 ;Serial
 3600 ;Refresh
 1800 ;Retry
 604800 ;Expire
 86400 ;Minimum TTL
)
@ IN NS masterdns.unixmen.local.
@ IN NS secondarydns.unixmen.local.
@ IN PTR linux2.local.
masterdns IN A 192.168.111.40
nfs IN A 192.168.111.10
web IN A 192.168.111.30
40 IN PTR masterdns.linux2.vn.
10 IN PTR nfs.linux2.vn.
30 IN PTR web.linux2.vn.
```

- Bật service:
```
systemctl enable named
systemctl start named
```
- Cấu hình firewall:
```
firewall-cmd --permanent --add-port=53/tcp
firewall-cmd --permanent --add-port=53/udp
firewall-cmd --reload
```


- Kiểm tra file cấu hình và zone:
```
named-checkconf /etc/named.conf
named-checkzone linux2.vn /var/named/forward.linux2
named-checkzone linux2.vn /var/named/reverse.linux2
```

