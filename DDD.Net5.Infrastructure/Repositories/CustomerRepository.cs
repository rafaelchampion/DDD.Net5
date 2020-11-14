using DDD.Net5.Domain.Entities;
using DDD.Net5.Infrastructure.Interfaces;
using System;
using System.Linq;

namespace DDD.Net5.Infrastructure.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        public Customer Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Find(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> FindAll(Func<IQueryable<Customer>> predicate)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
