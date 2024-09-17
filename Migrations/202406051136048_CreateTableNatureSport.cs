namespace LeSportif.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableNatureSport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NatureSport",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Intitule = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NatureSport");
        }
    }
}
