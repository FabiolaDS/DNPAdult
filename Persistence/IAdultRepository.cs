using System.Collections.Generic;
using Family.Data;

namespace Family.Persistence
{
    interface IAdultRepository
    {
        List<Adult> GetAll();

        void Save(Adult a);

        void Update(Adult a);

        void Delete(int id);

        List<Adult> FindByNameContains(string str);
    }
}