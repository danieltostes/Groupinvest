﻿using System;

namespace GroupInvest.Microservices.Mensalidades.Application.Models.Dtos
{
    public class AuditoriaDto
    {
        public DateTime Timestamp { get; set; }
        public int AgregadoId { get; set; }
        public string Agregado { get; set; }
        public string Operacao { get; set; }
        public string Conteudo { get; set; }
    }
}
