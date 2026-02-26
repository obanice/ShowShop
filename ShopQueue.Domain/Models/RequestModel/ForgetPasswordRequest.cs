using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQueue.Domain.Models.RequestModel
{
    public class ForgetPasswordRequest
    {
        public string? UserEmail { get; set; }
    }
}
