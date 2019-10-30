﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor.AirplaneValidation
{
    public interface IAirplaneValidation
    {
        event EventHandler<ValidationEventArgs> ValidationEvent;
    }
}
