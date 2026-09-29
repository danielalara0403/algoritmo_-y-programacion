
using System;

public class HalloWorld {
    //crear un programa que muestre un menu con 3 opciones y ejecute  
    // una accion dependiendo de la opcion seleccionada.
    public static void Main(string[] args) {


        Console.WriteLine("MENU");
        Console.WriteLine("1. saludar");
        Console.WriteLine("2. mostrar fecha");
        Console.WriteLine("3. salir");
        Console.WriteLine("seleccione una opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion) {
            case 1:
                Console.WriteLine("Ingrese su nombre: ");
                string name = Console.ReadLine();

                Console.WriteLine("Ingrese su edad");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su Genero F/M");
                string gender = Console.ReadLine();

                Console.WriteLine("Ingrese su facultad");
                string faculty = Console.ReadLine();

                Console.WriteLine("Ingrese su Programa Academico");
                string promag = Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("La fecha actual es:" + DateTime.Now);

                break;
            case 3:
                Console.WriteLine("programa finalizado!!!");
                break;
            default:
                Console.WriteLine("opcion no Valida!!");
                break;
        }
    }
}
       
