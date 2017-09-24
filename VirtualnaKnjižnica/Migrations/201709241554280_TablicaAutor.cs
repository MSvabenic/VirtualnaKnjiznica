namespace VirtualnaKnjižnica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablicaAutor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        AutorId = c.Byte(nullable: false, identity: true),
                        AutorIme = c.String(),
                        AutorPrezime = c.String(),
                    })
                .PrimaryKey(t => t.AutorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Autor");
        }
    }
}
