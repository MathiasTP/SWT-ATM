using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitor.Converter;


namespace AirTrafficMonitor.OutputValidation
{
    public class LogSeperationEventArgs : EventArgs
    {
        public LogSeperationEventArgs(List<Airplane> ap)
        {


        }


        public List<Airplane> planesToLog
        {
            get;
            set;
        }

    }


}