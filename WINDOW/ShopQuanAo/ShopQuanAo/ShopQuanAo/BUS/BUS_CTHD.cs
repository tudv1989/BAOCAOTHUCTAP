using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ShopQuanAo
{
    public class BUS_CTHD
    {
        public void ThemCTHD(CTHD cthd)
        {
            DAO_CTHD daoCTHD = new DAO_CTHD();
            daoCTHD.ThemCTHD(cthd);
        }
        public DataTable LoadCTHD(int MaHD)
        {
            DAO_CTHD daoCTHD = new DAO_CTHD();
            return daoCTHD.LoadCTHD(MaHD);
        }
        public void XoaCTHD(int MaHD)
        {
            DAO_CTHD dao = new DAO_CTHD();
            dao.XoaCTHD(MaHD);
        }
        public void CapNhatCTHD(CTHD ct)
        {
            DAO_CTHD dao = new DAO_CTHD();
            dao.Open();
            dao.CapNhatCTHD(ct);
            dao.Close();
        }
    }
}