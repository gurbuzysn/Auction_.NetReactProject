using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Business.Dtos
{
    public class LoginRequestDto
    {
        public string UserName { get; set; }
        //public string FullName { get; set; }
        public string Password { get; set; }
    }
}
