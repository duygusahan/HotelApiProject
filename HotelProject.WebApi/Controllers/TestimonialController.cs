using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}
		[HttpGet]
		public IActionResult TestimonialList()
		{
			var value=_testimonialService.TGetListAll();
			return Ok(value);
		}
		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial) 
		{
			_testimonialService.TInsert(testimonial);
			return Ok("işleminiz başarıyla gerçekleşti");
		}
		[HttpDelete]
		public IActionResult DeleteTestimonial(int id)
		{
			_testimonialService.TDelete(id);
			return Ok("işleminiz başarıyla gerçekleşti");
		}
		[HttpPut]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			_testimonialService.TUpdate(testimonial);
			return Ok("işleminiz başarıyla gerçekleşti");
		}
		[HttpGet("{id}")]
		public IActionResult GetTestimonial(int id) 
		{
			var value=_testimonialService.TGetById(id);
			return Ok(value);
		}

	}
}
