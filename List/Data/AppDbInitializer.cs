using ColorfulListWebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                // Lists
                if (!context.ColorfulLists.Any())
                {
                    context.ColorfulLists.AddRange(new List<ColorfulList>()
                    {
                        new ColorfulList()
                        {
                            Name = "Shopping List 1",
                            Description = "List Description 1"
                        },
                        new ColorfulList()
                        {
                            Name = "Shopping List 2",
                        },
                        new ColorfulList()
                        {
                            Name = "Shopping List 3",
                            Description = "List Description 3"
                        },
                        new ColorfulList()
                        {
                            Name = "Shopping List 4",
                        },
                        new ColorfulList()
                        {
                            Name = "Shopping List 5",
                            Description = "List Description 5"
                        },
                    });
                }

                // List Items
                if (!context.ListItems.Any())
                {
                    context.ListItems.AddRange(new List<ListItem>()
                    {
                        new ListItem()
                        {
                            ListId = 1,
                            Text = "List Item 1"
                        },
                        new ListItem()
                        {
                            ListId = 1,
                            Text = "List Item 2"
                        },
                        new ListItem()
                        {
                            ListId = 2,
                            Text = "List Item 1"
                        },
                        new ListItem()
                        {
                            ListId = 2,
                            Text = "List Item 2"
                        },
                        new ListItem()
                        {
                            ListId = 3,
                            Text = "List Item 1"
                        },
                        new ListItem()
                        {
                            ListId = 3,
                            Text = "List Item 2"
                        },
                        new ListItem()
                        {
                            ListId = 4,
                            Text = "List Item 1"
                        },
                        new ListItem()
                        {
                            ListId = 4,
                            Text = "List Item 2"
                        },
                        new ListItem()
                        {
                            ListId = 5,
                            Text = "List Item 1"
                        },
                        new ListItem()
                        {
                            ListId = 5,
                            Text = "List Item 2"
                        },
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
