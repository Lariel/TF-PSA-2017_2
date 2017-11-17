using PL.Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.DAO
{
    interface ILoteDAO
    {
        IEnumerable<Lote> getLotes();
    }
}
