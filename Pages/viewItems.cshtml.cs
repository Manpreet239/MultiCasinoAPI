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
    public class viewItemsModel : PageModel
    {
        private readonly MultiCsinoContext _context;

        public viewItemsModel(MultiCsinoContext context)
        {
            _context = context;
        }


        public List<Items> ItemList { get; set; }

        public void OnGet()
        {
            var data = (from customerlist in _context.Items
                        select customerlist).ToList();

            ItemList = data;
        }


        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {
                var data = (from customer in _context.Items
                            where customer.itemID == id
                            select customer).SingleOrDefault();

                _context.Remove(data);
                _context.SaveChanges();
            }
            return RedirectToPage("viewItems");
        }


    }
}
