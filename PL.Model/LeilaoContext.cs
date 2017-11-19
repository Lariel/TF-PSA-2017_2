using PL.Model.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model
{
    public class LeilaoContext : DbContext
    {
        public LeilaoContext() : base("LeilaoContext")
        {
        }
        public DbSet<Bem> Bens { get; set; }
        public DbSet<Lance> Lances { get; set; }
        public DbSet<Leilao> Leiloes { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
