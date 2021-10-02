using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AppUWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {

        public Home()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Food food = e.Parameter as Food;
            RenderProduct(food);
        }

        public async void RenderProduct(Food food)
        {
            Services.HomeSevice service = new Services.HomeSevice();
            var products = await service.getProduct();
            if (products != null)
            {
                Gv.ItemsSource = products.data;
            }
        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Food food = Gv.SelectedItem as Food;
            MainPage._frame.Navigate(typeof(Pages.ProductDetail), food);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage._frame.Navigate(typeof(Pages.Home));
        }

        private void AddFavorite_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
