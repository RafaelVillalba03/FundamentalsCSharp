using System;

namespace FundamentalsCSharp
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            string user_response;
            string user_text;
            string opcion1_response;
            string opcion2_response;
            string opcion3_response;
            bool exit = false;

            while (exit == false)
            {

                Console.WriteLine("***********************************************************");
                Console.WriteLine("*Introduzca una cadena de texto con al menos 40 caracteres*");
                Console.WriteLine("***********************************************************");

                do
                {
                    user_text = Console.ReadLine();

                    if (user_text.Length < 40)
                    {
                        Console.WriteLine($"La cadena introducida posee únicamente {user_text.Length} caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres: ");
                    }
                }

                while (user_text.Length < 40);


                Console.WriteLine("********************************************************************");
                Console.WriteLine("*Texto enviado con éxito, ¿Qué desea hacer ahora? Inserte un número*");
                Console.WriteLine("*Inserte 1 para Sustituir palabra                                  *");
                Console.WriteLine("*Inserte 2 para Buscar palabra en el texto                         *");
                Console.WriteLine("*Inserte 3 para Buscar palabra en el inicio del texto              *");
                Console.WriteLine("*Inserte 4 para Salir del programa                                 *");
                Console.WriteLine("********************************************************************");

                user_response = Console.ReadLine();

                while (user_response != "1" && user_response != "2" && user_response != "3" && user_response != "4")
                {
                    Console.WriteLine("Inserte de nuevo únicamente una opción existente:");
                    user_response = Console.ReadLine();
                }

                switch (user_response)
                {
                    case "1":
                        Console.WriteLine("Introduce nueva palabra de la siguiente forma: ");
                        Console.WriteLine("antiguapalabra nuevapalabra");
                        opcion1_response = Console.ReadLine();
                        String[] Opcion1_Palabras = opcion1_response.Split(" ");
                        // aquí debería comprobar si existe esta palabra o no, pero vamos a dar por hecho de que sí
                        user_text = user_text.Replace(Opcion1_Palabras[0], Opcion1_Palabras[1]);
                        Console.WriteLine("Completado! Su texto editado es el siguinete:");
                        Console.WriteLine(user_text);
                        break;

                    case "2":
                        Console.WriteLine("Introduce la palabra a buscar en el texto introducido:");
                        opcion2_response = Console.ReadLine();
                        if (user_text.Contains(opcion2_response))
                        {
                            Console.WriteLine($"La palabra {opcion2_response} ha sido encontrada con éxito!");
                        }
                        else
                        {
                            Console.WriteLine($"No se ha podido encontrar {opcion2_response} en el texto");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Introduce la palabra que inicia el texto introducido:");
                        opcion3_response = Console.ReadLine();
                        if (user_text.StartsWith(opcion3_response))
                        {
                            Console.WriteLine($"La palabra {opcion3_response} ha sido encontrada con éxito al inicio del texto!");
                        }
                        else
                        {
                            Console.WriteLine($"La palabra {opcion3_response} no es la primera palabra del texto o no existe");
                        }
                        break;

                    case "4":
                        exit = true;
                        break;
                }
            }
                      

        }
    }
}