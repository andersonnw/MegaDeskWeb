using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MegaDeskWeb.Models.SeedData
{
    public class SeedDesktop
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskWebContext>>()))
            {
                
                if (context.Desktop.Any())
                {
                    return;   // DB has been seeded
                }

                context.Desktop.Add(
                    new Desktop
                    {
                        
                    });
                context.SaveChanges();
            }
        }
    }
}
