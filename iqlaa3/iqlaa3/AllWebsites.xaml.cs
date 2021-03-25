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
    public partial class AllWebsites : ContentPage
    {
        public AllWebsites()
        {
            InitializeComponent();
            //AddCategory();
            //DeleteCategories();
            



        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lvAllCategories.ItemsSource = await App.Database.GetCategoriesAsync();
        }

        public async void AddCategory()
        {
            List<Category> categories = new List<Category>()
            {
                 new Category{Name="التواصل الاجتماعى",Descrption="تواصل مع الأقارب والأصدقاء وتابع كل جديد",ImgUrl="iqlaa3.Imgs.media.png"}
                ,new Category{Name="تعليم",Descrption="منصات للتعلم من خلال الانترنت",ImgUrl="iqlaa3.Imgs.learn.png"}
                ,new Category{Name="التسوق",Descrption="تسوق من خلال الانترنت",ImgUrl="iqlaa3.Imgs.shoping.png"}
                ,new Category{Name="الأخبار",Descrption="تابع مستجدات الاحداث عربيا وعالميا",ImgUrl="iqlaa3.Imgs.news.png"}
                ,new Category{Name="الوظائف",Descrption="أحدث الوظائف المحلية والدولية",ImgUrl="iqlaa3.Imgs.jobs.png"}
                ,new Category{Name="الخدمات",Descrption="اطلب الخدمات المادية او الرقمية",ImgUrl="iqlaa3.Imgs.services.png"}
                ,new Category{Name="الأسئلة",Descrption="اطرح استقسارتك او أسئلتك للاجابة عليها",ImgUrl="iqlaa3.Imgs.ques.png"}


            };
            foreach (Category category in categories)
            {
               await App.Database.SaveCategoryAsync(category);
            }
        }

        public async void DeleteCategories()
        {
            List<Category> categories = await App.Database.GetCategoriesAsync();
            foreach(var item in categories)
            {
                await App.Database.DeleteCategoryAsync(item);
            }
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Category category = e.SelectedItem as Category;
                await Navigation.PushAsync(new AllWebsitesForCategory(category.Id));
            }
        }

    }
}