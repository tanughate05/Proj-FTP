using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uploading_SqlServer_SQLite_Project
{
    public class Material
    {
        public Material(string itemCode, double itemPrice, double newItemPrice)
        {
            this.ItemCode = itemCode;
            this.ItemPrice = itemPrice;
            this.NewPrice = newItemPrice;
        }
        string ItemCode { get; set; }

        double ItemPrice { get; set; }

        double NewPrice { get; set; }

        public string getItemCode()
        {
            return this.ItemCode;
        }

        public string getItemPrice()
        {
            return  this.ItemPrice.ToString();
        }

        public string getNewItemPrice()
        {
            return this.NewPrice.ToString();
        }
    }
}
