using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFormsUI
{
    public partial class Foody : ContentPage
    {
        public List<FoodyClass> FoodItems { get; set; }
        public Foody()
        {
            InitializeComponent();
            this.FoodItems = new List<FoodyClass>();

            this.LoadData(); 
        }

        private void LoadData()
        {
            this.FoodItems.Clear();
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody1.jpg", Title = "Pizza", SubTitle = "fresh backed Pizza & Breads" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody2.jpg", Title = "Vegan", SubTitle = "high protien vegan dishes" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody3.jpg", Title = "Chicken & Sauce", SubTitle = "lots of home made sauces" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody4.jpg", Title = "Burgers", SubTitle = "the big one, cheesy one & the veggy ones too" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody5.jpg", Title = "French Fries", SubTitle = "need a quick munch? we got you covered" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody6.jpg", Title = "Samosa", SubTitle = "the best Indian road side dish you can have" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody7.jpg", Title = "Salads", SubTitle = "french, Indian & Spanish all flaovors" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody8.jpg", Title = "Crunchies", SubTitle = "easy to cook crunchies" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody9.jpg", Title = "Eggs", SubTitle = "no recipe app is complete without a few egg dishes" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody10.jpg", Title = "Gujrati Food", SubTitle = "the best of Indian food for you" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody11.jpg", Title = "Roadside Food", SubTitle = "samosas again I am now out of ideas to write" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody12.jpg", Title = "Lemon & Herbs", SubTitle = "for when you need that refreshment!!" });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody13.jpg", Title = "Some Stuffed Food", SubTitle = "as if I need to explain what's in the image" });
             

            this.listRecipies.ItemsSource = this.FoodItems; 
        }

        public void OnShowClick(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var selectedItem = (FoodyClass)menuItem.BindingContext;
        }

        public void OnFavClick(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var selectedItem = (FoodyClass)menuItem.BindingContext;
        }
    }

    public class FoodyClass
    {
        public string  ImageURL { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
    }
}
