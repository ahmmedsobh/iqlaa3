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
    public partial class WebsiteBrowser : ContentPage
    {
        string src;
        public WebsiteBrowser(string url)
        {
            InitializeComponent();
            ClsPages.websitesList.Add(this);
            wvWebsite.Source = url;
            wvWebsite.Navigating += (object sender, WebNavigatingEventArgs e) =>
            {
                 src  = e.Url;
            };



        }

        public void closePage(object sender, EventArgs e)
        {
            ClsPages.websitesList.Remove(this);
            this.Navigation.PushAsync(new Open(this));
        }

        public async void savePage(object sender, EventArgs e)
        {
            if(src != null)
            {
                List<Website> websites = await App.Database.GetWebsitesAsync();
                var website = websites.FirstOrDefault(w => w.Url == src.ToString());
                List<Website> savedWebsites = websites.Where(w => w.IsSaved).ToList();
                if (website == null)
                {
                    website = new Website();
                    website.Name = $"عنصر {savedWebsites.Count + 1}";
                    website.Descrption = "الوصف غير متاح";
                    website.Url = src.ToString();
                    website.Imgurl = "iqlaa3.Imgs.logo.png";
                    website.IsSaved = true;
                    website.IsTrend = false;
                    website.IsVaforite = false;
                    await this.Navigation.PushAsync(new SaveWebsite(website));
                }
                else
                {
                    await DisplayAlert("العناصر المحفوظة", "هذا العنصر أضيف مسبقا", "اغلاق");
                }
            }
            else
            {
                await DisplayAlert("العناصر المحفوظة", "لايوجد شئ لحفظه", "اغلاق");
            }

        }


    }
}