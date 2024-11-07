using Examen;

Asignatura asignatura = new Asignatura();
bool verificar = false;
try {
    Console.WriteLine("Ingrese nombre del alumno: ");
    asignatura.NombreAlumno=Console.ReadLine();

    Console.WriteLine("Ingrese número de cuenta: ");
    asignatura.NumeroCuenta = Console.ReadLine();

    Console.WriteLine("Ingrese correo electrónico: ");
    asignatura.Email = Console.ReadLine();

    Console.WriteLine("Ingrese nombre de la clase: ");
    asignatura.NombreAsignatura = Console.ReadLine();

    Console.WriteLine("Ingrese horario de la clase: ");
    asignatura.Horario = Console.ReadLine();

    Console.WriteLine("Ingrese nombre del docente: ");
    asignatura.NombreDocente = Console.ReadLine();

    
    do
    {
        Console.WriteLine();

        Console.WriteLine("Ingrese nota del primer parcial");
        asignatura.N1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese nota del segundo parcial");
        asignatura.N2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese nota del tercer parcial");
        asignatura.N3 = Convert.ToInt32(Console.ReadLine());

        if (asignatura.N1 > 30 || asignatura.N2>30)
        {
            verificar = true;
            Console.WriteLine("La nota del primer o segundo parcial sobrepasa del 30%");
        }else if (asignatura.N3 > 40)
        {
            verificar = true;
            Console.WriteLine("La nota del tercer parcial sobrepasa del 40%");
        }
        else
        {
            verificar = false;
        }

    } while(verificar);

    Console.WriteLine();
    asignatura.Imprimir();

}
catch (FormatException e)
{
    Console.WriteLine("Se genero un mal ingreso, vuelve a intentar");
}catch(Exception e)
{
    Console.WriteLine(e);
}
finally
{
    Console.WriteLine();
    Console.WriteLine("La ejecución del programa a finalizado.");
}




