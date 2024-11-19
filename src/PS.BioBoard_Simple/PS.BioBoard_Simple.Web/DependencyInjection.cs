using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using PS.BioBoard_Simple.Web.Data;
using PS.BioBoard_Simple.Web.Persistence.Interfaces;
using PS.BioBoard_Simple.Web.Persistence.Repositories;
using PS.BioBoard_Simple.Web.Services;
using PS.BioBoard_Simple.Web.Validators;

namespace PS.BioBoard_Simple.Web
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddControllersWithViews();



            services.AddScoped<IPersonService, PersonService>();

            services.AddValidatorsFromAssemblyContaining<PersonValidator>();

            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            
            services
               .AddPersistance(configuration);


            return services;
        }

        private static IServiceCollection AddPersistance(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<BioBoardSimpleDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IPersonRepository, PersonRepository>();

            return services;
        }

    }
}
