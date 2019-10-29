using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor.AirplaneValidation
{
    class Airspace : IAirspace
    {
        private int _xplane;
        private int _yplane;
        private int _zLow;
        private int _zHigh;

        Airspace()
        {
           _xplane = 80000;
           _yplane = 80000;
           _zLow = 20000;
          _zHigh = 90000;
    }

        int[] IAirspace.getAirspaceLimits()
        {
            int[] temp = new int[3];
            temp[0] = _xplane;
            temp[1] = _yplane;
            temp[2] = _zLow;
            temp[3] = _zHigh;
            return temp;
        }
    }
}
