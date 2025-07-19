using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }

        public Product(int id, string name, double price, double discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        public double CostAfterDiscount()
        {
            double discount = Price * DiscountPercentage;
            double final_price = Price - discount;
            return final_price;
        }

        public override string ToString()
        {
            return $"Product Id: {Id} \nProduct Name: {Name} \nActual Price: Rs {Price} \nDiscount Percentage: {DiscountPercentage*100}%";
        }
    }
}
