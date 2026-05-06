using System;

class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;

    public void MostrarInformacion()
    {
        Console.WriteLine("===== EJERCICIO 4 - MASCOTA =====");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Especie: " + especie);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Peso: " + peso + " kg");
        Console.WriteLine("Vacunado: " + vacunado);
        Console.WriteLine();
    }
}
