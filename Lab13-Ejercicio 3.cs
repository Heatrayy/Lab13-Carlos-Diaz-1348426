using System;

class Producto
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;

    public void MostrarInformacion()
    {
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Precio: Q" + precio);
        Console.WriteLine("Stock: " + stock);
        Console.WriteLine("Disponible: " + disponible);
        Console.WriteLine();
    }
}
