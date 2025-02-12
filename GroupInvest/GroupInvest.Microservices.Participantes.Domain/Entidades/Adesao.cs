﻿using GroupInvest.Common.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupInvest.Microservices.Participantes.Domain.Entidades
{
    public class Adesao : Entidade<int>
    {
        public Participante Participante { get; set; }
        public Periodo Periodo { get; set; }
        public int NumeroCotas { get; set; }
        public DateTime DataAdesao { get; internal set; }
        public DateTime? DataCancelamento { get; set; }
    }
}
