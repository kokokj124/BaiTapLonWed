using BaiTapLon.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models.DAO
{
    public class SanPhamDAO
    {
        BaiTapLonContext db;
        public SanPhamDAO()
        {
            db = new BaiTapLonContext();
        }

        public List<SanPham> GetAll()
        {
        }
    }
}