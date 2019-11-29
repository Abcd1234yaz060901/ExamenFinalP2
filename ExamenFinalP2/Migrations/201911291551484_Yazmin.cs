namespace ExamenFinalP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Yazmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Areas", "Estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Visitas", "IDArea", c => c.Int(nullable: false));
            CreateIndex("dbo.Visitas", "IDArea");
            AddForeignKey("dbo.Visitas", "IDArea", "dbo.Areas", "IDArea", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitas", "IDArea", "dbo.Areas");
            DropIndex("dbo.Visitas", new[] { "IDArea" });
            DropColumn("dbo.Visitas", "IDArea");
            DropColumn("dbo.Areas", "Estado");
        }
    }
}
