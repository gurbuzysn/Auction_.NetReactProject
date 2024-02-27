using Auction.Business.Abstraction;
using Auction.Business.Dtos;
using Auction.Core.Models;
using Auction.DataAccess.Context;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Business.Concrete
{
    public class BidService : IBidService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ApiResponse _response;

        public BidService(ApplicationDbContext context, IMapper mapper, ApiResponse response)
        {
            _context = context;
            _mapper = mapper;
            _response = response;
        }
        public Task<ApiResponse> AutomaticliyCreateBid(CreateBidDto model)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CancelBid(int bidId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateBid(CreateBidDto model)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetBidById(int bidId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetBidByVehicleId(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateBid(int bidId, UpdateBidDto model)
        {
            throw new NotImplementedException();
        }
    }
}
