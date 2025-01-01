﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribeController : ControllerBase
	{
		private readonly ISubscribeService _subscribeService;

		public SubscribeController(ISubscribeService subscribeService)
		{
			_subscribeService = subscribeService;
		}

		[HttpGet]
		public IActionResult SubscribeList()
		{
			var value=_subscribeService.TGetListAll();
			return Ok(value);
		}
		[HttpPost]
		public IActionResult AddSubscribe(Subscribe subscribe)
		{
			_subscribeService.TInsert(subscribe);
			return Ok("işleminiz başarıyla gerçekleşti");
		}
		[HttpDelete]
		public IActionResult DeleteSubscribe(int id) 
		{
			_subscribeService.TDelete(id);
			return Ok("işleminiz başarıyla gerçekleşti");
		}
		[HttpPut]
		public IActionResult UpdateSubscribe(Subscribe subscribe)
		{
			_subscribeService.TUpdate(subscribe);
			return Ok("işleminiz başarıyla gerçekleşti");
		}
		[HttpGet("{id}")]
		public IActionResult GetSubscribe(int id) 
		{
			var value=_subscribeService.TGetById(id);
			return Ok(value);
		}
	}
}
