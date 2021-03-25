using iqlaa3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace iqlaa3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {

        
        public Home()
        {
            InitializeComponent();
            //Task<List<Website>> websites = App.Database.GetWebsitesAsync();
            //BindingContext = this;
            //lvWebsites.ItemsSource = 
            AddWebsites();
            //DeleteAllWebsites();
             
        }

        public void AddWebsites()
        {
            List<Website> websites = new List<Website>()
            {
                 new Website{Name="بحث جوجل",Descrption="ابحث فى الويب",Imgurl="iqlaa3.Imgs.google.png",IsVaforite=false,IsTrend=true,CategoryId=19,Url="https://www.google.com/"}
                ,new Website{Name="فيس بوك",Descrption="تواصل مع الأشخاص",Imgurl="iqlaa3.Imgs.post.jpg",IsVaforite=false,IsTrend=true,CategoryId=13,Url="https://www.facebook.com/"}
                ,new Website{Name="يوتيوب",Descrption="فديوهات فى كافة التصنيفات",Imgurl="iqlaa3.Imgs.youtupe.jpg",IsVaforite=false,IsTrend=true,CategoryId=13,Url="https://www.youtube.com/"}
                ,new Website{Name="تويتر",Descrption="تابع التغريدات وغرد",Imgurl="iqlaa3.Imgs.tiwtter.jpg",IsVaforite=false,IsTrend=true,CategoryId=13,Url="https://twitter.com"}
                ,new Website{Name="انستجرام",Descrption="تابع الصور وحمل صورك",Imgurl="iqlaa3.Imgs.insta.png",IsVaforite=false,IsTrend=true,CategoryId=13,Url="https://www.instagram.com/"}
                ,new Website{Name="واتساب",Descrption="تواصل مع الأشخاص",Imgurl="iqlaa3.Imgs.whats.png",IsVaforite=false,IsTrend=true,CategoryId=13,Url="https://web.whatsapp.com/"}
                ,new Website{Name="رواق",Descrption="رواق للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.rwaq.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.rwaq.org/"}
                ,new Website{Name="ادراك",Descrption="ادراك للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.edraak.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.edraak.org/"}
                ,new Website{Name="نفهم",Descrption="نفهم للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.nafham.jpg",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.nafham.com/"}
                ,new Website{Name="حرباية",Descrption="حرباية للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.harabeee.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.harabeee.com/"}
                ,new Website{Name="تمكين",Descrption="تمكين للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.tamkeen.jpg",IsVaforite=false,IsTrend=false,CategoryId=14,Url="http://tamkeen-edu.org/index.php"}
                ,new Website{Name="ندرس",Descrption="ندرس للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.nadrus.jpg",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.nadrus.com/view-courses"}
                ,new Website{Name="زادى",Descrption="زادى للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.zadi.jpg",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://zadi.net/courses"}
                ,new Website{Name="أكاديمية حسوب",Descrption="اكاديمية حسوب للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.academyhsoub.jpg",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://academy.hsoub.com/"}
                ,new Website{Name="مهارة",Descrption="مهارة للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.maharah.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.maharah.net/courses"}
                ,new Website{Name="دروب",Descrption="دروب للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.Doroob.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.doroob.sa/ar/individuals/elearning/"}
                ,new Website{Name="اكاديمية التحرير",Descrption="أكاديمية التحرير للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.tahriracademy.jpg",IsVaforite=false,IsTrend=false,CategoryId=3,Url="http://tahriracademy.org/"}
                ,new Website{Name="اكاديمية خان",Descrption="اكاديمية خان للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.khanacademy.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://ar.khanacademy.org/"}
                ,new Website{Name="ادلال",Descrption="ادلال للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.edlal.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://edlal.org/"}
                ,new Website{Name="مهارة تك",Descrption="مهارة تك للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.maharatech.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://maharatech.gov.eg/"}
                ,new Website{Name="كورسات",Descrption="كورسات للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.coursat.jpg",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.coursat.org/"}
                ,new Website{Name="تيرا كورسات",Descrption="تيرا كورسات للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.teracourses.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://teracourses.com/"}
                ,new Website{Name="يوديمى",Descrption="يوديمى للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.udemy.jpg",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.udemy.com/"}
                ,new Website{Name="شمسنا العربية",Descrption="شمسنا العربية للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.shamsunalarabia.jpg",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://shamsunalarabia.net/"}
                ,new Website{Name="سديم",Descrption="سديم للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.sdeem.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="https://www.sdeem.org/"}
                ,new Website{Name="فرى فور أرب",Descrption="فرى فور ارب للتعلم عبر الانترنت",Imgurl="iqlaa3.Imgs.free4arab.png",IsVaforite=false,IsTrend=false,CategoryId=14,Url="http://free4arab.com/"}
                ,new Website{Name="موضوع",Descrption="مواضيع مقروءه فى كافة المجالات",Imgurl="iqlaa3.Imgs.mawdoo3.png",IsVaforite=false,IsTrend=true,CategoryId=14,Url="https://mawdoo3.com/"}
                ,new Website{Name="ويكيبديا",Descrption="موسوعة المعرفة بالعربية",Imgurl="iqlaa3.Imgs.wikipedia.png",IsVaforite=false,IsTrend=true,CategoryId=14,Url="https://ar.wikipedia.org"}
                ,new Website{Name="نون",Descrption="نون للتسوق عبر الانترنت",Imgurl="iqlaa3.Imgs.noon.png",IsVaforite=false,IsTrend=true,CategoryId=15,Url="https://www.noon.com"}
                ,new Website{Name="جوميا",Descrption="جوميا للتسوق عبر الانترنت",Imgurl="iqlaa3.Imgs.jumia.png",IsVaforite=false,IsTrend=true,CategoryId=15,Url="https://www.jumia.com"}
                ,new Website{Name="اولكس",Descrption="اولكس للتسوق عبر الانترنت",Imgurl="iqlaa3.Imgs.olx.png",IsVaforite=false,IsTrend=true,CategoryId=15,Url="https://www.olx.com.eg/"}
                ,new Website{Name="سوق",Descrption="سوق للتسوق عبر الانترنت",Imgurl="iqlaa3.Imgs.souq.jpg",IsVaforite=false,IsTrend=true,CategoryId=15,Url="https://egypt.souq.com"}
                ,new Website{Name="امازون",Descrption="امازون للتسوق عبر الانترنت",Imgurl="iqlaa3.Imgs.amazon.png",IsVaforite=false,IsTrend=true,CategoryId=15,Url="https://www.amazon.ae"}
                ,new Website{Name="السوق المفتوح",Descrption="السوق المفتوح للتسوق عبر الانترنت",Imgurl="iqlaa3.Imgs.opensooq.jpg",IsVaforite=false,IsTrend=false,CategoryId=15,Url="https://eg.opensooq.com/ar"}
                ,new Website{Name="نمشى",Descrption="نمشى للتسوق عبر الانترنت",Imgurl="iqlaa3.Imgs.namshi.png",IsVaforite=false,IsTrend=false,CategoryId=15,Url="https://en-ae.namshi.com/"}
                ,new Website{Name="بلينك",Descrption="بلينك للتسوق عبر الانترنت",Imgurl="iqlaa3.Imgs.blink.jpg",IsVaforite=false,IsTrend=false,CategoryId=15,Url="https://www.blink.com.kw/"}
                ,new Website{Name="ياقوطة",Descrption="ياقوطة للتسوق عبر الانترنت",Imgurl="iqlaa3.Imgs.yaoota.jpg",IsVaforite=false,IsTrend=true,CategoryId=15,Url="https://yaoota.com"}
                ,new Website{Name="أخبار جوجل",Descrption="تابع الأخبار عبر الانترنت",Imgurl="iqlaa3.Imgs.googlenews.jpg",IsVaforite=false,IsTrend=true,CategoryId=16,Url="https://news.google.com/?hl=ar&gl=EG&ceid=EG:ar"}
                ,new Website{Name="بى بى سى عربى",Descrption="تابع الأخبار عبر الانترنت",Imgurl="iqlaa3.Imgs.bbc.jpg",IsVaforite=false,IsTrend=false,CategoryId=16,Url="https://www.bbc.com/arabic/"}
                ,new Website{Name="سى ان ان عربى",Descrption="تابع الأخبار عبر الانترنت",Imgurl="iqlaa3.Imgs.cnn.png",IsVaforite=false,IsTrend=false,CategoryId=16,Url="https://arabic.cnn.com/"}
                ,new Website{Name="آر تى عربى",Descrption="تابع الأخبار عبر الانترنت",Imgurl="iqlaa3.Imgs.arabicrt.png",IsVaforite=false,IsTrend=false,CategoryId=16,Url="https://arabic.rt.com/"}
                ,new Website{Name="الجزيرة",Descrption="تابع الأخبار عبر الانترنت",Imgurl="iqlaa3.Imgs.aljazeera.jpg",IsVaforite=false,IsTrend=false,CategoryId=16,Url="http://www.aljazeera.net/"}
                ,new Website{Name="العربية",Descrption="تابع الأخبار عبر الانترنت",Imgurl="iqlaa3.Imgs.alarabiya.jpg",IsVaforite=false,IsTrend=false,CategoryId=16,Url="https://www.alarabiya.net/"}
                ,new Website{Name="أخبار ميكروسوفت",Descrption="تابع الأخبار عبر الانترنت",Imgurl="iqlaa3.Imgs.msn.png",IsVaforite=false,IsTrend=true,CategoryId=16,Url="https://www.msn.com/ar-ae/news?ref=Nav%C2%AEion=all"}
                ,new Website{Name="وكالة الاناضول",Descrption="تابع الأخبار عبر الانترنت",Imgurl="iqlaa3.Imgs.aa.png",IsVaforite=false,IsTrend=false,CategoryId=16,Url="https://www.aa.com.tr/ar"}
                ,new Website{Name="وكالة الشرق الاوسط",Descrption="تابع الأخبار عبر الانترنت",Imgurl="iqlaa3.Imgs.aawsat.png",IsVaforite=false,IsTrend=false,CategoryId=16,Url="https://aawsat.com/"}
                ,new Website{Name="بيت كوم",Descrption="بيت دوت كوم للبحث عن الوظائف",Imgurl="iqlaa3.Imgs.byte.png",IsVaforite=false,IsTrend=true,CategoryId=17,Url="https://www.bayt.com"}
                ,new Website{Name="وظف",Descrption="وظف دوت نت للبحث عن الوظائف",Imgurl="iqlaa3.Imgs.wazaf.jpg",IsVaforite=false,IsTrend=true,CategoryId=17,Url="https://wuzzuf.net"}

            };
            
            
            
            foreach (Website item in websites)
            {
                App.Database.SaveWebsiteAsync(item);
            }
        }

        public async void DeleteAllWebsites()
        {
            List<Website> websites = await App.Database.GetWebsitesAsync();
            foreach(var item in websites)
            {
              await App.Database.DeleteWebsiteAsync(item);
            }
        }

        

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            List<Website> websites =  await App.Database.GetWebsitesAsync();
            List<Website> TrendWebsites = websites.Where(w => w.IsTrend).ToList();
            if(TrendWebsites.Count > 0)
            {
                Content = lvWebsites;
                lvWebsites.ItemsSource = TrendWebsites;

            }
            else
            {
               var label = new Label
                {
                    Text = "قائمة التصفح السريع فارغة"
                    ,
                    FontSize = 20
                    ,HorizontalOptions = LayoutOptions.CenterAndExpand
                    ,VerticalOptions = LayoutOptions.CenterAndExpand
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

        protected async void DeleteTrend(object sender ,EventArgs e)
        {
            var button = sender as ImageButton;
            var Website = button.BindingContext as Website;
            if (Website != null)
            {

                Website website = await App.Database.GetWebsiteAsync(Website.Id);
                if (website != null)
                {

                    website.IsTrend = false;
                    await App.Database.SaveWebsiteAsync(website);
                    await DisplayAlert("قائمة التصفح السريع", "تم الحذف", "اغلاق");
                    OnAppearing();


                }
            }
        }


    }
}