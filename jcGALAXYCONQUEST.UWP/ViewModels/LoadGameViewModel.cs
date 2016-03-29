using System.Threading.Tasks;

using jcGALAXYCONQUEST.PCL.Constants;
using jcGALAXYCONQUEST.PCL.Transports.SaveGames;
using jcPL.PCL.Implementations;

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
            var fs = new JSONPL(_uwpps);

            var listing = await fs.GetAsync<SaveGameListing>(PLKeys.LOADGAME_SAVE_GAME_LISTING);
            
            SGLising = listing == null ? new SaveGameListing() : listing.Value;

            return true;
        }
    }
}