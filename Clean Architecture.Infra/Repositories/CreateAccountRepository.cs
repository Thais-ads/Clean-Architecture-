using Clean_Architecture.Domain.Models;
using Clean_Architecture.Infra.Context;
using Clean_Architecture.Infra.Interface;
using Microsoft.EntityFrameworkCore;

namespace Clean_Architecture.Infra.Repositories
{
    public class CreateAccountRepository: Repository<CreatePersonCNPJ>, ICreateAccountRepository
    {
       
            public CreateAccountRepository(AppDbContext context) : base(context)
            {
            }

           


     }



    
}
