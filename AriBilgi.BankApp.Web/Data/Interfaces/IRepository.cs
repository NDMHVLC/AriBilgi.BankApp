using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AriBilgi.BankApp.Web.Data.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        List<T> GetAll();

        List<T> GetAll(Expression<Func<T, bool>> expression);

        T GetById(object id);

        void Create(T entity);

        void Remove(T entity);

        void Update(T entity);


    }
}
