using Core.Models.RequestModel;
using Core.Models.ResponseModel;
using Logic.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class AccountService : IAccountService
    {
        public AccountService()
        {
                
        }


        public async Task<ForgetPasswordResponse> ValidateAndSendResetLink(ForgetPasswordRequest request)
        {
            var result = new ForgetPasswordResponse();
            // Do some logic

            return result;
        }


    }
}
