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
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PL.Model.LeilaoContext context)
        {
            var bens = new List<Bem>
            {
                new Bem{ DescricaoBreve = "TV", DescricaoCompleta = "Smarth Tv SamSung", Categoria = "Tech" }
            };
            bens.ForEach(s => context.Bens.AddOrUpdate(e => e.BemId, s));
            context.SaveChanges();

            var lances = new List<Lance>
            {
                new Lance{ IdUsuario = 1, Momento = DateTime.Parse("13/11/2017",new CultureInfo("en-US")),Valor = 1.99}
            };
            lances.ForEach(s => context.Lances.AddOrUpdate(e => e.LanceId, s));
            context.SaveChanges();

            var leiloes = new List<Leilao>
            {
                new Leilao
                {
                    IdUsuarioResponsavel = 7,
                    LanceLimite = 14.95,
                    MomentoInicio = DateTime.Parse("13/11/2017",new CultureInfo("en-US")),
                    MomentoFim = DateTime.Parse("18/11/2017",new CultureInfo("en-US")),
                    Natureza = "Compra",
                    Privacidade = "Aberto"
                }
            };
            leiloes.ForEach(s => context.Leiloes.AddOrUpdate(e => e.LeilaoId, s));
            context.SaveChanges();

            var lotes = new List<Lote>
            {
                new Lote
                {
                    Bens = new List<Bem>
                    {
                        new Bem{ DescricaoBreve = "TV", DescricaoCompleta = "Smarth Tv SamSung", Categoria = "Tech" }
                    }
                }
            };
            lotes.ForEach(s => context.Lotes.AddOrUpdate(e => e.LoteId, s));
            context.SaveChanges();

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
                }
            };
            usuarios.ForEach(s => context.Usuarios.AddOrUpdate(e => e.UsuarioId, s));
            context.SaveChanges();
        }
    }
}
