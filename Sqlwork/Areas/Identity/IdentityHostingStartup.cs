using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sqlwork.Models;

[assembly: HostingStartup(typeof(Sqlwork.Areas.Identity.IdentityHostingStartup))]
namespace Sqlwork.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SqlworkContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SqlworkContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<SqlworkContext>();
            });
        }
    }
}