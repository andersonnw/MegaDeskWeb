using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MegaDeskWeb.Models.SeedData
{
    public class SeedShipping
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskWebContext>>()))
            {

                if (context.Shipping.Any())
                {
                    return;   // DB has been seeded
                }

                context.Shipping.AddRange(
                    new Shipping
                    {
                        Type = "3-Day",
                        CostSmall = 60.0f,
                        CostMed = 70.0f,
                        CostLarge = 80.0f
                    },
                    new Shipping
                    {
                        Type = "5-Day",
                        CostSmall = 40.0f,
                        CostMed = 50.0f,
                        CostLarge = 60.0f
                    },
                    new Shipping
                    {
                        Type = "7-Day",
                        CostSmall = 30.0f,
                        CostMed = 35.0f,
                        CostLarge = 40.0f
                    },
                    new Shipping
                    {
                        Type = "14-Day",
                        CostSmall = 0.0f,
                        CostMed = 0.0f,
                        CostLarge = 0.0f
                    });
                context.SaveChanges();
            }
        }
    }
}
