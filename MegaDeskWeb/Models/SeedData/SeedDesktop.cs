﻿using System;
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

                context.Desktop.AddRange(
                    new Desktop
                    {
                        Cost = 200 ,
                        Type = "Oak"
                    },
                    new Desktop
                    {
                        Cost = 100,
                        Type = "Laminate"
                    },
                    new Desktop
                    {
                        Cost = 50,
                        Type = "Pine"
                    },

                    new Desktop
                    {
                        Cost = 300,
                        Type = "Rosewood"
                    },

                    new Desktop
                    {
                        Cost = 125,
                        Type = "Veneer"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
