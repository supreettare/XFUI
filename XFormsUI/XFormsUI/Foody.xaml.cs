using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsUI
{
    public partial class Foody : ContentPage
    {
        public ObservableCollection<FoodyClass> FoodItems { get; set; }

        private int oldIndex;
        public int OldIndex
        {
            get { return oldIndex; }
            set 
            {
                oldIndex = value;
                OnPropertyChanged("OldIndex");
            }
        }

        private int newIndex;
        public int NewIndex
        {
            get { return newIndex; }
            set 
            {
                newIndex = value;
                OnPropertyChanged("NewIndex");
            }
        }
        
        

        public Foody()
        {
            InitializeComponent();
            this.FoodItems = new ObservableCollection<FoodyClass>();

            this.LoadData(); 
        }

        private void LoadData()
        {
            this.FoodItems.Clear();
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody1.jpg", Title = "Pizza", SubTitle = "fresh backed Pizza & Breads", Order= 0 });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody2.jpg", Title = "Vegan", SubTitle = "high protien vegan dishes", Order = 1 });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody3.jpg", Title = "Chicken & Sauce", SubTitle = "lots of home made sauces", Order = 2});
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody4.jpg", Title = "Burgers", SubTitle = "the big one, cheesy one & the veggy ones too", Order = 3});
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody5.jpg", Title = "French Fries", SubTitle = "need a quick munch? we got you covered", Order = 4});
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody6.jpg", Title = "Samosa", SubTitle = "the best Indian road side dish you can have", Order = 5});
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody7.jpg", Title = "Salads", SubTitle = "french, Indian & Spanish all flaovors", Order = 6});
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody8.jpg", Title = "Crunchies", SubTitle = "easy to cook crunchies", Order = 7});
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody9.jpg", Title = "Eggs", SubTitle = "no recipe app is complete without a few egg dishes", Order = 8 });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody10.jpg", Title = "Gujrati Food", SubTitle = "the best of Indian food for you", Order = 9});
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody11.jpg", Title = "Roadside Food", SubTitle = "samosas again I am now out of ideas to write", Order = 10 });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody12.jpg", Title = "Lemon & Herbs", SubTitle = "for when you need that refreshment!!", Order = 11 });
            this.FoodItems.Add(new FoodyClass { ImageURL = "Foody13.jpg", Title = "Some Stuffed Food", SubTitle = "as if I need to explain what's in the image", Order = 12 });
             

            this.listRecipies.ListDataSource = this.FoodItems; 
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
        public int Order { get; set; }

    }
}
