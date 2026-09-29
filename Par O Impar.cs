using System;
using System.ComponentModel.Design;

public class HelloWorld
{
    // pide un numero al usuario y determina si es par o impar
    public static void Main(string[] args)
    {
        Console.Write("Ingrese un numero; ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero es par .");
        }
        else
        {
            Console.WriteLine("El numero es impar .");


        }
    }
}
