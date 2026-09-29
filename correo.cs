using System;

internal class Program{
    
    static void Main(string[] arg){

        
        string correoCorrecto = "dalara@unicaribe.edu.co";
        string passCorrecta = "DA12345";

        string email = "";
        string pass = "";

        int intentos = 0;
        while (intentos < 3){

            Console.WriteLine("Ingrese su correo: ");
            email = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña: ");
            pass = Console.ReadLine();

            if (email == correoCorrecto && pass == passCorrecta){
                Console.WriteLine("Binevenido a la plataforma de UNICARIBE!!");
                break;
            }else
            {
                intentos++;
                Console.WriteLine("Correo o Contraseña INCORRECTOS!!");
                Console.WriteLine("Intentos Restantes: " + (3 - intentos));
            }

                if (intentos ==3)
                    {
                Console.WriteLine("usuario bloqueado - comunicate con T.IUNICARIBE");
        }
    }
}
}
                    
                                  
