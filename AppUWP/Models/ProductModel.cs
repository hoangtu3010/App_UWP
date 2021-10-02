using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace AppUWP.Models
{
    //class ProductModel
    //{
    //    public string Name { get; set; }
    //    public string Image { get; set; }
    //    public string Description { get; set; }
    //    public string Price { get; set; }
    //}

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string price { get; set; }

     
    }

    public class Products
    {
        public string message { get; set; }
        public List<Product> data { get; set; }
    }
}
