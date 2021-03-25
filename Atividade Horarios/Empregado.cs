using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Horarios
{
    abstract class Empregado
    {
        public int Matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }
        public string NomeEmpregado
        {
            get { return NomeEmpregado; }
            set { NomeEmpregado = value; }
        }
        public DateTime DataEntradaEmpresa
        {
            get { return DataEntradaEmpresa; }
            set { DataEntradaEmpresa = value; }
        }
        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days);
        }
        public abstract double SalarioBruto();
    }
}
