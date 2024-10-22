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

            public async Task<CreatePersonCNPJ> GetPersonByUUID(string uuid)
            {
                return await DbSet.AsNoTracking().Where(x => x.UUID == uuid).FirstOrDefaultAsync();
            }


            public async Task<Int64?> GetUserId(string uuid)
            {
                return await DbSet.AsNoTracking().Where(x => x.UUID == uuid).Select(x => x.UserID).FirstOrDefaultAsync();
            }


     }



    
}
