using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_3
{
    public class Product
    {
        
        public int ProductID { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }

        public Product(int price, int productID, string productName)
        {
            Price = price;
            ProductID = productID;
            ProductName = productName;
        }

        public override string? ToString()
        {
            return $"Price: {Price} Product Id: {ProductID} Product Name: {ProductName}";
        }
    }
}
