using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace DataCenterServiceSelfHost
{
    internal static class ConfigureService
    {
        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<DataCenterService>(service =>
                {
                    service.ConstructUsing(s => new DataCenterService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                //Setup Account that window service use to run.  
                configure.RunAsLocalSystem();
                configure.SetServiceName("DataCenterService");
                configure.SetDisplayName("DataCenter Service");
                configure.SetDescription("This is the authorative dataset delivery service.");
            });
        }
    }
}
