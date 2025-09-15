using BlazorServerDemo1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorServerDemo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddDemoInfo();

         
            // Samples
            // More info, depnedency injeciton srveice registartion methods , microsoft docs.
            //builder.Services.AddTransient<Demo>();
            //builder.Services.AddTransient<IDemo, Demo>();
            //builder.Services.AddSingleton(new DemoWithData(5));
            //builder.Services.AddSingleton(new Demo());
            //builder.Services.AddTransient<IDemo>(i => new Demo());
            //builder.Services.AddTransient(i => new DemoWithData(4)); 

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}