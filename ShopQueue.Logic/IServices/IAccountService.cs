using ShopQueue.Domain.Models.RequestModel;
using ShopQueue.Domain.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQueue.Logic.IServices
{
    public interface IAccountService
    {
        Task<ForgetPasswordResponse> ValidateAndSendResetLink(ForgetPasswordRequest request);
    }
}
