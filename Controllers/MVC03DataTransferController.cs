﻿using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.Controllers
{
	public class MVC03DataTransferController : Controller
	{
		public IActionResult Index(string Ara) // get metoduyla 
		{
			// Mvc de temel olarak 3 farklı yöntemle ekrana veri gönderebiliriz

			// 1-ViewBag : Tek kullanımlık ömrü var
			ViewBag.UrunKategorisi = "Bilgisayar";
			// 2-ViewData : Tek kullanımlık ömrü var
			ViewData["ÜrünAdi"] = "Asus Dizüstü Bilgisayar";
			// 3-TempData : İki kullanımlık ömrü var
			TempData["UrunFiyatı"] = 9999;

			ViewBag.GetVerisi = Ara;

			return View();
		}
		[HttpPost] //aşağıdaki metod post işleminde çalışsın
		public IActionResult Index (string text1, string ddlListe, bool cbOnay, IFormCollection formCollection)
		{
			ViewBag.Yontem1 = "1. Yöntem(Parametrelerden gelen veriler)";
			ViewBag.Mesaj = "Textbox dan gelen veri : " + text1;
			ViewData["MesajListe"] = "ddlListe dan gelen veri : " + ddlListe;
			TempData["Tdata"] = "cbOnay dan gelen değer : " + cbOnay;

			ViewBag.Yontem2 = "2. Yöntem(IFormCollection)";
			ViewBag.Mesaj2 = "Textbox dan gelen veri : " + formCollection ["text1"];
			ViewData["MesajListe2"] = "ddlListe dan gelen veri : " + formCollection["ddlListe"];
			TempData["Tdata2"] = "cbOnay dan gelen değer : " + formCollection["cbOnay"][0];

			ViewBag.Yontem3 = "3. Yöntem(RequestForm)";
			ViewBag.Mesaj3 = "Textbox dan gelen veri : " + Request.Form["text1"];
			ViewData["MesajListe3"] = "ddlListe dan gelen veri : " + Request.Form["ddlListe"];
			TempData["Tdata3"] = "cbOnay dan gelen değer : " + Request.Form["cbOnay"][0];

			return View();
		}
	}
}
