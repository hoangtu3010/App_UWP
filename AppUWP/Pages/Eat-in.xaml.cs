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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Category category = e.Parameter as Category;
            RenderFoods(category);
        }

        public async void RenderFoods(Category category)
        {
            Services.CategoryService service = new Services.CategoryService();
            var CategoryDetail = await service.GetCategoryDetail(category.id.ToString());
            if (CategoryDetail != null)
            {
                Gv.ItemsSource = CategoryDetail.data.foods;
            }
        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Food food = Gv.SelectedItem as Food;
            MainPage._frame.Navigate(typeof(ProductDetail), food);
        }
    }
}
