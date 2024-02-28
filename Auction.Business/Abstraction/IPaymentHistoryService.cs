using Auction.Business.Dtos;
using Auction.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Business.Abstraction
{
    public interface IPaymentHistoryService
    {
        Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDto model);
        Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId);

    }
}
