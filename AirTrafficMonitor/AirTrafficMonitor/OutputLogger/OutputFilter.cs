using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirTrafficMonitor.OutputLogger
{
    class OutputFilter : IOutputFilter
    { 
        private ILogger _consoleLogger;
        private Ilogger _ILogger;
        private List _oldplane;


        public event EventHandler<LogSeperationEventArgs> LogSeperationEvent;


        public void LogPlanes(List<Airplane> newap)
        {
            if (newap != _oldplane)
            {
                OnLogSeperationEventArgs(new LogSeperationEventArgs {ap = newap});
                _oldplane = newap;
            }
        }

        protected virtual void OnLogSeperationEventArgs(LogSeperationEventArgs e)
        {
            LogSeperationEvent?.Invoke(this, e);
        }

        public void CleanUp();
    }
}