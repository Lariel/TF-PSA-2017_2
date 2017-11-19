using PL.Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model
{
    interface ILoteDAO : IDisposable
    {
        IEnumerable<Lote> getLotes();
        Lote GetLoteById(int id);
        Boolean Add(Lote l);
        void Delete(int id);
    }
}
