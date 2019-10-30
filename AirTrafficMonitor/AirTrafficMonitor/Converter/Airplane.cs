using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor.Converter
{
    public class Airplane
    {
        public Airplane(string tag, double velocity, int course, List<Tracks> tracks, bool SeperationCodition)
        {

        }
        private string _tag { get; set; }

        private double _velocity { get; set; }

        private int _compasCourse { get; set; }

        private List<Tracks> _tracks { get; set; }

        private bool _seperationCodition { get; set; }
    }
}
