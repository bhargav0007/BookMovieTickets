using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Interface
{
    public interface IVenuService
    {

        Task<Venu> Get(long id);

        Task<IEnumerable<Venu>> GetAll();

        Task<IEnumerable<Venu>> GetByName(long id, string value);

        Task<IEnumerable<string>> GetAllLocations();
    }
}
