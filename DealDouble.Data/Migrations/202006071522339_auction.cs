namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class auction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AuctionPictures", "Auctions_ID", "dbo.Auctions");
            DropIndex("dbo.AuctionPictures", new[] { "Auctions_ID" });
            DropColumn("dbo.AuctionPictures", "AuctionID");
            RenameColumn(table: "dbo.AuctionPictures", name: "Auctions_ID", newName: "AuctionID");
            AlterColumn("dbo.AuctionPictures", "AuctionID", c => c.Int(nullable: false));
            CreateIndex("dbo.AuctionPictures", "AuctionID");
            AddForeignKey("dbo.AuctionPictures", "AuctionID", "dbo.Auctions", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AuctionPictures", "AuctionID", "dbo.Auctions");
            DropIndex("dbo.AuctionPictures", new[] { "AuctionID" });
            AlterColumn("dbo.AuctionPictures", "AuctionID", c => c.Int());
            RenameColumn(table: "dbo.AuctionPictures", name: "AuctionID", newName: "Auctions_ID");
            AddColumn("dbo.AuctionPictures", "AuctionID", c => c.Int(nullable: false));
            CreateIndex("dbo.AuctionPictures", "Auctions_ID");
            AddForeignKey("dbo.AuctionPictures", "Auctions_ID", "dbo.Auctions", "ID");
        }
    }
}
