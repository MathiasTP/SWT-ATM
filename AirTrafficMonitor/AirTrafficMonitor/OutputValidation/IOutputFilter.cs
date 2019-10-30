using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitor.OutputValidation;


namespace AirTrafficMonitor.OutputValidation
{
    interface IOutputFilter
    {
        event EventHandler<LogSeperationEventArgs> LogSeperationEvent;

    }

}