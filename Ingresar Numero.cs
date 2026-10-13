 System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
public class HelloWorld
{
    public static void Main(string[] args) { 
        int numero;using
        int suma;
        int contador = 0;

        do {
            Console.WriteLine("Ingrese un Numero (0 para salir)");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                suma += numero;
                contador++;

            }
            
            

        }while(numero != 0);

        Console.WriteLine($"\nSuma Total: {suma}");
        Console.WriteLine($"Cantidad de numero es: {contador}");

        if (contador > 0)
        {
            Console.WriteLine($"promedio: {(double)suma/contador: F2}");
        }
        else { Console.WriteLine($"No se ingresaron numeros.");
        }

        

    }
}
