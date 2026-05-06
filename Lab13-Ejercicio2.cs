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
        Console.WriteLine("===== INFORMACION DEL VEHICULO =====");
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Anio: " + anio);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Placa: " + placa);
    }
}

class Program
{
    static void Main()
    {
        Vehiculo vehiculo1 = new Vehiculo();

        vehiculo1.marca = "Toyota";
        vehiculo1.modelo = "Corolla";
        vehiculo1.anio = 2020;
        vehiculo1.color = "Rojo";
        vehiculo1.placa = "P123ABC";

        vehiculo1.MostrarInformacion();

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
