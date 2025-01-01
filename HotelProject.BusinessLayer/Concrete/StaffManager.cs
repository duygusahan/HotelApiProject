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
	public class StaffManager : IStaffService
	{
		private readonly IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public void TDelete(int id)
		{
			_staffDal.Delete(id);
		}

		public Staff TGetById(int id)
		{
			return _staffDal.GetById(id);
		}

		public List<Staff> TGetListAll()
		{
			return _staffDal.GetListAll();
		}

		public void TInsert(Staff entity)
		{
			_staffDal.Insert(entity);
		}

		public void TUpdate(Staff entity)
		{
			_staffDal.Update(entity);
		}
	}
}
