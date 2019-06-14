﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Shipping
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public float CostSmall { get; set; }
        public float CostMed { get; set; }
        public float CostLarge { get; set; }

    }
}
