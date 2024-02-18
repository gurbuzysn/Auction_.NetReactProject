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
        public async Task<ApiResponse> ChangeVehicleStatus(int vehicleId)
        {
            var result = await _context.Vehicle.FindAsync(vehicleId);
            if(result == null)
            {
                _response.IsSuccess = false;
                return _response;
            }
            result.IsActive = false;
            _response.IsSuccess = true;
            await _context.SaveChangesAsync();
            return _response;
        }

        public async Task<ApiResponse> CreateVehicle(CreateVehicleDto model)
        {
            if (model != null)
            {
                var objDto = _mapper.Map<Vehicle>(model);
                if (objDto != null)
                {
                    _context.Vehicle.Add(objDto);

                    if (await _context.SaveChangesAsync() > 0)
                    {
                        _response.IsSuccess = true;
                        _response.Result = model;
                        _response.StatusCode = System.Net.HttpStatusCode.Created;
                        return _response;


                    }
                }
            }
            _response.ErrorMessages.Add("Ooops! Something went wrong");
            _response.IsSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> DeleteVehicle(int vehicleId)
        {
            var vehicle = await _context.Vehicle.FindAsync(vehicleId);
            if(vehicle != null)
            {
                _context.Vehicle.Remove(vehicle);
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.IsSuccess = true;
                    return _response;
                }
            }
            _response.IsSuccess= false;
            return _response;
        }

        public async Task<ApiResponse> GetVehicleById(int vehicleId)
        {
            var result = await _context.Vehicle.Include(x => x.Seller).FirstOrDefaultAsync(x => x.VehicleId == vehicleId);
            if (result != null)
            {
                _response.Result = result;
                _response.IsSuccess = true;
                return _response;
            }
            _response.IsSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> GetVehicles()
        {
            var vehicle = await _context.Vehicle.Include(x => x.Seller).ToListAsync();
            if (vehicle != null)
            {
                _response.IsSuccess = true;
                _response.Result = vehicle;
                return _response;
            }
            _response.IsSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> UpdateVehicleResponse(int vehicleId, UpdateVehicleDto model)
        {
            var result = await _context.Vehicle.FindAsync(vehicleId);
            if (result != null)
            {
                Vehicle objDto = _mapper.Map(model, result);
                if(await _context.SaveChangesAsync() > 0)
                {
                    _response.Result = objDto;
                    _response.IsSuccess=true;
                    return _response;
                }
            }
            _response.IsSuccess = false;
            return _response;
        }
    }
}
