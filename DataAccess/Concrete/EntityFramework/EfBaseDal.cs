using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBaseDal<TEntity> where TEntity:class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            using (HotelContext context = new HotelContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (HotelContext context = new HotelContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (HotelContext context = new HotelContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (HotelContext context = new HotelContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (HotelContext context = new HotelContext())
            {
                TEntity entity = context.Set<TEntity>().SingleOrDefault(filter);
                return entity;
            }
        }
    }
}
