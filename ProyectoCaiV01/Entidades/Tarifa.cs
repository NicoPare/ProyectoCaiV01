﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiV01.Entidades
{
    public class Tarifa
    {
        public string TipoPasajero { get; set; }
        public string ClaseVuelo { get; set; }
        public int DisponibilidadVuelo { get; set; }
        public decimal Precio { get; set; }
    }
}
