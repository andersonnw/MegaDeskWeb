using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Desk
    {
        public int ID { get; set; }
        [RegularExpression(@"^(4[0-8]|3[0-9]|2[0-9]|1[2-9])$", ErrorMessage = "Please enter a value between 12 and 48")] 
        public int Depth { get; set; }
        [RegularExpression(@"^(9[0-6]|8[0-9]|7[0-9]|6[0-9]|5[0-9]|4[0-9]|3[0-9]|2[4-9])$", ErrorMessage = "Please enter a value between 24 and 96")]
        public int Width { get; set; }
        public Desktop Material { get; set; }
        [RegularExpression(@"^([0]|[1-7])$", ErrorMessage = "Please enter a value between 0 and 7")]
        public int NumberOfDrawer { get; set; }

    }
}
