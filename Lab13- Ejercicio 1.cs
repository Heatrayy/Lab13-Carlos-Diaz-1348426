using System;

class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;

    public void MostrarInformacion()
    {
        Console.WriteLine("===== EJERCICIO 1 - PERSONA =====");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Altura: " + altura + " metros");
        Console.WriteLine("Estudiante: " + estudiante);
        Console.WriteLine();
    }
}
