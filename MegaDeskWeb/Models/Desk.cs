using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Desk
    {
        public int ID { get; set; }
        public int width { get; set; }
        public Desktop Material;
        public int numberOfDrawer { get; set; }

    }
}
