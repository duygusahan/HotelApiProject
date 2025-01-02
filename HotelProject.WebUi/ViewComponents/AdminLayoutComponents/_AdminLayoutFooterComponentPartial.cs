using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUi.ViewComponents.AdminLayoutComponents
{
	public class _AdminLayoutFooterComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
