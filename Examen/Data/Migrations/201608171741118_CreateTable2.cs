namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cedula = c.String(),
                        nombre = c.String(),
                        apellido = c.String(),
                        FechaNacid = c.DateTime(nullable: false),
                        direccion = c.String(),
                        estadoCivil = c.String(),
                        sexo = c.String(),
                        FechaIngre = c.DateTime(nullable: false),
                        tipo = c.String(),
                        Descuento = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        marca = c.String(),
                        familia = c.String(),
                        casaFabri = c.String(),
                        Tipo = c.String(),
                        departamento = c.String(),
                        activo = c.Boolean(nullable: false),
                        fechaIngre = c.DateTime(nullable: false),
                        unidad = c.Int(nullable: false),
                        impuesto = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productoes");
            DropTable("dbo.Clientes");
        }
    }
}
