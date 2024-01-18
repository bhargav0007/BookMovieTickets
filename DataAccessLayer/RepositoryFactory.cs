using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RepositoryFactory
    {
        private readonly BookMovieTicketDbContext _context;

        public RepositoryFactory(BookMovieTicketDbContext context)
        {
            _context = context;
        }
        public IRepository<T> CreateRepository<T>()
        {
            if (typeof(T) == typeof(User))
            {
                return new UserRepository(_context) as IRepository<T>;
            }
            if (typeof(T) == typeof(Event))
            {
                return new VenuRepository(_context) as IRepository<T>;
            }
            throw new InvalidOperationException();

        }
    }
}
