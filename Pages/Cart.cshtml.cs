using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebbshoppenSS.Pages
{
    public class CartModel : PageModel
    {
        [BindProperty]
        public string ButtonTest { get; set; }
        public int MyCounter { get; set; }

        public void OnGet()
        {
        }

        public void OnPost(int add)
        {
            MyCounter = add;
        }
    }
}
