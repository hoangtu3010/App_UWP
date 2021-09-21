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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame _frame;

        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Home));
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            var item = new MenuModel() { Name = "Home", NamePage = "home", Icon = "/Assets/button1.png" };
            var item2 = new MenuModel() { Name = "Eat-in", NamePage = "eat-in", Icon = "/Assets/button2.png" };
            var item3 = new MenuModel() { Name = "Collection", NamePage = "collection", Icon = "/Assets/button3.png" };
            var item4 = new MenuModel() { Name = "Delivery", NamePage = "delivery", Icon = "/Assets/button4.png" };
            var item5 = new MenuModel() { Name = "Take Away", NamePage = "take-away", Icon = "/Assets/button5.png" };
            var item6 = new MenuModel() { Name = "Driver Payment", NamePage = "driver-payment", Icon = "/Assets/button6.png" };
            var item7 = new MenuModel() { Name = "Customers", NamePage = "customers", Icon = "/Assets/button7.png" };

            Menu.Items.Add(item);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
            Menu.Items.Add(item5);
            Menu.Items.Add(item6);
            Menu.Items.Add(item7);
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuModel selectedItem = (MenuModel)Menu.SelectedItem;
            switch (selectedItem.NamePage)
            {
                case "home": MainFrame.Navigate(typeof(Pages.Home), selectedItem); break;
                case "eat-in": MainFrame.Navigate(typeof(Pages.Eat_in)); break;
            }
        }
    }
}
