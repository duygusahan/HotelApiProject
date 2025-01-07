﻿using HotelProject.WebUi.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUi.Controllers
{
	public class StaffController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public StaffController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client=_httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5100/api/Staff");
			if (responseMessage.IsSuccessStatusCode) 
			{
				var jsonData=await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult CreateStaff()
		{
			return View();
		}
		[HttpPost]
		public async Task< IActionResult> CreateStaff(CreateStaffViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData=JsonConvert.SerializeObject(model);
			StringContent stringContent = new StringContent(jsonData , Encoding.UTF8 , "application/json");
			var responseMessage = await client.PostAsync("http://localhost:5100/api/Staff" , stringContent);
			if (responseMessage.IsSuccessStatusCode) 
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
