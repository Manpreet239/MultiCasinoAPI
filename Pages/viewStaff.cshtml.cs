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
    public class viewStaffModel : PageModel
    {
        private readonly MultiCsinoContext _context;

        public viewStaffModel(MultiCsinoContext context)
        {
            _context = context;
        }


        public List<Staff> staffList { get; set; }

        public void OnGet()
        {
            var data = (from customerlist in _context.Staff
                        select customerlist).ToList();

            staffList = data;
        }


        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {
                var data = (from customer in _context.Staff
                            where customer.staffID == id
                            select customer).SingleOrDefault();

                _context.Remove(data);
                _context.SaveChanges();
            }
            return RedirectToPage("viewStaff");
        }


    }
}
