using ReplicationLibrary.Post_Function;
using ReplicationServiceApplication.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ReplicationLibrary
{
    [ServiceContract]
    public interface IReplication
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        ResponseReplication BackUpForReplication(string source, string destination, bool includeSubDirectory, bool cleanDestination);
        // TODO: Add your service operations here
    }
}