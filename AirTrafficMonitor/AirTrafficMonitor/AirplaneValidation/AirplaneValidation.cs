using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitor.Converter;

namespace AirTrafficMonitor.AirplaneValidation
{
    class AirplaneValidation 
    {
        private IAirplaneValidation _receiver;
        private List<Airplane> Validated;

        public AirplaneValidation(IAirplaneValidation receiver)
        {
            this._receiver = receiver;

            this._receiver.ValidationEvent += Validate;
        }

        private void Validate(object s, ValidationEventArgs e)
        {
            Validated = e.PlanesToValidate;

            foreach (var data in e.PlanesToValidate)
            {
                
            }
        }
    }
}
