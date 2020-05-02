using _020.Library.FW.Log;
using _020.Library.FW.TaskScheduling.QuartzNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace _020.WS.FW.Quartz
{
    public partial class Service1 : ServiceBase
    {
        private Logger logger = new Logger(typeof(Service1));

        public Service1()
        {
            InitializeComponent();
            this.logger.Info("This is Service1 ctor start..");
            DispatcherManager.Init().GetAwaiter().GetResult();
            this.logger.Info("This is Service1 ctor end..");
        }

        protected override void OnStart(string[] args)
        {
            this.logger.Info("This is OnStart..");
        }

        protected override void OnStop()
        {
            this.logger.Info("This is OnStop..");
        }
    }
}
