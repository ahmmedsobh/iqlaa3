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
    public partial class Open : CarouselPage
    {

        ContentPage cp;
        public Open()
        {
            InitializeComponent();
        }
        public Open(ContentPage contentPage)
        {
            InitializeComponent();
            if (contentPage != null)
                Children.Remove(contentPage);
            //if(ClsPages.websitesList.Count > 0)
            //{
            //    if(cp != null)
            //    Children.Remove(cp);
                
            //}
            //foreach (var item in ClsPages.websitesList)
            //{
            //    Children.Add(item);
            //}
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //if (ClsPages.websitesList.Count == 0)
            //{
                
            //    cp = new ContentPage
            //    {
                    
            //        Content = new Label
            //        {
            //            Text = "لايوجد مواقع مفتوحة"
            //           ,
            //            VerticalOptions = LayoutOptions.CenterAndExpand
            //           ,
            //            HorizontalOptions = LayoutOptions.CenterAndExpand
            //           ,
            //            FontSize = 20
            //        }



            //    };
                
                
            //    Children.Add(cp);
            //    return;
            //}
            //else
            //{
            //    if (cp != null)
            //        Children.Remove(cp);

            //}

            
                
            
            foreach (var item in ClsPages.websitesList)
            {
                Children.Add(item);
            }

        }
        //public void DisplayList(object sender , EventArgs e)
        //{
        //    foreach (var item in ClsPages.websitesList)
        //    {
        //        Children.Add(item);
        //    }
        //}

        
    }
}