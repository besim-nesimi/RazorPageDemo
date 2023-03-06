using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageDemo.Pages.Display
{
    public class StringDisplayModel : PageModel
    {
        public string? DisplayString { get; set; }
        public void OnGet(string displayString)
        {
            DisplayString = displayString;
        }
    }
}
