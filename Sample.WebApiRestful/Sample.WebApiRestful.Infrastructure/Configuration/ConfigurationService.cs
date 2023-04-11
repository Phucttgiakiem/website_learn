using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sample.webapiRestful.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.webapiRestful.Infractructure.Configuration
{
    public static class ConfigurationService
    {
        public static void RegisterContext (this IServiceCollection service,IConfiguration configuration) {
            service.AddDbContext<samplewebapiContext>(option => option.UseSqlServer(configuration.GetConnectionString("SampleWebApiConnection"),
                option => option.MigrationsAssembly(typeof(samplewebapiContext).Assembly.FullName)
                ));
        }
    }
}
