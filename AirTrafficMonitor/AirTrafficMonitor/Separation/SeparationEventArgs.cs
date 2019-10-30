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
        public SeparationEventArgs(List<Airplane> PlanesSeparated)
        {
            this.PlaneConditionChecked = PlanesSeparated;
        }
        public List<Airplane> PlaneConditionChecked { get; set; }
    };
}
