using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageDemo.Pages.Display
{
    public class ListDisplayModel : PageModel
    {
        public List<string> Names { get; set; } = new()
        {
            "Besim",
            "Besim1",
            "Besim2",
            "Besim3",
            "Besim4",
        };
        public void OnGet()
        {
        }
    }
}
