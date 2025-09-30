using Microsoft.Extensions.DependencyInjection;

namespace ProfanityFilter.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddProfanityfilter(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProfanityFilter, DefaultProfanityFilter>();
        }
    }
}