namespace LeSportif.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateInscription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sportifs", "Email", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sportifs", "Email");
        }
    }
}
