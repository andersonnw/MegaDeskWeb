using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        public string CustomerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public Desk Desk { get; set; }
        public float Price { get; set; }
        public Shipping Shipping { get; set; }

    }
}
