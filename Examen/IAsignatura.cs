
namespace Examen
{
    public interface IAsignatura
    {
        public double CalcularNotaFinal();
        public double CalcularNotaFinal(int nota1, int nota2, int nota3);
        public string MensajeNotaFinal(double notaFinal);
        public void Imprimir();

    }
}
