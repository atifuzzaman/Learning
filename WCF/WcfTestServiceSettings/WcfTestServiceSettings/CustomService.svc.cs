using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace WcfTestServiceSettings
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CustomService.svc or CustomService.svc.cs at the Solution Explorer and start debugging.
    public class CustomService : ICustomService
    {
        //
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest, Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public string DoWork()
        {
            return  "this is a test" ;
        }
    }

    public class MyObject
    {
        public string data { set; get; }
    }
}
