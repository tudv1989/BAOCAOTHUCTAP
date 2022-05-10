using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ShopQuanAo
{
    public class BUS_BinhLuan
    {
        public void ThemBinhLuan(BinhLuan bl)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            dao.ThemBinhLuan(bl);
        }
        public DataTable LoadBinhLuan(int MaSP,int Admin)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            return dao.LoadBinhLuan(MaSP,Admin);
        }
        public BinhLuan LayThongTinBinhLuan(int MaBL)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            return dao.LayThongTinBinhLuan(MaBL);
        }
        public void XoaBL(int MaBL)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            dao.XoaBL(MaBL);
        }
        public void CapNhatBinhLuan(BinhLuan bl)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            dao.CapNhatBinhLuan(bl);
        }
    }
}