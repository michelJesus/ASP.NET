namespace WebApplicationAvaliacao24032015.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        IsAtivo = c.Boolean(nullable: false),
                        Nome = c.String(),
                        Cliente_ClienteID = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteID)
                .Index(t => t.Cliente_ClienteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "Cliente_ClienteID", "dbo.Clientes");
            DropIndex("dbo.Clientes", new[] { "Cliente_ClienteID" });
            DropTable("dbo.Clientes");
        }
    }
}
