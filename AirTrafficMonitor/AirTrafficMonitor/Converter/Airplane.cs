﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor.Converter
{
    public class Airplane : IAirplane
    {
        public Airplane(string tag, double velocity, int course, List<Tracks> tracks, bool SeperationCodition)
        {

        }
        public string _tag
        {
            get => _tag;
            set => _tag = value;
        }

        public double _velocity
        {
            get => _velocity; 
            set => _velocity = value;
        }

        public int _compasCourse {
            get => _compasCourse;
            set => _compasCourse = value;
        }

        public List<Tracks> _tracks {
            get => _tracks;
            set => _tracks = value;
        }

        public bool _seperationCodition {
            get => _seperationCodition;
            set => _seperationCodition = value;
        }
        
    }
}
