using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirTrafficMonitor.OutputLogger
{
   public class LogSeperationEventArgs : IOutputFilter
   {
       public LogSeperationEventArgs(List<Airplane> ap);
       public planesToLog List<Airplane>();

   }
}