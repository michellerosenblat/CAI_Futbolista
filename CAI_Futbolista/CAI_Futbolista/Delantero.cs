﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Futbolista
{
    class Delantero : Futbolista
    {
        public Delantero(string nombre, string equipo) : base(nombre, equipo) { }

        public override int GolesPorPartido()
        {
            return 3;
        }
        
    }
}
