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
        public DataTable LoadBinhLuan(int MaSP)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            return dao.LoadBinhLuan(MaSP);
        }
    }
}