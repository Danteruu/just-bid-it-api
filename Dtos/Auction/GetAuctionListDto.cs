using System;
using just_bid_it.Models;

namespace just_bid_it.Dtos.Auction
{
    public class GetAuctionListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public double StartPrice { get; set; }
        public double FinalPrice { get; set; }
        public DateTime AuctionStart { get; set; }
        public DateTime AuctionFinish { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public FuelType Fuel { get; set; }
        public DriveType Drive { get; set; }
        public TransmissionType Transmission { get; set; }
        public bool IsBroken { get; set; }
    }
}