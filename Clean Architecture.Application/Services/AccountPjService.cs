using Clean_Architecture.Application.Account;
using Clean_Architecture.Application.DTOs;
using Clean_Architecture.Application.ServiceInterfaces;
using Clean_Architecture.Infra.Interface;
using Clean_Architecture.Domain.Models;


namespace Clean_Architecture.Application.Services
{
    public class AccountPjService : IAccountPjService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IUnityOfWork _unityOfWork;
        //private readonly IAuthenticateService _authenticateService;
        private readonly ICreateAccountRepository _createAccountRepository;
      
        

        public AccountPjService(ICreateAccountRepository createAccountRepository) 
        {
            _createAccountRepository = createAccountRepository;
        }

        public async Task<DtoRetornCreateAccount> OpenAccount(DtoUserId id)
        {
           
            var entity = new CreatePersonCNPJ
            {
                UserID = id.User_id
               
            };

            await _createAccountRepository.Insert(entity);
            await _unityOfWork.Commit();  

           
            return new DtoRetornCreateAccount();
        }





    }
}
