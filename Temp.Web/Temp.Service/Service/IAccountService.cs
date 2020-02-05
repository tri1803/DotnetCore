using Temp.DataAccess;
using Temp.Service.DTO;

namespace Temp.Service.Service
{
    /// <summary>
    /// Account service interface
    /// </summary>
    public interface IAccountService
    {
        User LogIn(LogInDto logInDto);
        void CreateAccount(CreateAccDto accDto);
        bool CheckAccount(CreateAccDto accDto);
        bool ChangePass(ChangePassDto passDto);
        bool CheckPass(ChangePassDto passDto);
    }
}