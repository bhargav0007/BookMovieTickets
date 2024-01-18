using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class VenuRepository : IRepository<Venu>
    {
        private readonly BookMovieTicketDbContext _context;
        public VenuRepository(BookMovieTicketDbContext context)
        {
            _context = context;
        }

        public Task<Venu> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Venu>> GetAll()
        {
            return await _context.Venus.ToListAsync();
        }

        public async Task<IEnumerable<Venu>> GetByName(long id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
