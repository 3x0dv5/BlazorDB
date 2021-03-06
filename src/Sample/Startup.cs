﻿using BlazorDB;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazorDB(options =>
            {
                options.LogDebug = true;
                options.Assembly = typeof(Program).Assembly;
            });
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
