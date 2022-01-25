using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Basics_and_MVVM
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        public async void LstProducts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var  selectedProduct = (TodoItems)e.Item;
            //await DisplayAlert("You selected", selectedProduct.TodoText, "Buy", "Cancel");
        }
    }
}
