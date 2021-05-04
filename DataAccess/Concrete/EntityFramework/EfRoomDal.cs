using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRoomDal : IRoomDal
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(Room customer)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll(Expression<Func<Room, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Room customer)
        {
            throw new NotImplementedException();
        }
    }
}
