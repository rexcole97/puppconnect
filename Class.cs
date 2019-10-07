using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace baebook1.Data
{
    public class Class
    {
        [Key]
        public int puppyid { get; set; }
        public string breed { get; set; }
        public string sex { get; set; }
        public double price { get; set; }
         
    }
}
