using DealDouble.Entities;
using DealDouble.Services;
using DealDouble.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Controllers
{
    public class AuctionsController : Controller
    {
        AuctionsService service = new AuctionsService();

        [HttpGet]
        public ActionResult Index()
        {

            AuctionsListingViewModel model = new AuctionsListingViewModel();

            model.PageTitle = "Auctions";
            model.PageDescription = "Auction Listing Page";



            model.Auctions = service.GetAllAuctions();

            if(Request.IsAjaxRequest())
            {
                return PartialView(model);
            }
            else
            {
                return View(model);
            }
        }


        [HttpGet]
        public ActionResult Create()
        {
           return PartialView();
        }


        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            
            service.SaveAuction(auction);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Edit(int ID)
        {

            

            var auction = service.GetAuctionByID(ID);

             return PartialView(auction);
        }

        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            
            service.UpdateAuction(auction);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {

            

            var auction = service.GetAuctionByID(ID);

            return View(auction);
        }

        [HttpPost]
        public ActionResult Delete(Auction auction)
        {
           
            service.DeleteAuction(auction);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int ID)
        {

           

            var auction = service.GetAuctionByID(ID);

            return View(auction);
        }
    }
}