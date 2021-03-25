using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Horarios
{
    class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
