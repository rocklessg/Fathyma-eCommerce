using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FathymaPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
             new Category{Id=1, CategoryName="Fruit pies", Description="All-fruity pies"},
             new Category{Id=2, CategoryName="Cherry cakes", Description="Cheery all the way"},
             new Category{Id=3, CategoryName="StrawBerry pies", Description="Get in the mood for a berry pie"}

        };

    }
}
