using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace xceedTask.Controllers
{
	public class DashboardController : Controller
	{
		[Authorize]
		public IActionResult Index()
		{
			return View();
		}
	}
}
