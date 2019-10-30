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


        public void LogPlanes(List<Airplane> ap)
        {
            if (ap != _oldplane)
            {
                OnLogSeperationEventArgs(new LogSeperationEventArgs {PlanestoLog = ap});
                _oldplane = ap;
            }
        }

        protected virtual void OnLogSeperationEventArgs(LogSeperationEventArgs e)
        {
            LogSeperationEvent?.Invoke(this, e);
        }

        public void CleanUp();
    }
}