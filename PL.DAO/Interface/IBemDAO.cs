using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Model.POCO;


namespace PL.DAO
{
    interface IBemDAO
    {
        IEnumerable<Bem> getBens();


    }
}
