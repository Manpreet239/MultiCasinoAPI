using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiCsino.Model
{
    public class Staff
    {
        [Key]
        public int staffID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Address")]

        public string Address { get; set; }

        [Required(ErrorMessage = "Enter Designation")]
        public string Designation { get; set; }

      

        [Required(ErrorMessage = "Enter City Phoneno")]
        public string Phoneno { get; set; }

        [Required(ErrorMessage = "Enter Salary")]
        public int Salary { get; set; }
    }
}
