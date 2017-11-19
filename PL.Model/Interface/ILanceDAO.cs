using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Model.POCO;

namespace PL.Model
{
    interface ILanceDAO : IDisposable
    {
        IEnumerable<Lance> getLances();
        Lance GetLanceById(int id);
        Boolean Add(Lance l);
        void Delete(int id);
    }
}
