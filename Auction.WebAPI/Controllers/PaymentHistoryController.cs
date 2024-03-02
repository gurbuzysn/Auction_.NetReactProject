using Auction.Business.Abstraction;
using Auction.Business.Dtos;
using Auction.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentHistoryController : ControllerBase
    {
        private readonly IPaymentHistoryService _paymentHistoryService;

        public PaymentHistoryController(IPaymentHistoryService paymentHistoryService)
        {
            _paymentHistoryService = paymentHistoryService;
        }

        [HttpPost("AddHistory")]
        public async Task<ActionResult> CreatePaymentHistory(CreatePaymentHistoryDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _paymentHistoryService.CreatePaymentHistory(model);
                if (!response.IsSuccess)
                {
                    return BadRequest(response);
                }
                return Ok(response);  
            }
            return BadRequest();
        }




        [HttpPost("CheckStatus")]

        public async Task<ActionResult> CheckStatusAuction(CheckStatusModel model)
        {
            var response = await _paymentHistoryService.CheckIsStatusForAuction(model.UserId, model.VehicleId);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }



    }
}
