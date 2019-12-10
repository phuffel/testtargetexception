using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Timers;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace DataCenterServiceSelfHost
{
    class DataCenterService
    {
        private readonly Timer _ServiceTimer;

        public DataCenterService()
        {
            var appSettings = ConfigurationManager.AppSettings;


            _ServiceTimer = new Timer(50000) { AutoReset = true };
            _ServiceTimer.Elapsed += _ServiceTimer_Elapsed; /* create event */

        }

        public void Start()
        {
            _ServiceTimer.Start();

            new AppHost().Init().Start("http://*:8088/");
            "ServiceStack Self Host listening at http://127.0.0.1:8088".Print();

        }

        public void Stop()
        {
            // write code here that runs when the Windows Service stops.  
            _ServiceTimer.Stop();

        }

        private void _ServiceTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

        }

    }
}
