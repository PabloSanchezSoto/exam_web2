namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatetableInventarios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        CantMinima = c.Int(nullable: false),
                        CantMaxima = c.Int(nullable: false),
                        Gravado = c.Boolean(nullable: false),
                        Productos_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Productoes", t => t.Productos_id)
                .Index(t => t.Productos_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventarios", "Productos_id", "dbo.Productoes");
            DropIndex("dbo.Inventarios", new[] { "Productos_id" });
            DropTable("dbo.Inventarios");
        }
    }
}
