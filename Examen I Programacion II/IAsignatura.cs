using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_I_Programacion_II
{
    public interface IAsignatura
    {
        public double CalcularNotaFinal();
        public double CalcularNotaFinal(double notaUno, double notaDos, double notaTres);
        public string MensajeNotaFinal(double nota);
        public void Imprimir();
       

    }
}
