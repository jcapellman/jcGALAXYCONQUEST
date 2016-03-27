using System.Threading.Tasks;

using jcGALAXYCONQUEST.PCL.Transports.SaveGames;

namespace jcGALAXYCONQUEST.UWP.ViewModels {
    public class LoadGameViewModel : BaseViewModel {
        private SaveGameListing _saveGameListing;

        public SaveGameListing SGLising {
            get { return _saveGameListing; }
            set {
                _saveGameListing = value;
                Set(ref _saveGameListing, value);
            }
        }

        public async Task<bool> LoadData() {
            return true;
        }
    }
}