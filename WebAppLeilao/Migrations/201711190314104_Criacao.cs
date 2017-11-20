namespace PL.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bems",
                c => new
                    {
                        BemId = c.Int(nullable: false, identity: true),
                        DescricaoBreve = c.String(),
                        DescricaoCompleta = c.String(),
                        Categoria = c.String(),
                        Lote_LoteId = c.Int(),
                    })
                .PrimaryKey(t => t.BemId)
                .ForeignKey("dbo.Lotes", t => t.Lote_LoteId)
                .Index(t => t.Lote_LoteId);
            
            CreateTable(
                "dbo.Lances",
                c => new
                    {
                        LanceId = c.Int(nullable: false, identity: true),
                        Momento = c.DateTime(nullable: false),
                        Valor = c.Double(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LanceId);
            
            CreateTable(
                "dbo.Leilaos",
                c => new
                    {
                        LeilaoId = c.Int(nullable: false, identity: true),
                        Natureza = c.String(),
                        Privacidade = c.String(),
                        MomentoInicio = c.DateTime(nullable: false),
                        MomentoFim = c.DateTime(nullable: false),
                        IdUsuarioResponsavel = c.Int(nullable: false),
                        LanceLimite = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.LeilaoId);
            
            CreateTable(
                "dbo.Lotes",
                c => new
                    {
                        LoteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.LoteId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bems", "Lote_LoteId", "dbo.Lotes");
            DropIndex("dbo.Bems", new[] { "Lote_LoteId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Lotes");
            DropTable("dbo.Leilaos");
            DropTable("dbo.Lances");
            DropTable("dbo.Bems");
        }
    }
}
