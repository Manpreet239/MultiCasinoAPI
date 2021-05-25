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
    public class editStaffModel : PageModel
    {
        private readonly MultiCsinoContext _context;

        public editStaffModel(MultiCsinoContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Staff item { get; set; }

        public void OnGet(int? id)
        {
            if (id != null)
            {
                var data = (from customer in _context.Staff
                            where customer.staffID == id
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
            _context.Entry(customer).Property(x => x.Address).IsModified = true;
            _context.Entry(customer).Property(x => x.Designation).IsModified = true;
            _context.Entry(customer).Property(x => x.Phoneno).IsModified = true;
            _context.Entry(customer).Property(x => x.Salary).IsModified = true;

            _context.SaveChanges();
            return RedirectToPage("viewStaff");
        }



    }
}
