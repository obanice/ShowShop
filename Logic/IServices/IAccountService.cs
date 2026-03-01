using Core.Models.RequestModel;
using Core.Models.ResponseModel;


namespace Logic.IServices
{
    public interface IAccountService
    {
        Task<ForgetPasswordResponse> ValidateAndSendResetLink(ForgetPasswordRequest request);       
    }
}
