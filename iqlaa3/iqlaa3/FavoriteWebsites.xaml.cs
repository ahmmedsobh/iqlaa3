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
    public partial class FavoriteWebsites : ContentPage
    {
        public FavoriteWebsites()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {

            base.OnAppearing();
            List<Website> websites = await App.Database.GetWebsitesAsync();
            List<Website> Catwebsites = websites.Where(w => w.IsVaforite).ToList();
            if(Catwebsites.Count > 0)
            {
                Content = lvWebsitesForCategory;
                lvWebsitesForCategory.ItemsSource = Catwebsites;

            }
            else
            {
                var label = new Label
                {
                    Text = "لايوجد مواقع مفضلة ضمن هذا التصنيف"
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
                Website website = e.SelectedItem as Website;
                await Navigation.PushAsync(new WebsiteBrowser(website.Url));

            }
        }

        protected async void DeleteFavorite(object sender,EventArgs e)
        {
            var button = sender as ImageButton;
            var Website = button.BindingContext as Website;
            if (Website != null)
            {

                Website website = await App.Database.GetWebsiteAsync(Website.Id);
                if (website != null)
                {
                    
                        website.IsVaforite = false;
                        await App.Database.SaveWebsiteAsync(website);
                        await DisplayAlert("قائمة المفضلة", "تم الحذف", "اغلاق");
                        OnAppearing();

                    
                }
            }
        }
    }
}