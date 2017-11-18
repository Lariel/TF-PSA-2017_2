using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model.POCO
{
    public class Lance
    {
        public int LanceId { get; set; }
        public DateTime Momento { get; set; }
        public double Valor { get; set; }
        public int IdUsuario { get; set; }
    }
}
