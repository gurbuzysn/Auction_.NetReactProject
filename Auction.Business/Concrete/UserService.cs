using Auction.Business.Abstraction;
using Auction.Business.Dtos;
using Auction.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Business.Concrete
{
    public class UserService : IUserService
    {
        public Task<ApiResponse> Login(LoginRequestDto model)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> Register(RegisterRequestDto model)
        {
            throw new NotImplementedException();
        }
    }
}
