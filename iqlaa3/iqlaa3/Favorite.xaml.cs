using iqlaa3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iqlaa3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favorite : ContentPage
    {
        public Favorite()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            List<Category> FavCategories = new List<Category>();
            List<Category> categories = await App.Database.GetCategoriesAsync();
            List<Website> websites = await App.Database.GetWebsitesAsync();
            List<Website> CatWebsites = new List<Website>();
            foreach (var item in categories)
            {
                CatWebsites = websites.Where(w => w.CategoryId == item.Id).ToList();  
                if(CatWebsites != null)
                {
                    foreach (var website in CatWebsites)
                    {
                        if (website.IsVaforite)
                        {
                            if(FavCategories.Find(c => c.Id == item.Id) == null)
                            {
                                FavCategories.Add(item);
                            }

                        }
                    }
                }
                    
            
               
            }
            if(FavCategories.Count > 0)
            {
                Content = lvAllCategories;
                lvAllCategories.ItemsSource = FavCategories;

            }
            else
            {
                var label = new Label
                {
                    Text = "قائمة المفضلة فارغة"
                    ,
                    FontSize = 20
                    ,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                    ,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                Content = label;
            }
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new FavoriteWebsites());
            }
        }
    }
}