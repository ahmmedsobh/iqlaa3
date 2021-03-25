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
    public partial class Saved : ContentPage
    {
        
        
        public Saved()
        {
            InitializeComponent();
           
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            List<Website> websites = await App.Database.GetWebsitesAsync();
            List<Website> SavedWebsites = websites.Where(w => w.IsSaved).ToList();
            if (SavedWebsites.Count > 0)
            {
                Content = lvWebsites;
                lvWebsites.ItemsSource = SavedWebsites;

            }
            else
            {
                var label = new Label
                {
                    Text = "قائمة العناصر المحفوظة فارغة"
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

        protected async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Website website = e.SelectedItem as Website;
                await Navigation.PushAsync(new WebsiteBrowser(website.Url));

            }
        }

        protected async void DeleteSaved(object sender, EventArgs e)
        {
            var button = sender as ImageButton;
            var Website = button.BindingContext as Website;
            if (Website != null)
            {

                Website website = await App.Database.GetWebsiteAsync(Website.Id);
                if (website != null)
                {

                    
                    await App.Database.DeleteWebsiteAsync(website);
                    await DisplayAlert("العناصر المحفوظة", "تم الحذف", "اغلاق");
                    OnAppearing();


                }
            }
        }



    }
}