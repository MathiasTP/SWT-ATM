using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitor.Converter;

namespace AirTrafficMonitor.Separation
{
    class CheckSeparationCondition : ICheckSeparationCondition
    {
        private ICheckSeparationCondition _reciever;
        private List<IAirplane> separated;
        public event EventHandler<SeparationEventArgs> SeparationEvent;

        public CheckSeparationCondition()
        {

        }

        protected virtual void OnSeparationEvent(SeparationEventArgs e)
        {
            SeparationEvent?.Invoke(this, e);
        }

        public void OnPlanesToLog(SeparationEventArgs j)
        {

        }
    }
}