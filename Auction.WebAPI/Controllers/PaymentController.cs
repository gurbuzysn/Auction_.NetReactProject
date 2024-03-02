﻿using Auction.Business.Dtos;
using Auction.Core.Common;
using Auction.Core.Models;
using Auction.DataAccess.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Stripe;

namespace Auction.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ApiResponse _response;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        private readonly StripeSettings _stripeSettings;
        

        public PaymentController(ApiResponse response, IConfiguration configuration, IOptions<StripeSettings> options, ApplicationDbContext context)
        {
            _response = response;
            _configuration = configuration;
            _context = context;
            _stripeSettings = options.Value;
        }

        [HttpPost("Pay")]
        public async Task<ActionResult<ApiResponse>> MakePayment(string userId, int vehicleId)
        {
            StripeConfiguration.ApiKey = _stripeSettings.SecretKey;
            var amountToBePaid = await _context.Vehicle.FirstOrDefaultAsync(x => x.VehicleId == vehicleId);

            var options = new PaymentIntentCreateOptions
            {
                Amount = (int)(amountToBePaid.AuctionPrice * 100),
                Currency = "usd",
                PaymentMethodTypes = new List<string> { "card" }
            };

            var service = new PaymentIntentService();
            var response = service.Create(options);


            CreatePaymentHistoryDto model = new()
            {
                ClientSecret = response.ClientSecret,
                StripePaymentIntentId = response.Id,
                UserId = userId,
                VehicleId = vehicleId
            };

            _response.Result = model;
            _response.StatusCode = System.Net.HttpStatusCode.OK;
            return Ok(_response);

        }
    }
}
