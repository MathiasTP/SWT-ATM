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
                List<Tracks> temp = data._tracks;

                if (stats[0] > temp[0]._xCoordiante && stats[1] < temp[0]._xCoordiante)
                {
                    if (stats[2] > temp[0]._yCoordiante && stats[3] < temp[0]._yCoordiante)
                    {
                        if (stats[4] > temp[0]._Altitude && stats[5] < temp[0]._Altitude)
                        {
                            Validated.Add(data);
                        }
                    }
                }
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
