using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Model.POCO;


namespace PL.Model
{
    interface IBemDAO : IDisposable
    {
        IEnumerable<Bem> getBens();
        Bem GetBemById(int id);
        Boolean Add(Bem b);
        void Delete(int id);
    }
}
