using BlazorServerDemo1.Data;

namespace BlazorServerDemo1
{
    public static class DemoDISetup
    {
        public static IServiceCollection  AddDemoInfo(this IServiceCollection services)
        {
            services.AddTransient<IUtcDemo, UtcDemo>();
            services.AddTransient<IDemo, Demo>();
            services.AddTransient<ProcessDemo>();
            //scoping
            return services;
        }
    }
}
