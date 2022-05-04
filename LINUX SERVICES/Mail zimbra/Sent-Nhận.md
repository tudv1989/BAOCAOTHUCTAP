Việc kiểm tra log gửi/nhận của email server zimbra là rất cần thiết, giúp xác định được một email đã gửi/nhận thành công hay chưa và nếu chưa thành công thì bị dừng ở bước nào và báo lỗi ra sao.

– Đường dẫn file log

/var/log/maillog

– Chu trình gửi: Khi click gửi thư => Connect tới email server => MTA kiểm tra địa chỉ người nhận => Kiểm tra qua các rule filter, đánh giá spam, virus => Xếp vào queue => Gửi thư => Xóa khỏi queue => Thông báo Message accepted for delivery


```
Mar 22 17:35:03 mail postfix/postscreen[26703]: CONNECT from [103.101.163.27]:57274 to [103.101.163.27]:25
Mar 22 17:35:03 mail postfix/postscreen[26703]: WHITELISTED [103.101.163.27]:57274
Mar 22 17:35:03 mail postfix/smtpd[26704]: connect from mail.hvn.space[103.101.163.27]
Mar 22 17:35:03 mail postfix/smtpd[26704]: NOQUEUE: filter: RCPT from mail.hvn.space[103.101.163.27]: <kiendt@hvn.space>: Sender address triggers FILTER smtp-amavis:[127.0.0.1]:10026; from=<kiendt@hvn.space> to=<kiendt@hvn.com.vn> proto=ESMTP helo=<mail.hvn.space>
Mar 22 17:35:03 mail postfix/smtpd[26704]: 8C0C11035C8: client=mail.hvn.space[103.101.163.27]
Mar 22 17:35:03 mail postfix/cleanup[26705]: 8C0C11035C8: message-id=<1461502541.19.1584873303494.JavaMail.zimbra@hvn.space>
Mar 22 17:35:03 mail postfix/smtpd[26704]: disconnect from mail.hvn.space[103.101.163.27] ehlo=1 mail=1 rcpt=1 data=1 quit=1 commands=5
Mar 22 17:35:03 mail postfix/qmgr[18088]: 8C0C11035C8: from=<kiendt@hvn.space>, size=1332, nrcpt=1 (queue active)
Mar 22 17:35:10 mail postfix/amavisd/smtpd[26711]: connect from localhost[127.0.0.1]
Mar 22 17:35:10 mail postfix/amavisd/smtpd[26711]: AF0C11035D3: client=localhost[127.0.0.1]
Mar 22 17:35:10 mail postfix/cleanup[26705]: AF0C11035D3: message-id=<VAlxpN_C_TkZ7F@mail.hvn.space>
Mar 22 17:35:10 mail postfix/qmgr[18088]: AF0C11035D3: from=<admin@hvn.space>, size=2537, nrcpt=1 (queue active)
Mar 22 17:35:10 mail postfix/dkimmilter/smtpd[26713]: connect from localhost[127.0.0.1]
Mar 22 17:35:10 mail postfix/dkimmilter/smtpd[26713]: BB0111035D4: client=localhost[127.0.0.1]
Mar 22 17:35:10 mail postfix/cleanup[26705]: BB0111035D4: message-id=<1461502541.19.1584873303494.JavaMail.zimbra@hvn.space>
Mar 22 17:35:10 mail postfix/qmgr[18088]: BB0111035D4: from=<kiendt@hvn.space>, size=1867, nrcpt=1 (queue active)
Mar 22 17:35:10 mail postfix/smtp[26706]: 8C0C11035C8: to=<kiendt@hvn.com.vn>, relay=127.0.0.1[127.0.0.1]:10026, delay=7.3, delays=0.03/0.02/0.01/7.3, dsn=2.0.0, status=sent (250 2.0.0 from MTA(smtp:[127.0.0.1]:10030): 250 2.0.0 Ok: queued as BB0111035D4)
Mar 22 17:35:10 mail postfix/qmgr[18088]: 8C0C11035C8: removed
Mar 22 17:35:11 mail postfix/lmtp[26712]: AF0C11035D3: to=<admin@hvn.space>, relay=mail.hvn.space[103.101.163.27]:7025, delay=0.55, delays=0.03/0.01/0.42/0.09, dsn=2.1.5, status=sent (250 2.1.5 Delivery OK)
Mar 22 17:35:11 mail postfix/qmgr[18088]: AF0C11035D3: removed
Mar 22 17:35:12 mail postfix/amavisd/smtpd[26716]: connect from localhost[127.0.0.1]
Mar 22 17:35:12 mail postfix/amavisd/smtpd[26716]: CF0671035C8: client=localhost[127.0.0.1]
Mar 22 17:35:12 mail postfix/cleanup[26705]: CF0671035C8: message-id=<1461502541.19.1584873303494.JavaMail.zimbra@hvn.space>
Mar 22 17:35:12 mail postfix/amavisd/smtpd[26716]: disconnect from localhost[127.0.0.1] ehlo=1 mail=1 rcpt=1 data=1 quit=1 commands=5
Mar 22 17:35:12 mail postfix/qmgr[18088]: CF0671035C8: from=<kiendt@hvn.space>, size=2920, nrcpt=1 (queue active)
Mar 22 17:35:12 mail postfix/smtp[26706]: BB0111035D4: to=<kiendt@hvn.com.vn>, relay=127.0.0.1[127.0.0.1]:10032, delay=2.1, delays=0.11/0.01/0/2, dsn=2.0.0, status=sent (250 2.0.0 from MTA(smtp:[127.0.0.1]:10025): 250 2.0.0 Ok: queued as CF0671035C8)
Mar 22 17:35:12 mail postfix/qmgr[18088]: BB0111035D4: removed
Mar 22 17:35:15 mail postfix/smtp[26717]: CF0671035C8: to=<kiendt@hvn.com.vn>, relay=mx07.email-hvn.net[203.162.79.167]:25, delay=2.9, delays=0.01/0.02/2.8/0.05, dsn=2.0.0, status=sent (250 2.0.0 5e773f65-00009f59 Message accepted for delivery)
Mar 22 17:35:15 mail postfix/qmgr[18088]: CF0671035C8: removed

```
- Chu trình nhận: Chấp nhận kết nối từ email server gửi => Kiểm tra qua các rule filter, đánh giá spam, virus => Xếp vào queue => Nhận thư và xóa khỏi queue => Thông báo nhận thư 250 2.1.5 Delivery OK

