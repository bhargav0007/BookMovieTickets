using BusinessAccessLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class VenuService : IVenuService
    {

        private readonly RepositoryFactory _repositoryFactory;
        private readonly IRepository<Venu> _venuRepository;
        public VenuService(RepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
            _venuRepository = _repositoryFactory.CreateRepository<Venu>();
        }
        public Task<Venu> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Venu>> GetAll()
        {
            var result = await _venuRepository.GetAll();
            return result;
        }

        public async Task<IEnumerable<string>> GetAllLocations()
        {
            var locations = await GetAll();

            var result = locations.Select(x => x.LocationName).ToList();
            return (IEnumerable<string>)result;
        }

        public Task<IEnumerable<Venu>> GetByName(long id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
