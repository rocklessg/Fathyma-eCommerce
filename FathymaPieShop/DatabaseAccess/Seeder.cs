using FathymaPieShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FathymaPieShop.DatabaseAccess
{
    public class Seeder
    {
        public static async Task Seed(AppDbContext context)
        {
            try
            {
                context.Database.EnsureCreated();

                if (!context.Categories.Any())
                {
                    
                    var categoryData = File.ReadAllText(@"JsonFile/product.json");
                    var categoryLists = JsonConvert.DeserializeObject<List<Category>>(categoryData);
                    await context.Categories.AddRangeAsync(categoryLists);
                }
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
