namespace Azox.Core.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using System;

    /// <summary>
    /// 
    /// </summary>
    public static class ServiceProviderExtensions
    {
        private static object ResolveInner(IServiceProvider serviceProvider, Type serviceType)
        {
            IServiceProvider _serviceProvider = serviceProvider;

            try
            {
                return _serviceProvider.GetRequiredService(serviceType);
            }
            catch (InvalidOperationException)
            {
                _serviceProvider = serviceProvider.CreateScope().ServiceProvider;
            }

            try
            {
                return _serviceProvider.GetRequiredService(serviceType);
            }
            catch (InvalidOperationException)
            {
                throw new AzoxBugException($"Cannot resolve service type. ServiceType: {serviceType.FullName}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static T Resolve<T>(this IServiceProvider services)
        {
            return (T)Resolve(services, typeof(T));
        }

        /// <summary>
        /// 
        /// </summary>
        public static object Resolve(this IServiceProvider services, Type serviceType)
        {
            return ResolveInner(services, serviceType);
        }
    }
}
