using BusinessAccessLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class UserService : IUserService
    {
        private readonly RepositoryFactory _repositoryFactory;
        private readonly IRepository<User> _userRepository;
        public UserService(RepositoryFactory repositoryFactory) 
        {
            _repositoryFactory = repositoryFactory;
            _userRepository = _repositoryFactory.CreateRepository<User>();
        } 
        
        public Task<User> Get(long id)
        {
            return _userRepository.Get(id);
        }

        public Task<IEnumerable<User>> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
