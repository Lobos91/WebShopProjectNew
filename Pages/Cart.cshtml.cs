using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebbshoppenSS.Pages
{
    public class CartModel : PageModel
    {
        [BindProperty]
        public string ButtonTest { get; set; }
        public void OnGet()
        {
        }
    }
}
