using Auction.Business.Abstraction;
using Auction.Business.Dtos;
using Auction.Core.Models;
using Auction.DataAccess.Context;
using Auction.DataAccess.Domain;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Business.Concrete
{
    public class PaymentHistoryService : IPaymentHistoryService
    {
        private readonly ApiResponse _response;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PaymentHistoryService(ApiResponse response, ApplicationDbContext context, IMapper mapper)
        {
            _response = response;
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId)
        {
            var response = await _context.PaymentHistories.Where(x => x.UserId == userId && x.VehicleId == vehicleId && x.IsActive == true).FirstOrDefaultAsync();
            
            if(response != null)
            {
                _response.IsSuccess = true;
                _response.Result = response;
                return _response;
            }
            _response.IsSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDto model)
        {
            if (model == null)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("Model is not include some fields");
                return _response;
            }
            else
            {
                var objDto = _mapper.Map<PaymentHistory>(model);
                objDto.PayDate = DateTime.Now;
                objDto.IsActive = true;
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.IsSuccess = true;
                    _response.Result = model;
                    return _response;
                }
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("Ooops! Something went wrong!");
                return _response;
            }
        }
    }
}
