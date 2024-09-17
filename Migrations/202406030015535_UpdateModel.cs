namespace LeSportif.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sportifs",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Identifiant = c.String(nullable: false, maxLength: 50),
                        Nom = c.String(maxLength: 50),
                        Prenom = c.String(maxLength: 50),
                        date_Naissance = c.DateTime(nullable: false),
                        Genre = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.Id, t.Identifiant });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sportifs");
        }
    }
}
