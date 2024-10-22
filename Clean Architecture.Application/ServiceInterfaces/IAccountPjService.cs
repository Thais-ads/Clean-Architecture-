using Clean_Architecture.Application.Account;
using Clean_Architecture.Application.DTOs;


namespace Clean_Architecture.Application.ServiceInterfaces
{
    public interface IAccountPjService
    {
        Task<DtoRetornCreateAccount> OpenAccount(DtoUserId id);

    }
}
