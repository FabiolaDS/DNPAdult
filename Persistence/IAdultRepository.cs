using System.Collections.Generic;
using System.Threading.Tasks;
using Family.Data;

namespace Family.Persistence
{
    public interface IAdultRepository
    {
        Task<List<Adult>> GetAll();

        Task Save(Adult a);

        void Update(Adult a);

        Task Delete(int id);

        Task<List<Adult>> FindByNameContains(string str);
    }
}