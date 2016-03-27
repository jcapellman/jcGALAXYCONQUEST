using System;
using System.Runtime.Serialization;

namespace jcGALAXYCONQUEST.PCL.Transports.SaveGames {
    [DataContract]
    public class SaveGame : BaseTransport {
        [DataMember]
        public DateTime TimeStamp { get; set; }
    }
}