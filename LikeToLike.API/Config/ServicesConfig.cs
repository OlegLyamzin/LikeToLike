using LikeToLike.BLL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeToLike.API.Config
{
    public static class ServicesConfig
    {
        public static void RegistrateServicesConfig(this IServiceCollection services)
        {
            services.AddScoped<ITaskRepository, TaskRepository>();
        }
    }
}
