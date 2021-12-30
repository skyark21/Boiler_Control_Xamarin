using Boiler_Control_Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Boiler_Control_Xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}