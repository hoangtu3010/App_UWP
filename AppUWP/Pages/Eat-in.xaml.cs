using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using AppUWP.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Eat_in : Page
    {
        public Eat_in()
        {
            this.InitializeComponent();
        }

        private void Gv_Loaded(object sender, RoutedEventArgs e)
        {
            var item = new ProductModel() { Name = "Burger", Image = "/Assets/picture-box-1.jpg", Description = "A hamburger is a food, typically considered a sandwich", Price = "$13" };
            var item2 = new ProductModel() { Name = "Cake", Image = "/Assets/picture-box-2.jpg", Description = "A cake is a food, typically considered a sandwich.......,,,,,,,", Price = "$23" };
            var item3 = new ProductModel() { Name = "Pizza", Image = "/Assets/picture-box-3.jpg", Description = "A Pizza is a food, typically considered a sandwich.......,,,,,,,", Price = "$45" };


            Gv.Items.Add(item);
            Gv.Items.Add(item2);
            Gv.Items.Add(item3);

        }
    }
}
