using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FathymaPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie {Id = 1, PieName="Strawberry Pie", Price=15.95, Description="Icing carrot cake jelly-o cheesecake.", 
                Category = _categoryRepository.AllCategories.ToList()[0],
                ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", 
                InStock=true, IsPieOfTheWeek=false, 
                ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},

            new Pie {Id = 2, PieName="Cheese cake", Price=18.95, Description="Chocolate cake candy cake.", 
                Category = _categoryRepository.AllCategories.ToList()[1],
                ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", 
                InStock=true, IsPieOfTheWeek=false, 
                ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},

            new Pie {Id = 3, PieName="Rhubarb Pie", Price=15.95, Description="Coffee brown brownie candy roll Pie.", 
                Category = _categoryRepository.AllCategories.ToList()[0],
                ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", 
                InStock=true, IsPieOfTheWeek=true, 
                ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},

            new Pie {Id = 4, PieName="Pumpkin Pie", Price=12.95, Description="Sweet roll African Pie Exotics.", 
                Category = _categoryRepository.AllCategories.ToList()[2],
                ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", 
                InStock=true, IsPieOfTheWeek=true, 
                ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"}
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
