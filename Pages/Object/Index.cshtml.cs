using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageDemo.Pages.Object
{
    public class IndexModel : PageModel
    {
        public class Dog
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public List<Dog> Dogs { get; set; } = new()
        {
            new Dog()
            {
                Id = 1,
                Name = "Doggo",

            }, new Dog()
            {
                Id = 2,
                Name = "Foggo",
            }, new Dog()
            {
                Id = 3,
                Name = "Goggo"
            }
        };

        public Dog? SelectedDog { get; set; }

        public void OnGet(int index)
        {
            var dog = Dogs.FirstOrDefault(x => x.Id == index);

            if (dog != null)
            {
                SelectedDog = dog;
            }
        }
    }
}
