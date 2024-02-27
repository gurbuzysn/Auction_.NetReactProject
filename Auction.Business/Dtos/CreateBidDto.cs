using Auction.DataAccess.Domain;
using Auction.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Business.Dtos
{
    public class CreateBidDto
    {
        public decimal BidAmount { get; set; }
        public DateTime BidDate { get; set; }
        public string BidStatus { get; set; }
        public string UserId { get; set; }
        public string VehicleId { get; set; }
    }
}
