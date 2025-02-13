﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GroupInvest.Microservices.AppUsuarios.Domain.Entidades
{
    public class PagamentoEmprestimo
    {
        public DateTime DataPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal PercentualJuros { get; set; }
        public decimal ValorJuros { get; set; }
        public decimal ValorDevido { get; set; }
        public decimal SaldoAtualizado { get; set; }
    }
}
