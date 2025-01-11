using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDtos
{
	public class RoomAddDto
	{
		public string RoomCoverImg { get; set; }
		public int RoomPrice { get; set; }
		public string RoomTitle { get; set; }
		public string RoomBedCount { get; set; }
		public string RoomBathCount { get; set; }
		public string RoomWifi { get; set; }
		public string Description { get; set; }
		public string RoomNumber { get; set; }
	}
}
