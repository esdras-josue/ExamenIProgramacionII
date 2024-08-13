

using Examen_I_Programacion_II;

Asignatura asignatura = new Asignatura();

Console.WriteLine("Ingrese '1' para salir");
Console.WriteLine("Ingrese nombre del alumno:");
asignatura.NombreAlumno = Console.ReadLine();
Console.WriteLine("Ingrese numero de cuenta");
asignatura.NumeroCuenta = Console.ReadLine();
Console.WriteLine("Ingrese correo electronico");
asignatura.Email = Console.ReadLine();
Console.WriteLine("Ingrese nombre de la clase:");
asignatura.NombreAsignatura = Console.ReadLine();
Console.WriteLine("Ingrese horario de la clase:");
asignatura.Hora = Console.ReadLine();
Console.WriteLine("Ingrese nombre del docente:");
asignatura.NombreDocente = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("**************************");
Console.WriteLine();

try 
{
    Console.WriteLine("Ingrese nota primer parcial");
    asignatura.N1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese nota del segundo parcial");
    asignatura.N2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese nota del tercer parcial");
    asignatura.N3 = int.Parse(Console.ReadLine());

    bool notaValida = true;

    if (asignatura.N1 > 30 || asignatura.N2 > 30)
    {
        Console.WriteLine("La nota del primer o segundo parcial sobrepasa el 30%.");
        notaValida = false;
    }

    if(asignatura.N3 > 40)
    {
        Console.WriteLine("La nota del tercer parcial sobrepasa del 40%.");
        notaValida = false;
    }

    Console.WriteLine();
    Console.WriteLine("**************************");
    Console.WriteLine();

    if (notaValida)
    {
        asignatura.Imprimir();
    }
    else 
    {
        Console.WriteLine("Notas no validas");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Una de las notas ingresadas no tiene el formato valido.");
    Console.WriteLine(ex.Message);
    Console.WriteLine();
}



