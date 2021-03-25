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
    public partial class AllWebsitesForCategory : ContentPage
    {
        int Id;
        bool IsFavorite;
        //Website Website;

        public AllWebsitesForCategory(int id)
        {
            InitializeComponent();
            Id = id;

            //Website = lvWebsitesForCategory.SelectedItem as Website;
        }

        protected override async void OnAppearing()
        {
            
            base.OnAppearing();
            List<Website> websites  = await App.Database.GetWebsitesAsync();
            List<Website> Catwebsites = websites.Where(w => w.CategoryId == Id).ToList();
            lvWebsitesForCategory.ItemsSource = Catwebsites;
        }

        public async void AddToFavorite(object sender,EventArgs e)
        {
            var button = sender as ImageButton;
            var Website = button.BindingContext as Website;
            if (Website != null)
            {
                
                Website website = await App.Database.GetWebsiteAsync(Website.Id);
                if (website != null)
                {
                    if (website.IsVaforite)
                    {
                        await DisplayAlert("قائمة المفضلة", "تمت اضافته سابقا", "اغلاق");
                    }
                    else
                    {
                        website.IsVaforite = true;
                        await App.Database.SaveWebsiteAsync(website);
                        await DisplayAlert("قائمة المفضلة", "تمت الاضافة الى المفضلة", "اغلاق");

                    }
                }
            }
        }
        public async void AddToSpeedList(object sender, EventArgs e)
        {

            var button = sender as ImageButton;
            var Website = button.BindingContext as Website;
            if (Website != null)
            {
                
                Website website = await App.Database.GetWebsiteAsync(Website.Id);
                if (website != null)
                {
                    if (website.IsTrend)
                    {
                        await DisplayAlert("قائمة التصفح السريع", "تمت اضافته سابقا", "اغلاق");
                    }
                    else
                    {
                        website.IsTrend = true;
                        await App.Database.SaveWebsiteAsync(website);
                        await DisplayAlert("قائمة التصفح السريع", "تمت الاضافة الى التصفح السريع", "اغلاق");
                    }
                }
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
    }
}