using Clean_Architecture.Application.ServiceInterfaces;
using Clean_Architecture.Application.Services;
using Clean_Architecture.Infra.Context;
using Clean_Architecture.Infra.Interface;
using Clean_Architecture.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.Application.DI
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
            services.AddHttpClient();


           services.AddScoped<IAccountPjService, AccountPjService>();


            services.AddScoped<ICreateAccountRepository, CreateAccountRepository>();
           
        }

    }
}
