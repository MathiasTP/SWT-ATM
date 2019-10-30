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
        private int _minDistance;
        private int _maxDistance;
        private int _minAltitude; 
        public event EventHandler<PlaneConditionCheckedEventArgs> PlaneConditionChecked;

        public CheckSeparationCondition()
        {

        }

        protected virtual void OnSeparationEvent(PlaneConditionCheckedEventArgs e)
        {
            PlaneConditionChecked?.Invoke(this, e);
        }

        public void OnPlanesToLog(PlaneConditionCheckedEventArgs e)
        {

        }
    }
}