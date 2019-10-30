using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitor.Converter;
using AirTrafficMonitor.Separation;

namespace AirTrafficMonitor.AirplaneValidation
{
    class AirplaneValidation 
    {
        private IAirplaneValidation _receiver;
        private List<Airplane> Validated;
        private IAirspace _airspace;
        

        public AirplaneValidation(IAirplaneValidation receiver)
        {
            this._receiver = receiver;
            
            this._receiver.ValidationEvent += Validate;
        }

        private void Validate(object s, ValidationEventArgs e)
        {
            Validated = e.PlanesToValidate;
            int[] stats = _airspace.getAirspaceLimits();

            foreach (Airplane data in e.PlanesToValidate)
            {
                //Tracks temptracks = data.GetTracks;
                /*if(int[0] > temptracks. && )
                 
             */
            }

            if (Validated != e.PlanesToValidate)
            {
                OnCheckSeperationCondition(new PlaneConditionCheckedEventArgs(Validated));
            }
        }

        protected virtual void OnCheckSeperationCondition(PlaneConditionCheckedEventArgs e)
        {
            PlaneConditionChecked?.Invoke(this, e);
        }

    }
}
