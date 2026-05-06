using System;

class Vehiculo
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;

    public void MostrarInformacion()
    {
        Console.WriteLine("===== EJERCICIO 2 - VEHICULO =====");
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Año: " + anio);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Placa: " + placa);
        Console.WriteLine();
    }
}
