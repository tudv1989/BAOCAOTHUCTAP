
Message Transfer Agent (viết tắt là MTA), tạm dịch tiếng Việt là tác nhân chuyển thư. Đây là dịch vụ xử lý các tin nhắn trực tuyến: chuyển thư từ máy tính đến một nơi khác.

Các chương trình cung cấp dịch vụ MTA tiêu biểu là: Qmail, Sendmail, Postfix (Linux), Edge/Hub Transport của MS Exchange Server (Windows).


Việc kiểm tra log gửi/nhận của email server zimbra là rất cần thiết, giúp xác định được một email đã gửi/nhận thành công hay chưa và nếu chưa thành công thì bị dừng ở bước nào và báo lỗi ra sao.

– Đường dẫn file log

/var/log/zimbra.log

– Chu trình gửi: Khi click gửi thư => Connect tới email server => MTA kiểm tra địa chỉ người nhận => Kiểm tra qua các rule filter, đánh giá spam, virus => Xếp vào queue => Gửi thư => Xóa khỏi queue => Thông báo Message accepted for delivery


```
May  5 13:35:54 mail postfix/postscreen[16736]: CONNECT from [45.117.82.48]:57224 to [45.117.82.48]:25
May  5 13:35:54 mail postfix/postscreen[16736]: ALLOWLISTED [45.117.82.48]:57224
May  5 13:35:54 mail postfix/smtpd[16737]: connect from mail.tudv1.tudv.xyz[45.117.82.48]
May  5 13:35:54 mail postfix/smtpd[16737]: NOQUEUE: filter: RCPT from mail.tudv1.tudv.xyz[45.117.82.48]: <admin@tudv3.tudv.xyz>: Sender address triggers FILTER smtp-amavis:[127.0.0.1]:10026; from=<admin@tudv3.tudv.xyz> to=<idinhtu1989@gmail.com> proto=ESMTP helo=<mail.tudv3.tudv.xyz>
May  5 13:35:54 mail postfix/smtpd[16737]: B141CE6BDD: client=mail.tudv1.tudv.xyz[45.117.82.48]
May  5 13:35:54 mail postfix/cleanup[16740]: B141CE6BDD: message-id=<1406627814.5.1651732554479.JavaMail.zimbra@tudv3.tudv.xyz>
May  5 13:35:54 mail postfix/qmgr[4080]: B141CE6BDD: from=<admin@tudv3.tudv.xyz>, size=1153, nrcpt=1 (queue active)
May  5 13:35:54 mail postfix/smtpd[16737]: disconnect from mail.tudv1.tudv.xyz[45.117.82.48] ehlo=1 mail=1 rcpt=1 data=1 quit=1 commands=5
May  5 13:35:54 mail amavis[4083]: (04083-01) ESMTP :10026 /opt/zimbra/data/amavisd/tmp/amavis-20220505T133554-04083-4wrBkJsi: <admin@tudv3.tudv.xyz> -> <idinhtu1989@gmail.com> Received: from mail.tudv3.tudv.xyz ([127.0.0.1]) by localhost (mail.tudv3.tudv.xyz [127.0.0.1]) (amavisd-new, port 10026) with ESMTP for <idinhtu1989@gmail.com>; Thu,  5 May 2022 13:35:54 +0700 (+07)
May  5 13:35:54 mail amavis[4083]: (04083-01) Checking: WaVl27LgwIDf ORIGINATING/MYNETS [45.117.82.48] <admin@tudv3.tudv.xyz> -> <idinhtu1989@gmail.com>
May  5 13:35:55 mail postfix/dkimmilter/smtpd[16743]: connect from localhost[127.0.0.1]
May  5 13:35:55 mail postfix/dkimmilter/smtpd[16743]: 15411E6BE1: client=localhost[127.0.0.1]
May  5 13:35:55 mail postfix/cleanup[16740]: 15411E6BE1: message-id=<1406627814.5.1651732554479.JavaMail.zimbra@tudv3.tudv.xyz>
May  5 13:35:55 mail opendkim[27022]: 15411E6BE1: no signing table match for 'admin@tudv3.tudv.xyz'
May  5 13:35:55 mail postfix/qmgr[4080]: 15411E6BE1: from=<admin@tudv3.tudv.xyz>, size=1631, nrcpt=1 (queue active)
May  5 13:35:55 mail amavis[4083]: (04083-01) WaVl27LgwIDf FWD from <admin@tudv3.tudv.xyz> -> <idinhtu1989@gmail.com>, BODY=7BIT 250 2.0.0 from MTA(smtp:[127.0.0.1]:10030): 250 2.0.0 Ok: queued as 15411E6BE1
May  5 13:35:55 mail amavis[4083]: (04083-01) Passed CLEAN {RelayedOutbound}, ORIGINATING/MYNETS LOCAL [45.117.82.48]:57224 [45.117.82.48] <admin@tudv3.tudv.xyz> -> <idinhtu1989@gmail.com>, Queue-ID: B141CE6BDD, Message-ID: <1406627814.5.1651732554479.JavaMail.zimbra@tudv3.tudv.xyz>, mail_id: WaVl27LgwIDf, Hits: -, size: 1152, queued_as: 15411E6BE1, 380 ms
May  5 13:35:55 mail postfix/smtp[16741]: B141CE6BDD: to=<idinhtu1989@gmail.com>, relay=127.0.0.1[127.0.0.1]:10026, delay=0.45, delays=0.04/0.03/0.02/0.37, dsn=2.0.0, status=sent (250 2.0.0 from MTA(smtp:[127.0.0.1]:10030): 250 2.0.0 Ok: queued as 15411E6BE1)
May  5 13:35:55 mail postfix/qmgr[4080]: B141CE6BDD: removed
May  5 13:35:55 mail amavis[4083]: (04083-01) extra modules loaded: Mozilla/CA.pm
May  5 13:35:55 mail amavis[4084]: (04084-01) ESMTP :10032 /opt/zimbra/data/amavisd/tmp/amavis-20220505T133555-04084-eQwxpwWz: <admin@tudv3.tudv.xyz> -> <idinhtu1989@gmail.com> SIZE=1631 Received: from mail.tudv3.tudv.xyz ([127.0.0.1]) by localhost (mail.tudv3.tudv.xyz [127.0.0.1]) (amavisd-new, port 10032) with ESMTP for <idinhtu1989@gmail.com>; Thu,  5 May 2022 13:35:55 +0700 (+07)
May  5 13:35:55 mail amavis[4084]: (04084-01) Checking: eldOocZG_A1P ORIGINATING_POST/MYNETS [127.0.0.1] <admin@tudv3.tudv.xyz> -> <idinhtu1989@gmail.com>
May  5 13:35:56 mail postfix/amavisd/smtpd[16750]: connect from localhost[127.0.0.1]
May  5 13:35:56 mail postfix/amavisd/smtpd[16750]: 97597E6BE4: client=localhost[127.0.0.1]
May  5 13:35:56 mail postfix/cleanup[16740]: 97597E6BE4: message-id=<1406627814.5.1651732554479.JavaMail.zimbra@tudv3.tudv.xyz>
May  5 13:35:56 mail postfix/qmgr[4080]: 97597E6BE4: from=<admin@tudv3.tudv.xyz>, size=1999, nrcpt=1 (queue active)
May  5 13:35:56 mail amavis[4084]: (04084-01) eldOocZG_A1P FWD from <admin@tudv3.tudv.xyz> -> <idinhtu1989@gmail.com>, BODY=7BIT 250 2.0.0 from MTA(smtp:[127.0.0.1]:10025): 250 2.0.0 Ok: queued as 97597E6BE4
May  5 13:35:56 mail amavis[4084]: (04084-01) Passed CLEAN {RelayedOutbound}, ORIGINATING_POST/MYNETS LOCAL [127.0.0.1]:42944 [45.117.82.48] <admin@tudv3.tudv.xyz> -> <idinhtu1989@gmail.com>, Queue-ID: 15411E6BE1, Message-ID: <1406627814.5.1651732554479.JavaMail.zimbra@tudv3.tudv.xyz>, mail_id: eldOocZG_A1P, Hits: 2.5, size: 1596, queued_as: 97597E6BE4, 1481 ms
May  5 13:35:56 mail postfix/smtp[16741]: 15411E6BE1: to=<idinhtu1989@gmail.com>, relay=127.0.0.1[127.0.0.1]:10032, delay=1.6, delays=0.05/0.02/0.02/1.5, dsn=2.0.0, status=sent (250 2.0.0 from MTA(smtp:[127.0.0.1]:10025): 250 2.0.0 Ok: queued as 97597E6BE4)
May  5 13:35:56 mail postfix/qmgr[4080]: 15411E6BE1: removed
May  5 13:35:56 mail amavis[4084]: (04084-01) extra modules loaded: Mozilla/CA.pm
May  5 13:35:58 mail postfix/smtp[16751]: 97597E6BE4: to=<idinhtu1989@gmail.com>, relay=gmail-smtp-in.l.google.com[142.251.8.27]:25, delay=2.2, delays=0.01/0.02/1.1/1.1, dsn=2.0.0, status=sent (250 2.0.0 OK  1651732555 j70-20020a638049000000b003c1fa075c50si278594pgd.858 - gsmtp)

```
- Chu trình nhận: Chấp nhận kết nối từ email server gửi => Kiểm tra qua các rule filter, đánh giá spam, virus => Xếp vào queue => Nhận thư và xóa khỏi queue => Thông báo nhận thư 250 2.1.5 Delivery OK

