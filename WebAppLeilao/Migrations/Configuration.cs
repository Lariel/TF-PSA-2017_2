namespace PL.Model.Migrations
{
    using System;
    using System.Globalization;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PL.Model.POCO;

    internal sealed class Configuration : DbMigrationsConfiguration<PL.Model.LeilaoContext>
    {
        public Configuration() => AutomaticMigrationsEnabled = true;

        protected override void Seed(PL.Model.LeilaoContext context)
        {
            var usuarios = new List<Usuario>
            {
                new Usuario
                {
                    Nome = "Lariel",
                    Senha = "teste123",
                    Email = "lariel.negreiros@gmail.com"
                },

                new Usuario
                {
                    Nome = "Carlos",
                    Senha = "teste456",
                    Email = "carlos.silva.009@acad.pucrs.br"
                },

                new Usuario
                {
                    Nome = "Guilherme",
                    Senha = "teste789",
                    Email = "guilherme.dohms@acad.pucrs.br"
                }
            };
            usuarios.ForEach(s => context.Usuarios.AddOrUpdate(e => e.UsuarioId, s));
            context.SaveChanges();

            var bens = new List<Bem>
            {
                new Bem{ DescricaoBreve = "TV", DescricaoCompleta = "Smarth Tv SamSung", Categoria = "Tech" },
                new Bem{ DescricaoBreve = "Smartphone Galaxy", DescricaoCompleta = "Smartphone Samsung Galaxy S8 Dual Chip Android 7.0 Tela 5.8 Octa-Core 2.3GHz 64GB 4G Câmera 12MP - Preto", Categoria = "Tech" }
            };
            bens.ForEach(s => context.Bens.AddOrUpdate(e => e.BemId, s));
            context.SaveChanges();

            var lotes = new List<Lote>
            {
            };
            lotes.ForEach(s => context.Lotes.AddOrUpdate(e => e.LoteId, s));
            context.SaveChanges();

            var lances = new List<Lance>
            {
                //new Lance{ IdUsuario = 1, Momento = DateTime.Parse("13/11/2017",new CultureInfo("en-US")),Valor = 1.99}
            };
            lances.ForEach(s => context.Lances.AddOrUpdate(e => e.LanceId, s));
            context.SaveChanges();

            var leiloes = new List<Leilao>
            {
            };
            leiloes.ForEach(s => context.Leiloes.AddOrUpdate(e => e.LeilaoId, s));
            context.SaveChanges();
        }
    }
}
