using Auction.Business.Abstraction;
using Auction.Business.Dtos;
using Auction.Core.Models;
using Auction.DataAccess.Context;
using Auction.DataAccess.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Business.Concrete
{
    public class VehicleService : IVehicleService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        private readonly ApiResponse _response;

        public VehicleService(IMapper mapper, ApplicationDbContext context, ApiResponse response)
        {
            _mapper = mapper;
            _context = context;
            _response = response;
        }
        public Task<ApiResponse> ChangeVehicleStatus(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> CreateVehicle(CreateVehicleDto model)
        {
            if(model != null)
            {
                var objDto = _mapper.Map<Vehicle>(model);
                if(objDto != null)
                {
                    await _context.Vehicle.AddAsync(objDto);
                }
            }
        }

        public Task<ApiResponse> DeleteVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetVehicleById(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateVehicleResponse(int vehicleId, UpdateVehicleDto model)
        {
            throw new NotImplementedException();
        }
    }
}
