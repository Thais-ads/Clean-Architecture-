using Clean_Architecture.Infra.Context;
using Clean_Architecture.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.Infra.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly AppDbContext _context;

        public UnityOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
