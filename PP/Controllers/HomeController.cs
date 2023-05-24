using Microsoft.AspNetCore.Mvc;

namespace PP.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(){
			ViewBag.Name = "Ali";
			ViewBag.Surname = "Aliyev";
			ViewBag.Age = 25;
			ViewData["Country"] = "Azerbaijan";
			ViewData["Number"] = "+994551234567";
			return View();
		}
	}
}
