using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirTrafficMonitor.OutputLogger
{
    interface IOutputFilter
    {
        event EventHandler<LogSeperationEventArgs> LogSeperationEvent;

    }
}