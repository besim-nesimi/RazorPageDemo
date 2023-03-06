using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static RazorPageDemo.Pages.Display.ObjectListDisplayModel;

namespace RazorPageDemo.Pages.Display
{
    public class SpecificObjectDisplayModel : PageModel
    {
        public List<Cat> Cats = new()
        {
            new Cat()
            {
                Id = 1,
                Name = "Terminator",
                Cuteness = 10,
            },
            new Cat()
            {
                Id = 2,
                Name = "RoboCop",
                Cuteness = 8,
            },
            new Cat()
            {
                Id = 3,
                Name = "T800",
                Cuteness = 6,
            }
        };

        public Cat? SelectedCat { get; set; }

        public void OnGet(int index)
        {
            var cat = Cats.FirstOrDefault(x => x.Id == index);

            SelectedCat = cat;
        }
    }
}
