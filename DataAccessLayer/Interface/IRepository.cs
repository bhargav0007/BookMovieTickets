using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IRepository<T>
    {
        Task<T> Get(long id);

        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> GetByName(long id, string value);
    }
}
