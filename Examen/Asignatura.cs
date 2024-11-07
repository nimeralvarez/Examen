
namespace Examen
{
    public class Asignatura:Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal(int nota1, int nota2, int nota3)
        {
            return nota1 + nota2 + nota3;
        }

        public void Imprimir()
        {
            Console.WriteLine("************************************************************************************");
            Console.WriteLine($"Nombre del estudiante: {this.NombreAlumno}");
            Console.WriteLine($"Número de cuenta: {this.NumeroCuenta}");
            Console.WriteLine($"Correo electrónico: {this.Email}");
            Console.WriteLine($"Nombre de la clase: {this.NombreAsignatura}");
            Console.WriteLine($"Horario: {this.Horario}");
            Console.WriteLine($"Nombre del docente: {this.NombreDocente}");
            double notaFinal1 = this.CalcularNotaFinal(N1, N2, N3);
            Console.WriteLine($"Nota final: {notaFinal1}% - {this.MensajeNotaFinal(notaFinal1)}");
            double notaFinal2 = this.CalcularNotaFinal();
            Console.WriteLine($"Nota final: {notaFinal2}% - {this.MensajeNotaFinal(notaFinal2)}");
            Console.WriteLine("************************************************************************************");
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if(notaFinal>=0 && notaFinal<= 59)
            {
                return "Reprobado";
            }else if(notaFinal>=60 && notaFinal<= 79)
            {
                return "Bueno";
            }else if(notaFinal>=80 && notaFinal <= 89)
            {
                return "Muy Bueno";
            }
            else if(notaFinal>=90 && notaFinal<=100)
            {
                return "Sobresaliente";
            }
            else
            {
                return "Nota final invalida";
            }
        }

        public double CalcularNotaFinal()
        {
            return this.N1 + this.N2 + this.N3;
        }
    }
}
