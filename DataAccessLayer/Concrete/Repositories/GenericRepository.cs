using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
            //_object.Remove(p);          
        }

        public T Get(Expression<Func<T, bool>> Filterle)
        {
            return _object.SingleOrDefault(Filterle);
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;

            c.SaveChanges();
            //_object.Add(p);
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> Filterle)
        {
            return _object.Where(Filterle).ToList();
        }

        public void Update(T p)
        {
            var updated = c.Entry(p);
            updated.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
