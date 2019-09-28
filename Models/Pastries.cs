using System.Collections.Generic;
namespace Bakery.Models
{
    public class Pastries
    {
        public int Price { get; set; }        
        public string Item { get; set; }
        public Pastries()
        {
            Price = 2;
            Item = "Pastries";
        }
    }

} 

    