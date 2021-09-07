using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public ProductModel(){ }
        public ProductModel(string category, string name, string description,  string price)
        {
            Category = category;
            Name = name;
            Description = description;
            decimal prizeValue = 0;
            decimal.TryParse(price, out prizeValue);
            Price = prizeValue;
        }
        

    }
}
