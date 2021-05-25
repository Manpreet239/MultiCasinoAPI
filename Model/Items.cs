using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiCsino.Model
{
    public class Items
    {
        [Key]
        public int itemID { get; set; }

        [Required(ErrorMessage = "Enter Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Enter Price")]
        public int Price { get; set; }

    }
}
