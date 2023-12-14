﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5OnlineTicariOtomasyon.Models.Siniflar
{
	public class KargoDetay
	{
		public int KargoDetayid { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(300)]
		public string Aciklama { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(10)]
		public string TakipKodu { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(20)]
		public string Personel { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(20)]
		public string Alici { get; set; }
		public DateTime Tarih { get; set; }
	}
}