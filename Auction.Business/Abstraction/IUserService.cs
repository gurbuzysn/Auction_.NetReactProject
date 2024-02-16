using Auction.Business.Dtos;
using Auction.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Business.Abstraction
{
    public interface IUserService
    {
        Task<ApiResponse> Register(RegisterRequestDto model);
        Task<ApiResponse> Login(LoginRequestDto model);
    }
}
