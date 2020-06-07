namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class auctions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AuctionPictures", "AuctionID", "dbo.Auctions");
            DropIndex("dbo.AuctionPictures", new[] { "AuctionID" });
            AddColumn("dbo.AuctionPictures", "Auctions_ID", c => c.Int());
            CreateIndex("dbo.AuctionPictures", "Auctions_ID");
            AddForeignKey("dbo.AuctionPictures", "Auctions_ID", "dbo.Auctions", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AuctionPictures", "Auctions_ID", "dbo.Auctions");
            DropIndex("dbo.AuctionPictures", new[] { "Auctions_ID" });
            DropColumn("dbo.AuctionPictures", "Auctions_ID");
            CreateIndex("dbo.AuctionPictures", "AuctionID");
            AddForeignKey("dbo.AuctionPictures", "AuctionID", "dbo.Auctions", "ID", cascadeDelete: true);
        }
    }
}
