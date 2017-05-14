using Space.Models;
using Space.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Space.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonkeysPage : ContentPage
    {
        public MonkeysPage()
        {
            InitializeComponent();
            BindingContext = new UniversitiesViewModel();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var university = ((ListView)sender).SelectedItem as University;
            if (university == null)
                return;
        }
    }
}