using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.Application.ServiceInterfaces
{
    public interface IAuthService
    {
        Task<string> RegisterAndLoginAsync();
    }

}
