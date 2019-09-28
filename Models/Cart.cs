using System.Collections.Generic;
namespace Bakery.Models
{
    public class Cart
    {
        public List<Bread> Loaves { get; set; }
        public List<Pastry> Pastries { get; set; }
        public Cart ()
        {
            Loaves = new List<Bread>();
            Pastries = new List<Pastry>();
        }
        public void BreadQty(int quantity)
        {
            for(int i = 0; i < quantity; i++)   
            {
                Bread loaf = new Bread();
                Loaves.Add(loaf);
            }
        }
        public void PastryQty(int quantity)
        {
            for(int i=0; i <  quantity; i++)
            {
                Pastry pastry = new Pastry();
            }
        }

    }
}