using BaiTapLon.Models.Entities;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models.DAOO
{
    public class SanPhamDAO
    {
        public DataBase db;
        public SanPhamDAO()
        {
            db = new DataBase();
        }

        public List<TungSanPham> getSanPham(string ShoeFirm, string type)
        {
            List<TungSanPham> listTungSanPham = new List<TungSanPham>();
            var sanPham = db.SanPhams.Select(s => new { s.Name, s.Image, s.ShoeFirm, s.Price, s.Type }).Where(e => e.ShoeFirm.CompareTo(ShoeFirm) == 0).Where(e => e.Type.CompareTo(type) == 0).GroupBy(g => new { g.Name, g.Image, g.ShoeFirm , g.Price});
            foreach (var x in sanPham)
            {
                TungSanPham tungSanPham = new TungSanPham();
                tungSanPham.Name = x.Key.Name;
                tungSanPham.Image = x.Key.Image;
                tungSanPham.ShoeFirm = x.Key.ShoeFirm;
                tungSanPham.Price = x.Key.Price;
                listTungSanPham.Add(tungSanPham);
            }
            return listTungSanPham;
        }

        public List<TungSanPham> getSanPham(string ShoeFirm)
        {
            List<TungSanPham> listTungSanPham = new List<TungSanPham>();
            var sanPham = db.SanPhams.Select(s => new { s.Name, s.Image, s.ShoeFirm, s.Price}).Where(e => e.ShoeFirm.CompareTo(ShoeFirm) == 0).GroupBy(g => new { g.Name, g.Image, g.ShoeFirm, g.Price });
            foreach (var x in sanPham)
            {
                TungSanPham tungSanPham = new TungSanPham();
                tungSanPham.Name = x.Key.Name;
                tungSanPham.Image = x.Key.Image;
                tungSanPham.ShoeFirm = x.Key.ShoeFirm;
                tungSanPham.Price = x.Key.Price;
                listTungSanPham.Add(tungSanPham);
            }
            return listTungSanPham;
        }

        public List<SanPham> getSanPham()
        {
            return db.SanPhams.ToList();
        }
        public List<SanPham> thongTinSanPham(string Name)
        {
            IQueryable<SanPham> listSanPham = from x in db.SanPhams
                                     where x.Name.CompareTo(Name) == 0
                                     select x ;
            List<SanPham> listThongTinSanPham = new List<SanPham>();
            foreach(var x in listSanPham)
            {
                listThongTinSanPham.Add(x);
            }
            return listThongTinSanPham;
        }
        public List<SanPham> getAll()
        {
            return db.SanPhams.ToList();
        }
    }
}