```
Mar 22 17:43:23 mail postfix/postscreen[32077]: CONNECT from [209.85.208.44]:44796 to [103.101.163.27]:25
Mar 22 17:43:29 mail postfix/postscreen[32077]: PASS NEW [209.85.208.44]:44796
Mar 22 17:43:29 mail postfix/smtpd[32078]: connect from mail-ed1-f44.google.com[209.85.208.44]
Mar 22 17:43:30 mail postfix/smtpd[32078]: Anonymous TLS connection established from mail-ed1-f44.google.com[209.85.208.44]: TLSv1.2 with cipher ECDHE-RSA-AES128-GCM-SHA256 (128/128 bits)
Mar 22 17:43:31 mail postfix/smtpd[32078]: NOQUEUE: filter: RCPT from mail-ed1-f44.google.com[209.85.208.44]: <kiendt@hvn.com.vn>: Sender address triggers FILTER smtp-amavis:[127.0.0.1]:10026; from=<kiendt@hvn.com.vn> to=<kiendt@hvn.space> proto=ESMTP helo=<mail-ed1-f44.google.com>
Mar 22 17:43:31 mail postfix/smtpd[32078]: NOQUEUE: filter: RCPT from mail-ed1-f44.google.com[209.85.208.44]: <kiendt@hvn.com.vn>: Sender address triggers FILTER smtp-amavis:[127.0.0.1]:10024; from=<kiendt@hvn.com.vn> to=<kiendt@hvn.space> proto=ESMTP helo=<mail-ed1-f44.google.com>
Mar 22 17:43:31 mail postfix/smtpd[32078]: 4B67C1035C8: client=mail-ed1-f44.google.com[209.85.208.44]
Mar 22 17:43:31 mail postfix/cleanup[32086]: 4B67C1035C8: message-id=<CAE71=UqPysBzQEWso90x+v6UAFnHPu7uc8zMs8nL+-CEUDgptg@mail.gmail.com>
Mar 22 17:43:31 mail postfix/qmgr[18088]: 4B67C1035C8: from=<kiendt@hvn.com.vn>, size=7240, nrcpt=1 (queue active)
Mar 22 17:43:32 mail postfix/smtpd[32078]: disconnect from mail-ed1-f44.google.com[209.85.208.44] ehlo=2 starttls=1 mail=1 rcpt=1 data=1 quit=1 commands=7
Mar 22 17:43:40 mail postfix/amavisd/smtpd[32092]: connect from localhost[127.0.0.1]
Mar 22 17:43:40 mail postfix/amavisd/smtpd[32092]: 014E01035D3: client=localhost[127.0.0.1]
Mar 22 17:43:40 mail postfix/cleanup[32086]: 014E01035D3: message-id=<VALGB39FdscOxm@mail.hvn.space>
Mar 22 17:43:40 mail postfix/amavisd/smtpd[32092]: disconnect from localhost[127.0.0.1] ehlo=1 mail=1 rcpt=1 data=1 quit=1 commands=5
Mar 22 17:43:40 mail postfix/qmgr[18088]: 014E01035D3: from=<admin@hvn.space>, size=4345, nrcpt=1 (queue active)
Mar 22 17:43:40 mail postfix/amavisd/smtpd[32092]: connect from localhost[127.0.0.1]
Mar 22 17:43:40 mail postfix/amavisd/smtpd[32092]: 066BC1035D4: client=localhost[127.0.0.1]
Mar 22 17:43:40 mail postfix/cleanup[32086]: 066BC1035D4: message-id=<CAE71=UqPysBzQEWso90x+v6UAFnHPu7uc8zMs8nL+-CEUDgptg@mail.gmail.com>
Mar 22 17:43:40 mail postfix/amavisd/smtpd[32092]: disconnect from localhost[127.0.0.1] ehlo=1 mail=1 rcpt=1 data=1 quit=1 commands=5
Mar 22 17:43:40 mail postfix/qmgr[18088]: 066BC1035D4: from=<kiendt@hvn.com.vn>, size=8203, nrcpt=1 (queue active)
Mar 22 17:43:40 mail postfix/smtp[32087]: 4B67C1035C8: to=<kiendt@hvn.space>, relay=127.0.0.1[127.0.0.1]:10024, delay=8.7, delays=0.63/0.02/0.01/8.1, dsn=2.0.0, status=sent (250 2.0.0 from MTA(smtp:[127.0.0.1]:10025): 250 2.0.0 Ok: queued as 066BC1035D4)
Mar 22 17:43:40 mail postfix/qmgr[18088]: 4B67C1035C8: removed
Mar 22 17:43:40 mail postfix/lmtp[32094]: 066BC1035D4: to=<kiendt@hvn.space>, relay=mail.hvn.space[103.101.163.27]:7025, delay=0.25, delays=0.01/0.01/0.14/0.08, dsn=2.1.5, status=sent (250 2.1.5 Delivery OK)
Mar 22 17:43:40 mail postfix/qmgr[18088]: 066BC1035D4: removed
Mar 22 17:43:40 mail postfix/lmtp[32093]: 014E01035D3: to=<admin@hvn.space>, relay=mail.hvn.space[103.101.163.27]:7025, delay=0.28, delays=0.01/0.01/0.16/0.1, dsn=2.1.5, status=sent (250 2.1.5 Delivery OK)
Mar 22 17:43:40 mail postfix/qmgr[18088]: 014E01035D3: removed


```
