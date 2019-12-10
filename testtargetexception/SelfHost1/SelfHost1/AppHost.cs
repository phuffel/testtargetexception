using Funq;
using ServiceStack;
using DataCenterServiceSelfHost.ServiceInterface;
using ServiceStack.Admin;
using System.Collections.Generic;
using ServiceStack.Api.OpenApi;



namespace DataCenterServiceSelfHost
{

    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptySelfHost
    public class AppHost : AppSelfHostBase
    {

        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("DataCenterServiceSelfHost", typeof(FieldValidationServices).Assembly) { 


        }

        /// <summary> typeof(FieldValidationServices).Assembly
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            Plugins.Add(new RequestLogsFeature());
            Plugins.Add(new AdminFeature());
            Plugins.Add(new AutoQueryFeature { MaxLimit = 100 });
            Plugins.Add(new OpenApiFeature());


        }
    }
}
