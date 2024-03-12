using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Sistema_Hospedagem.Entities
{
    public class Reserva
    {
        public Reserva(int reserva)
        {
            DiasReservados = reserva;
        }

        public List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite suite { get; set; }
        public int DiasReservados {  get; set; }


        public void CadastrarHospedes(List<Pessoa> pessoas)
        {
            Hospedes = pessoas;
        }

        public void CadastrarSuite(Suite suites)
        {
            suite = suites;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal ValorDiaria()
        {
            if(DiasReservados >= 10)
            {
                return suite.Diaria * DiasReservados; 
            }
            else
            {
                return suite.Diaria * DiasReservados;
            }
        }
    }
}
