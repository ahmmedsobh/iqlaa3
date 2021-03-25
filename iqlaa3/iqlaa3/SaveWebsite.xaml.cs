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
    public partial class SaveWebsite : ContentPage
    {
        Website Website;
        public SaveWebsite(Website website)
        {
            InitializeComponent();
            Website = website;
        }

        protected async void AddElementToSavedList(object sender, EventArgs e)
        {
            if (txtName.Text != null)
            {
                Website.Name = txtName.Text;
            }

            if (txtDesc.Text != null)
            {
                Website.Descrption = txtDesc.Text;
            }

            await App.Database.SaveWebsiteAsync(Website);
            await DisplayAlert("العناصر المحفوظة", "تمت الاضافة الى العناصر المحفوظة", "اغلاق");
            txtName.Text = "";
            txtDesc.Text = "";
            await Navigation.PopAsync();
        }
    }
}