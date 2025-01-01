using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		private readonly IStaffService _staffService;

		public StaffController(IStaffService staffService)
		{
			_staffService = staffService;
		}

		[HttpGet]
		public IActionResult StaffList()
		{
			var values=_staffService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddStaff(Staff staff)
		{
			_staffService.TUpdate(staff);
			return Ok("Ekleme İşleminiz Gerçekleşti");
		}
		[HttpDelete]
		public IActionResult DeleteStaff(int id)
		{
			_staffService.TDelete(id);
			return Ok("Silme işleminiz başarıyla gerçekleşti");
		}
		[HttpPut]
		public IActionResult UpdateStaff(Staff staff)
		{
			_staffService.TUpdate(staff);
			return Ok("Güncelleme işlemi başarıyla gerçekleşti");
		}
		[HttpGet("{id}")]
		public IActionResult GetStaff(int id)
		{
			var value=_staffService.TGetById(id);
			return Ok(value);
		}
	}
}
