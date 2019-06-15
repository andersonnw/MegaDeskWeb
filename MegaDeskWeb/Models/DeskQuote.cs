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
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Please enter a name without numbers or symbols")]
        public string CustomerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public Desk Desk { get; set; }
        public float Price { get; set; }
        public Shipping Shipping { get; set; }

        public void calculatePrice()
        {
            float price = 200.0f;

            int width = Desk.Width;
            int depth = Desk.Depth;
            int numDraw = Desk.NumberOfDrawer;


            int area = width * depth;

            if (area > 1000)
            {
                price += (area - 1000);
            }

            price += numDraw * 50.0f;

            price += Desk.Material.Cost;

            if (area < 1000)
            {
                price += Shipping.CostSmall;
            }
            else if (area <= 2000)
            {
                price += Shipping.CostMed;
            }
            else
            {
                price += Shipping.CostLarge;
            }

            Price = price;
        }

    }
}
