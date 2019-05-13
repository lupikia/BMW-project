using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReplicationLibrary.Post_Function
{
    [DataContract]
   public class BackUpData
    {
        [DataMember]
        public string source { get; set; }
        [DataMember]
        public string destination { get; set; }
        [DataMember]
        public bool includeSubDirectory { get; set; }
        [DataMember]
        public bool cleanDestination { get; set; }
    }
}
