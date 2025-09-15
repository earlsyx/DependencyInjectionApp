using BlazorServerDemo1.Data;

namespace BlazorServerDemo1
{
    public static class DemoDISetup
    {
        public static IServiceCollection  AddDemoInfo(this IServiceCollection services)
        {
            services.AddTransient<IDemo, Demo>();
            services.AddTransient<IDemo, UtcDemo>();
            services.AddTransient<ProcessDemo>();
            //services.AddTransient(x => new ProcessDemo(x.GetRequiredService<IDemo>(), 25));
            //scoping
            return services;
        }
    }
}
