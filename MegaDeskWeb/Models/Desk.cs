using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Desk
    {
        public int ID { get; set; }

        public int Depth { get; set; }
        public int Width { get; set; }
        public Desktop Material;
        public int NumberOfDrawer { get; set; }

    }
}
