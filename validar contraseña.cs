using System;
using System.Security.Claims;
public class HelloWorld
{
    public static void Main(string[] args)
    {

        const string passCorrecta = "admin123";
        string clave;
        int intentosFallidos = 0;

        do
        {
            Console.WriteLine("Ingrese la contraseña: ");
            clave = Console.ReadLine();
            if (clave != passCorrecta)
            {
                intentosFallidos++;
                Console.WriteLine("contraseña Incorrecta. Intentalo de nuevo.");
            }

        } while (clave != passCorrecta);
        Console.WriteLine($"\n Acceso concedido.");
        Console.WriteLine($"Intentos Fallidos: {intentosFallidos}");


    }
}
