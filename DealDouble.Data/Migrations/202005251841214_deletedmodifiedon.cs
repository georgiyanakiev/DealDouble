namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedmodifiedon : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Auctions", "ModifiedOn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auctions", "ModifiedOn", c => c.DateTime(nullable: false));
        }
    }
}
