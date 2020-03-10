using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Interface
{
    interface IRepository<T, Tkey>
    where Tkey : struct
    where T : IEntity<Tkey>, new()
    {
        IEnumerable<T> GetAll();
        T GetOne(Tkey id);
        T Insert(T toInsert);
        bool Update(T toUpdate);
        bool Delete(Tkey id);
    }

}
