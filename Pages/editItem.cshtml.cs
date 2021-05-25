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
    public class editItemModel : PageModel
    {
        private readonly MultiCsinoContext _context;

        public editItemModel(MultiCsinoContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Items item { get; set; }

        public void OnGet(int? id)
        {
            if (id != null)
            {
                var data = (from customer in _context.Items
                            where customer.itemID== id
                            select customer).SingleOrDefault();

                item = data;
            }
        }

        public ActionResult OnPost()
        {
            var customer = item;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Entry(customer).Property(x => x.Name).IsModified = true;
            _context.Entry(customer).Property(x => x.Quantity).IsModified = true;
            _context.Entry(customer).Property(x => x.Price).IsModified = true;
            
            _context.SaveChanges();
            return RedirectToPage("viewItems");
        }



    }
}
