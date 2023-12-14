using MVC5OnlineTicariOtomasyon.Models.Siniflar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MVC5OnlineTicariOtomasyon.Controllers
{
    public class GrafikController : Controller
    {
        // GET: Grafik
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            var grafikciz = new Chart(600, 600);
            grafikciz.AddTitle("Kategori-Ürün Stok Sayısı").AddLegend("Stok").AddSeries("Değerler",
                xValue: new[] {"Küçük Ev Aleti", "Mobilya", "Tablet" },yValues: new[] {150,100,250}).Write();
            return File(grafikciz.ToWebImage().GetBytes(), "image/jpeg");
        }
        public ActionResult Index3()
        {
            ArrayList xvalue=new ArrayList();
            ArrayList yvalue = new ArrayList();
            var sonuclar = c.Uruns.ToList();
            sonuclar.ToList().ForEach(x => xvalue.Add(x.UrunAd));
            sonuclar.ToList().ForEach(y => yvalue.Add(y.Stok));
            var grafik=new Chart(width:800,height:800)
                .AddTitle("Stoklar")
                .AddSeries(chartType:"Pie",name:"Stok",xValue:xvalue, yValues:yvalue);
            return File(grafik.ToWebImage().GetBytes(),"image/jpeg");
        }
        public ActionResult Index4()
        {
            return View();  
        }
        public ActionResult VisualizeUrunResult()
        {
            return Json(UrunListesi(), JsonRequestBehavior.AllowGet);
        }
        public List<Sinif1> UrunListesi()
        {
            List<Sinif1> snf = new List<Sinif1>();
            snf.Add(new Sinif1()
            {
                urunad="Beyaz Eşya",
                    stok = 200
            });
			snf.Add(new Sinif1()
			{
				urunad = "Laptop",
				stok = 250
			});
			snf.Add(new Sinif1()
			{
				urunad = "Mobilya",
				stok = 100
			});
			snf.Add(new Sinif1()
			{
				urunad = "Tablet",
				stok = 300
			});
			snf.Add(new Sinif1()
			{
				urunad = "Televiyon",
				stok = 180
			});
            return (snf);
		}
        public ActionResult Index5()
        {
            return View();
        }
        public ActionResult VisualizeUrunResult2()
        {
            return Json(UrunListesi2(),JsonRequestBehavior.AllowGet);
        }
        public List<Sinif2> UrunListesi2()
        {
            List<Sinif2> snf= new List<Sinif2>();   
            using(var c = new Context())
            {
                snf = c.Uruns.Select(x => new Sinif2
                {
                    urn = x.UrunAd,
                    stk = x.Stok
                }).ToList();
            }
            return snf;
        }
        public ActionResult Index6()
        {
            return View();
        }
        public ActionResult Index7()
        {
            return View();
        }
    }
}