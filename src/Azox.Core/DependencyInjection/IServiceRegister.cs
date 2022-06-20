namespace Azox.Core.DependencyInjection
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// 
    /// </summary>
    public interface IServiceRegister
    {
        /// <summary>
        /// 
        /// </summary>
        void Register(IServiceCollection services, IConfiguration configuration);
    }
}
