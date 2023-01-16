using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;

namespace TestWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CustomService.svc or CustomService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CustomService : ICustomService
    {
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public string DoWork(int data)
        {
            return "This is a test";
        }
    }
}
