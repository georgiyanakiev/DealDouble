using DealDouble.Entities;
using DealDouble.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealDouble.ViewModels
{
    public class AuctionsListingViewModel : PageViewModel
    {

        public List<Auction> Auctions { get; set; }
    }
    public class AuctionsViewModel : PageViewModel
    {
        public List<Auction> AllAuctions { get; set; }
        public List<Auction> PromotedAuctions { get; set; }
    }

    public class AuctionsDetailsViewModel : PageViewModel
    {

        public Auction Auctions { get; set; }
    }

    public class CreateAuctionViewModel : PageViewModel
    {
        public int CategoryID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public string AuctionPictures { get; set; }

        public List<Category> Categories { get; set; }

    }
}