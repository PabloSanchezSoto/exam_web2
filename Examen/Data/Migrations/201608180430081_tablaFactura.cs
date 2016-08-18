namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablaFactura : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Inventarios", "Productos_id", "dbo.Productoes");
            DropIndex("dbo.Inventarios", new[] { "Productos_id" });
            AddColumn("dbo.Productoes", "ProductoId", c => c.Int(nullable: false));
            AddColumn("dbo.Productoes", "Inventario_id", c => c.Int());
            CreateIndex("dbo.Productoes", "ProductoId");
            CreateIndex("dbo.Productoes", "Inventario_id");
            AddForeignKey("dbo.Productoes", "ProductoId", "dbo.Productoes", "id");
            AddForeignKey("dbo.Productoes", "Inventario_id", "dbo.Inventarios", "id");
            DropColumn("dbo.Inventarios", "Productos_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inventarios", "Productos_id", c => c.Int());
            DropForeignKey("dbo.Productoes", "Inventario_id", "dbo.Inventarios");
            DropForeignKey("dbo.Productoes", "ProductoId", "dbo.Productoes");
            DropIndex("dbo.Productoes", new[] { "Inventario_id" });
            DropIndex("dbo.Productoes", new[] { "ProductoId" });
            DropColumn("dbo.Productoes", "Inventario_id");
            DropColumn("dbo.Productoes", "ProductoId");
            CreateIndex("dbo.Inventarios", "Productos_id");
            AddForeignKey("dbo.Inventarios", "Productos_id", "dbo.Productoes", "id");
        }
    }
}