```
May  5 13:38:02 mail postfix/postscreen[18230]: CONNECT from [209.85.222.51]:39854 to [45.117.82.48]:25
May  5 13:38:07 mail /postfix-script[18521]: the Postfix mail system is running: PID: 27260
May  5 13:38:08 mail postfix/postscreen[18230]: PASS NEW [209.85.222.51]:39854
May  5 13:38:08 mail postfix/smtpd[18611]: connect from mail-ua1-f51.google.com[209.85.222.51]
May  5 13:38:09 mail postfix/smtpd[18611]: Anonymous TLS connection established from mail-ua1-f51.google.com[209.85.222.51]: TLSv1.3 with cipher                                                           TLS_AES_128_GCM_SHA256 (128/128 bits) key-exchange X25519 server-signature RSA-PSS (2048 bits) server-digest SHA256
May  5 13:38:09 mail postfix/smtpd[18611]: NOQUEUE: filter: RCPT from mail-ua1-f51.google.com[209.85.222.51]: <idinhtu1989@gmail.com>: Sender add                                                              ress triggers FILTER smtp-amavis:[127.0.0.1]:10026; from=<idinhtu1989@gmail.com> to=<admin@tudv3.tudv.xyz> proto=ESMTP helo=<mail-ua1-f51.google.                                                                                            com>
May  5 13:38:09 mail postfix/smtpd[18611]: warning: permit_tls_clientcerts is requested, but "smtpd_tls_ask_ccert = no"
May  5 13:38:09 mail postfix/smtpd[18611]: NOQUEUE: filter: RCPT from mail-ua1-f51.google.com[209.85.222.51]: <idinhtu1989@gmail.com>: Sender add                                                                                            ress triggers FILTER smtp-amavis:[127.0.0.1]:10024; from=<idinhtu1989@gmail.com> to=<admin@tudv3.tudv.xyz> proto=ESMTP helo=<mail-ua1-f51.google.                                                                                            com>
May  5 13:38:09 mail postfix/smtpd[18611]: ECE98E6BE1: client=mail-ua1-f51.google.com[209.85.222.51]
May  5 13:38:09 mail postfix/cleanup[18684]: ECE98E6BE1: message-id=<CAMzzhF9GpAMR6iTmZ-hzC6RriDQ=m1mao8zHY06Eky-_iry-=A@mail.gmail.com>
May  5 13:38:09 mail postfix/qmgr[4080]: ECE98E6BE1: from=<idinhtu1989@gmail.com>, size=3463, nrcpt=1 (queue active)
May  5 13:38:10 mail amavis[4082]: (04082-01) ESMTP :10024 /opt/zimbra/data/amavisd/tmp/amavis-20220505T133810-04082-zFu0Z8iH: <idinhtu1989@gmail                                                                                            .com> -> <admin@tudv3.tudv.xyz> SIZE=3463 Received: from mail.tudv3.tudv.xyz ([127.0.0.1]) by localhost (mail.tudv3.tudv.xyz [127.0.0.1]) (amavis                                                                                            d-new, port 10024) with ESMTP for <admin@tudv3.tudv.xyz>; Thu,  5 May 2022 13:38:10 +0700 (+07)
May  5 13:38:10 mail amavis[4082]: (04082-01) Checking: fbSD2R7xnBNZ [209.85.222.51] <idinhtu1989@gmail.com> -> <admin@tudv3.tudv.xyz>
May  5 13:38:10 mail clamd[3923]: SelfCheck: Database status OK.
May  5 13:38:10 mail postfix/amavisd/smtpd[18687]: connect from localhost[127.0.0.1]
May  5 13:38:10 mail postfix/amavisd/smtpd[18687]: B51DBE6BE7: client=localhost[127.0.0.1]
May  5 13:38:10 mail postfix/cleanup[18684]: B51DBE6BE7: message-id=<CAMzzhF9GpAMR6iTmZ-hzC6RriDQ=m1mao8zHY06Eky-_iry-=A@mail.gmail.com>
May  5 13:38:10 mail postfix/qmgr[4080]: B51DBE6BE7: from=<idinhtu1989@gmail.com>, size=4393, nrcpt=1 (queue active)
May  5 13:38:10 mail amavis[4082]: (04082-01) fbSD2R7xnBNZ FWD from <idinhtu1989@gmail.com> -> <admin@tudv3.tudv.xyz>, BODY=7BIT 250 2.0.0 from M                                                                                            TA(smtp:[127.0.0.1]:10025): 250 2.0.0 Ok: queued as B51DBE6BE7
May  5 13:38:10 mail amavis[4082]: (04082-01) Passed CLEAN {RelayedInbound}, [209.85.222.51]:39854 [209.85.222.51] <idinhtu1989@gmail.com> -> <ad                                                                                            min@tudv3.tudv.xyz>, Queue-ID: ECE98E6BE1, Message-ID: <CAMzzhF9GpAMR6iTmZ-hzC6RriDQ=m1mao8zHY06Eky-_iry-=A@mail.gmail.com>, mail_id: fbSD2R7xnBN                                                                                            Z, Hits: -0.549, size: 3463, queued_as: B51DBE6BE7, dkim_sd=20210112:gmail.com, 764 ms
May  5 13:38:10 mail postfix/smtp[18685]: ECE98E6BE1: to=<admin@tudv3.tudv.xyz>, relay=127.0.0.1[127.0.0.1]:10024, delay=0.81, delays=0.03/0.02/0                                                                                            .01/0.75, dsn=2.0.0, status=sent (250 2.0.0 from MTA(smtp:[127.0.0.1]:10025): 250 2.0.0 Ok: queued as B51DBE6BE7)
May  5 13:38:10 mail postfix/qmgr[4080]: ECE98E6BE1: removed
May  5 13:38:10 mail amavis[4082]: (04082-01) extra modules loaded: Mozilla/CA.pm, unicore/To/Cf.pl, unicore/lib/Gc/Nd.pl
May  5 13:38:11 mail postfix/lmtp[18688]: B51DBE6BE7: to=<admin@tudv3.tudv.xyz>, relay=mail.tudv3.tudv.xyz[45.117.82.48]:7025, delay=0.38, delays                                                                                            =0.01/0.02/0.26/0.09, dsn=2.1.5, status=sent (250 2.1.5 Delivery OK)
May  5 13:38:11 mail postfix/qmgr[4080]: B51DBE6BE7: removed

May  5 13:38:41 mail postfix/smtpd[18611]: disconnect from mail-ua1-f51.google.com[209.85.222.51] ehlo=2 starttls=1 mail=1 rcpt=1 bdat=1 quit=1 commands=7




```
