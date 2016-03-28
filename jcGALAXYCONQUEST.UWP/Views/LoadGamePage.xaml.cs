using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using jcGALAXYCONQUEST.UWP.ViewModels;

namespace jcGALAXYCONQUEST.UWP.Views {
    public sealed partial class LoadGamePage : Page {
        private LoadGameViewModel viewModel => (LoadGameViewModel) DataContext;

        public LoadGamePage() {
            this.InitializeComponent();

            DataContext = new LoadGameViewModel();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e) {
            var result = await viewModel.LoadData();
        }
    }
}