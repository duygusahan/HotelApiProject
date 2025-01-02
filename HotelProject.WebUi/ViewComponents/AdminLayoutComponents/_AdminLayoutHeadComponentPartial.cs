using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUi.ViewComponents.AdminLayoutComponents
{
	public class _AdminLayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
