using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MultiCsino.Data;
using MultiCsino.Model;

namespace MultiCsino.Pages
{
    public class addItemModel : PageModel
    {
        private readonly MultiCsinoContext _context;

        public addItemModel(MultiCsinoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Items item{ get; set; }

        public void OnGet()
        {
        }


        public ActionResult OnPost()
        {
            var productItem = item;
            if (!ModelState.IsValid)
            {
                return Page(); // return page  
            }

            productItem.itemID = 0;
            var result = _context.Add(productItem);
            _context.SaveChanges(); // Saving Data in database  

            return RedirectToPage("viewItems");
        }

    }
}
