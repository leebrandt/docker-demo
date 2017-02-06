using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Kcdc.Api.Data
{
    public class Seeder
    {
        public static void SeedSpeakers(IServiceProvider serviceProvider)
        {
            var speakers = new List<Speaker>{
                new Speaker{
                    First = "Lee",
                    Last = "Brandt",
                    EmailAddress = "leebrandt@gmail.com",
                },
                new Speaker{
                    First = "Jon",
                    Last = "Mills",
                    EmailAddress = "jonathanfmills@gmail.com"
                }
            };

            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<KcdcContext>();
                
                if (!context.Speakers.Any()) {
                    context.AddRange(speakers);
                    context.SaveChanges();
                }
            }
        }
    }
}