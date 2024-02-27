using Auction.Business.Abstraction;
using Auction.Business.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Auction.WebAPI.Controllers
{
    public class BidController : Controller
    {
        private readonly IBidService _bidService;

        public BidController(IBidService bidService)
        {
            _bidService = bidService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateBid(CreateBidDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _bidService.CreateBid(model);

                if (!response.IsSuccess)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            return BadRequest();
        }


        [HttpGet("bidId:int")]
        public async Task<IActionResult> GetBidById(int bidId)
        {
            var response = await _bidService.GetBidById(bidId);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut("bidId:int")]
        public async Task<IActionResult> ModifyBid(int bidId, UpdateBidDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _bidService.UpdateBid(bidId, model);

                if (!response.IsSuccess)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            return BadRequest();
        }


        [HttpPost]
        public async Task<IActionResult> AutoBid(CreateBidDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _bidService.AutomaticliyCreateBid(model);

                if (!response.IsSuccess)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            return BadRequest();
        }



        [HttpGet("GetBidsByVehicle/{vehicleId:int}")]
        public async Task<IActionResult> GetBidByVehicle(int vehicleId)
        {
            var response = await _bidService.GetBidByVehicleId(vehicleId);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }





    }
}
