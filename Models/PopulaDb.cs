using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreDocker.Models
{
    public class PopulaDb
    {
        public static void IncluiDadosDB(IApplicationBuilder app)
        {
            IncluiDadosDB(
                app.ApplicationServices
            )

        }
        
    }
}