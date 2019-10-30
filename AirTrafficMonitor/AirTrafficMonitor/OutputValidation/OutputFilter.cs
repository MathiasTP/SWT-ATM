using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitor.Converter;
using AirTrafficMonitor.Logger;


namespace AirTrafficMonitor.OutputValidation
{
    class OutputFilter : IOutputFilter
    {
        private ILogger _consoleLogger;
        private ILogger _ILogger;
        private List<Airplane> _oldplane;


        public event EventHandler<LogSeperationEventArgs> LogSeperationEvent;


        public void LogPlanes(List<Airplane> ap)
        {
            if (ap != _oldplane)
            {
                OnLogSeperationEventArgs(new LogSeperationEventArgs { planesToLog = ap });
                _oldplane = ap;
            }
        }

        protected virtual void OnLogSeperationEventArgs(LogSeperationEventArgs e)
        {
            LogSeperationEvent?.Invoke(this, e);
        }

        public void CleanUp()
        {

        }
    }


}