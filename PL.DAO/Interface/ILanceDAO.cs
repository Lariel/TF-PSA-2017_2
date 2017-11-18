using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Model.POCO;

namespace PL.DAO
{
    interface ILanceDAO
    {
        IEnumerable<Lance> getLances();
        Lance GetLanceById(int id);
        Boolean Add(Lance l);
        void Delete(int id);
    }
}
