using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model.POCO
{
    public class Bem
    {
        public int BemId { get; set; }
        public string DescricaoBreve { get; set; }
        public string DescricaoCompleta { get; set; }
        public string Categoria { get; set; }
    }
}
