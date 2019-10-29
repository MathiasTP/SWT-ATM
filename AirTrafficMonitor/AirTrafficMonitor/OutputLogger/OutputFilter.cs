using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirTrafficMonitor.OutputLogger
{
    class OutputFilter : IOutputFilter
    {
        public event EventHandler<LogSeperationEventArgs> LogSeperationEvent;
        public void LogPlanes(List<Airplane>);
        public void CleanUp();

        private ILogger _consoleLogger;
        private Ilogger _ILogger;
    }
}