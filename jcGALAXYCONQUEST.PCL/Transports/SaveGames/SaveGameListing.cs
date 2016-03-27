using System.Collections.Generic;
using System.Runtime.Serialization;

namespace jcGALAXYCONQUEST.PCL.Transports.SaveGames {
    [DataContract]
    public class SaveGameListing : BaseTransport {
        [DataMember]
        public List<SaveGame> SaveGames { get; set; } 
    }
}