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
    public class addStaffModel : PageModel
    {
        private readonly MultiCsinoContext _context;

        public addStaffModel(MultiCsinoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Staff staff{ get; set; }

        public void OnGet()
        {
        }


        public ActionResult OnPost()
        {
            var productItem =staff;
            if (!ModelState.IsValid)
            {
                return Page(); // return page  
            }

            productItem.staffID = 0;
            var result = _context.Add(productItem);
            _context.SaveChanges(); // Saving Data in database  

            return RedirectToPage("viewStaff");
        }


    }
}
