using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FirstProject.Configuration;
using FirstProject.Web;

namespace FirstProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FirstProjectDbContextFactory : IDesignTimeDbContextFactory<FirstProjectDbContext>
    {
        public FirstProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FirstProjectDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FirstProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FirstProjectConsts.ConnectionStringName));

            return new FirstProjectDbContext(builder.Options);
        }
    }
}
