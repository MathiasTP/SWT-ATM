using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitor.Converter;

namespace AirTrafficMonitor.Separation
{
    public class CheckSeparationCondition : ICheckSeparationCondition
    {
        private ICheckSeparationCondition _reciever;
        private List<IAirplane> separated;

        public CheckSeparationCondition()
        {

        }

        public void OnPlanesToLog(SeparationEventArgs j)
        {

        }
    }
}