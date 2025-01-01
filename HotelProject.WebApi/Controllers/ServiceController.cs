using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IServiceService _serviceService;

		public ServiceController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		[HttpGet]
		public IActionResult ServiceList()
		{
			var value=_serviceService.TGetListAll();
			return Ok(value);
		}
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			_serviceService.TInsert(service);
			return Ok("Ekleme işleminiz başarıyla gerçekleşmiştir");
		}
		[HttpDelete]
		public IActionResult DeleteService(int id)
		{
			_serviceService.TDelete(id);
			return Ok("Silme işleminiz başarıyla gerçekleşti");
		}
		[HttpPut]
		public IActionResult UpdateService(Service service) 
		{
			_serviceService.TUpdate(service);
			return Ok("Güncelleme işleminiz başarıyla gerçekleşti");
		}
		[HttpGet("{id}")]
		public IActionResult GetService(int id)
		{
			var value=_serviceService.TGetById(id);	
			return Ok(value);
		}
	}
}
