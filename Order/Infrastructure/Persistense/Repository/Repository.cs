using Application.Interfaces.Repositories;
using Domain.Model;
using Infrastructura.Persistense.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructura.Persistense.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DbSet<TEntity> _set;
        private readonly Context _context;
        
        public Repository(Context context)
        {
            _set = context.Set<TEntity>();
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _set.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _set.Remove(entity);
        }

        public TEntity FindById(int id)
        {
            TEntity? foundEntity = _set.Find(id);
            if (foundEntity == null) throw new ArgumentNullException(nameof(foundEntity));
            return foundEntity;
        }


        public IQueryable<TEntity> GetAll(int pageList, int pageNumber)
        {
            return _set.Skip<TEntity>(pageList * pageNumber).Take<TEntity>(pageList);
        }

        public int SaveChanges() => _context.SaveChanges();


        public void Update(TEntity entity)
        {
            _set.Update(entity);
        }
    }
}
