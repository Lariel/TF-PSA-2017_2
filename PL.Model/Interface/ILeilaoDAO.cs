using PL.Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model
{
    interface ILeilaoDAO : IDisposable
    {
        IEnumerable<Leilao> getLeiloes();
        Leilao GetLeilaoById(int id);
        Boolean Add(Leilao l);
        void Delete(int id);
    }
}
