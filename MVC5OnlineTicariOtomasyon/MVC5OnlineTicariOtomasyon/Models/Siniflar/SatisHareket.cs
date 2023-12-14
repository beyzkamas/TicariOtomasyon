using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5OnlineTicariOtomasyon.Models.Siniflar
{
	public class SatisHareket
	{
		[Key]
		public int Satisid { get; set; }
		//ürün
		//cari
		//personel
		public DateTime Tarih { get; set; }
		public int Adet { get; set; }
		public int Fiyat { get; set; }
		public int ToplamTutar { get; set; }
		public int Urunid { get; set; }
		public int Cariid { get; set; }
		public int Personelid { get; set; }
		public virtual Urun Urun { get; set; }
		public virtual Cariler Cariler { get; set; }
		public virtual Personel Personel { get; set; }
	}
}