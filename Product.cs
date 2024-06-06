using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketZadacha
{
    internal class Product
    {
        
        private string nameofproduct;
        private decimal price;
        private int quantity;
        private decimal totalprice;

        public string ProductName 
        { get 
            { 
                return nameofproduct; 
            }
            set
            {
                nameofproduct = value;
            }
        }
        public decimal ProductPrice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public decimal TotalPrice
        {
          get 
            { 
                return ProductPrice*Quantity; 
            }
            set 
            { 
                totalprice = value; 
            }
        }
        
        public Product(string name, decimal price, int quantity)
        {
            this.ProductName = name;
            this.ProductPrice = price;
            this.Quantity = quantity;
            
        }
    }
}
