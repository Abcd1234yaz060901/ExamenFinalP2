namespace ExamenFinalP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ya : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        IDArea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IDArea);
            
            CreateTable(
                "dbo.Visitas",
                c => new
                    {
                        IDVisitas = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        MotivoVisita = c.String(),
                        HoraEntrada = c.DateTime(nullable: false),
                        HoraSalida = c.DateTime(nullable: false),
                        IDVisitante = c.Int(nullable: false),
                        IDArea = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IDVisitas)
                .ForeignKey("dbo.Areas", t => t.IDArea, cascadeDelete: true)
                .ForeignKey("dbo.Visitantes", t => t.IDVisitante, cascadeDelete: true)
                .Index(t => t.IDVisitante)
                .Index(t => t.IDArea);
            
            CreateTable(
                "dbo.Visitantes",
                c => new
                    {
                        IDVisitante = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Cedula = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.IDVisitante);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitas", "IDVisitante", "dbo.Visitantes");
            DropForeignKey("dbo.Visitas", "IDArea", "dbo.Areas");
            DropIndex("dbo.Visitas", new[] { "IDArea" });
            DropIndex("dbo.Visitas", new[] { "IDVisitante" });
            DropTable("dbo.Visitantes");
            DropTable("dbo.Visitas");
            DropTable("dbo.Areas");
        }
    }
}
