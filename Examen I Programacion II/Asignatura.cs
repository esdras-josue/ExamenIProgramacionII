using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_I_Programacion_II
{
    public class Asignatura : Alumno , IAsignatura
    {
        public int N1;
        public int N2;
        public int N3;
        public string NombreAsignatura {  get; set; }
        public string Hora { get; set; }
        public string NombreDocente { get; set; }

        double notaFinal;

        public double CalcularNotaFinal()
        {
            double notaUno = N1;
            double notaDos = N2;
            double notaTres = N3;

            notaFinal = notaUno + notaDos + notaTres;
            return notaFinal;
        }

        public double CalcularNotaFinal(double notaUno, double notaDos, double notaTres)
        {
            notaUno = N1;
            notaDos = N2;
            notaTres = N3;

            notaFinal = notaUno + notaDos + notaTres;
            return notaFinal;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            /*De 0% a 59%: Reprobado
            De 60% a 79%: Bueno
            De 80% a 89%: Muy Bueno
            De 90% a 100% Sobresaliente*/

            if (notaFinal >= 0 && notaFinal <= 59)
            {
                return "Reprobado";
            }
            else if (notaFinal >= 60 && notaFinal <= 79)
            {
                return "Bueno";
            }
            else if (notaFinal >= 80 && notaFinal <= 89)
            {
                return "Muy Bueno";
            }
            else if (notaFinal >= 90 && notaFinal <= 100)
            {
                return "Sobresaliente";
            }

            return notaFinal.ToString();
           
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Numero de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electronico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Hora}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota final: {CalcularNotaFinal()} - {MensajeNotaFinal(notaFinal)}");
            Console.WriteLine($"Nota final: {CalcularNotaFinal(N1,N2,N3)} - {MensajeNotaFinal(notaFinal)}");
        }

    }
}
