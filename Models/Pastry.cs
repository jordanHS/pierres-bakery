using System.Collections.Generic;
namespace Bakery.Models
{
    public class Pastry
    {
        public int Price { get; set; }        
        public string Item { get; set; }
        public Pastry()
        {
            Price = 2;
            Item = "Pastries";
        }
    }

} 

    