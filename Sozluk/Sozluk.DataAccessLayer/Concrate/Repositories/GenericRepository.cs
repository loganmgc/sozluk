using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Sozluk.DataAccessLayer.Abstract;

namespace Sozluk.DataAccessLayer.Concrate.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T p)
        {
            _context.Set<T>().Remove(p);
            _context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            _context.Set<T>().Add(p);
            _context.SaveChanges();
        }

        public List<T> List()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Update(T p)
        {
            _context.Set<T>().Update(p);
            _context.SaveChanges();
        }
    }
}
