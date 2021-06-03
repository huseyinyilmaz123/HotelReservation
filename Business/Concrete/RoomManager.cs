using Business.Abstract;
using DataAccess.Abstract;
using System.Linq.Expressions;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RoomManager : IRoomService
    {
        IRoomDal _roomDal;
        public RoomManager(IRoomDal roomDal)
        {
            _roomDal=roomDal;
        }


        public Room Get(int roomNo)
        {
            return _roomDal.Get(p=>p.RoomNo==roomNo);
        }

        public List<Room> GetAll()
        {
            return _roomDal.GetAll();
        }

    }
}
