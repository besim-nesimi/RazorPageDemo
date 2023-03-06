using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageDemo.Pages.Display
{
    public class ObjectListDisplayModel : PageModel
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
        public class Cat
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public int Cuteness { get; set; }
        }
        public void OnGet()
        {
        }
    }
}
