using App4.ViewModels;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CountViewModel countViewModel = new CountViewModel();
            BindingContext = countViewModel;
        }
    }
}
