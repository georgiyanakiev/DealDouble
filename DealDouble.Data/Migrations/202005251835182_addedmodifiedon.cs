namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmodifiedon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auctions", "ModifiedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auctions", "ModifiedOn");
        }
    }
}
