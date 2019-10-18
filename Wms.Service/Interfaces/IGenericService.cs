using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wms.Service.Interfaces
{
    public interface IGenericService<T>
    {
        Task<IEnumerable<T>> Get();

        Task<T> GetById(int id);

        Task Create(T model);

        Task Update(T model);

        Task Delete(T model);
    }
}