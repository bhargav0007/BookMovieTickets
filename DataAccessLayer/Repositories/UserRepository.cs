using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly BookMovieTicketDbContext _context;
        public UserRepository(BookMovieTicketDbContext context)
        {
            _context = context;
        }

        public async Task<User> Get(long id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public Task<IEnumerable<User>> GetByName(long id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
