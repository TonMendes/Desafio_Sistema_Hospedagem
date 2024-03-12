using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Sistema_Hospedagem.Entities
{
    public class Suite
    {
        public Suite(string tipo, int capacidade, decimal diaria)
        {
            TipoSuite = tipo;
            Capacidade = capacidade;
            Diaria = diaria;
        }


        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal Diaria { get; set; }

    }
}
