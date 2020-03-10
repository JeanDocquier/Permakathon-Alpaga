using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermaFungi.DAL.Interface
{
    public interface IEntity<Tkey> where Tkey : struct
    {
        Tkey Id { get; }
    }

}
