using System.Threading.Tasks;

using Windows.ApplicationModel.Activation;
using jcGALAXYCONQUEST.UWP.Services.SettingsServices;

namespace jcGALAXYCONQUEST.UWP {
    sealed partial class App : Template10.Common.BootStrapper {
        public App() {
            InitializeComponent();
         
            #region App settings

            var _settings = SettingsService.Instance;
            RequestedTheme = _settings.AppTheme;
            CacheMaxDuration = _settings.CacheMaxDuration;
            ShowShellBackButton = _settings.UseShellBackButton;

            #endregion
        }
        
        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args) {
            NavigationService.Navigate(typeof(Views.MainMenu));
            await Task.CompletedTask;
        }
    }
}