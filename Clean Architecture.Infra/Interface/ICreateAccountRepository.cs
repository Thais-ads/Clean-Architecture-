using Clean_Architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Clean_Architecture.Infra.Interface
{
    public interface ICreateAccountRepository : IRepository<CreatePersonCNPJ>
    {
     
    }
}
