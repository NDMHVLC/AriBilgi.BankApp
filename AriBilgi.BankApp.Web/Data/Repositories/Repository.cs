using AriBilgi.BankApp.Web.Data.Context;
using AriBilgi.BankApp.Web.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AriBilgi.BankApp.Web.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly BankContext _context;
        public Repository(BankContext context)
        {
            _context = context;
        }
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public System.Collections.Generic.List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        List<T> IRepository<T>.GetAll(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

       
    }
}
