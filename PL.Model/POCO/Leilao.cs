using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model.POCO
{
    public class Leilao
    {
        public int LeilaoId { get; set; }
        public String Natureza { get; set; } //Demanda ou Oferta
        public String Privacidade { get; set; } //Lances abertos ou fechados
        public DateTime MomentoInicio { get; set; }
        public DateTime MomentoFim { get; set; }
        public double LanceLimite { get; set; }
        public int IdUsuarioResponsavel { get; set; }
        public int IdLote { get; set; }
    }
}