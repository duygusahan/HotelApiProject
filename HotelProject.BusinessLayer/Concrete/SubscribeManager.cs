using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeDal _subscribeDal;

		public SubscribeManager(ISubscribeDal subscribeDal)
		{
			_subscribeDal = subscribeDal;
		}

		public void TDelete(int id)
		{
			_subscribeDal.Delete(id);
		}

		public Subscribe TGetById(int id)
		{
			return _subscribeDal.GetById(id);	
		}

		public List<Subscribe> TGetListAll()
		{
			return _subscribeDal.GetListAll();
		}

		public void TInsert(Subscribe entity)
		{
			_subscribeDal.Insert(entity);
		}

		public void TUpdate(Subscribe entity)
		{
			_subscribeDal.Update(entity);
		}
	}
}
