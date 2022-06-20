namespace Azox.Core.Extensions
{
    using Azox.Core.Configs;
    using Azox.Core.DependencyInjection;
    using Azox.Core.Reflection;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// 
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static void RegisterServices(this IServiceCollection services)
        {
            IEnumerable<IServiceRegister> serviceRegisters = TypeFinder
                .FindInstancesOf<IServiceRegister>();

            foreach (IServiceRegister serviceRegister in serviceRegisters)
            {
                serviceRegister.Register(services);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RegisterConfigs(this IServiceCollection services, IConfiguration configuration)
        {
            IEnumerable<IConfig> configs = TypeFinder
                .FindInstancesOf<IConfig>();

            foreach (IConfig config in configs)
            {
                configuration.GetSection(config.ConfigName)
                    .Bind(config);

                services.AddSingleton(config.GetType(), config);
            }
        }
    }
}
