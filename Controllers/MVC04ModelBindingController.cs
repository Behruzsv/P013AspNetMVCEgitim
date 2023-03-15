using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
	public class MVC04ModelBindingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult KullaniciDetay()
		{
			Kullanici kullanici = new();
			kullanici.KullaniciAdi = "Admin";
			kullanici.Ad = "Murat";
            kullanici.Soyad = "Yılmaz";
            kullanici.Sifre = "123";
            kullanici.Email = "Murat@yilmaz.co";
            return View(kullanici); // View içerisinde model datası olarak kullanıcı nesnesini sayfaya gönderdik
		}
		[HttpPost]
		public IActionResult KullaniciDetay(Kullanici kullanici) // post metodunda modelden gelen nesneyi bu şekilde parantez içinde yakalayabiliyoruz
		{
			return View(kullanici); // gelen kullanıcı nesnesini tekrardan ekrana yolla
		}
		public IActionResult AdresDetay()
		{
			Adres adres = new()
			{
				Sehir = "Çankırı", Ilce = "Çerkeş", AcikAdres = "1907 sk. Mo : 21 A"
			};
			return View(adres);
		}
		public IActionResult UyeSayfasi()
		{
			return View();
		}
	}
}
