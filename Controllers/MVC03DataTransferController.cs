using Microsoft.AspNetCore.Mvc;

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
		public IActionResult Index (string text1, string ddlListe, bool cbOnay)
		{
			ViewBag.BirinciYontem = "1. Yöntem(Parametrelerden gelen veriler)";
			ViewBag.Mesaj = "Textbox dan gelen veri : " + text1;
			ViewBag.MesajListe = "ddlListe dan gelen veri : " + ddlListe;
			TempData["Tdata"] = "cbOnay dan gelen değer : " + cbOnay;

			return View();
		}
	}
}
