using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitor.Converter;

namespace AirTrafficMonitor.Separation
{
    class SeparationEventArgs : EventArgs
    {
        public SeparationEventArgs(List<Airplane> planesSeparation)
        {
            this.PlanesToSeparate = planesSeparation;
        }
        public List<Airplane> PlanesToSeparate { get; }
    };
}
