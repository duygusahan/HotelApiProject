using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _roomService;

		public RoomController(IRoomService roomService)
		{
			_roomService = roomService;
		}

		[HttpGet]
		public IActionResult RoomList()
		{
			var value = _roomService.TGetListAll();
			return Ok(value);
		}
		[HttpPost]
		public IActionResult AddRoom(Room room)
		{
			_roomService.TInsert(room);
			return Ok("Ekleme işleminiz başarıyla gerçekleşti");
		}
		[HttpDelete]
		public IActionResult DeleteRoom(int id)
		{
			_roomService.TDelete(id);
			return Ok("Silme işleminiz başarıyla gerçekleşti");
		}
		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_roomService.TUpdate(room);
			return Ok("Güncelleme işleminiz başarıyla gerçekleşmiştir");
		}
		[HttpGet("{id}")]
		public IActionResult GetRoom(int id)
		{
			var value=_roomService.TGetById(id);
			return Ok(value);
		}
	}
}