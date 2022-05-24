using Data.Context;
using Data.Repository;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer("Server=server-psipass.database.windows.net;Database=PsiPass;User Id=psipass;Password=#database123;")
            );
        }
    }
}
 