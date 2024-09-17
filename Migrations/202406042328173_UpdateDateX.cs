namespace LeSportif.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateX : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sportifs", "date_Naissance", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sportifs", "date_Naissance", c => c.DateTime(nullable: false));
        }
    }
}
