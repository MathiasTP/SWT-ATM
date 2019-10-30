using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirTrafficMonitor.OutputLogger
{
   public class LogSeperationEventArgs : EventArgs
   {
       public LogSeperationEventArgs(List<Airplane> ap)
       {
           get;
           set;
       }

       public planesToLog List<Airplane>()
       {
           get;
           set;
       }

   }
}