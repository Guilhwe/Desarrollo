using System;
namespace Pac_Desarrollo_Entrega_1S2425
{
    public class Program
    {
        static void Main( string[] args)
        {
            // Recoger por consola un numero entero y validar su valor. Tiene que estar comprendido entre 7 y 22 incluidos
            int numero = 0;
            bool valido= false;
            do
            {

                Console.WriteLine("Ingrese un numero entre 7 y 22: ");
                if (int.TryParse(Console.ReadLine(), out numero) && numero >= 7 && numero <= 22)
                {
                    valido = true;
                    
                }
                else
                {
                    Console.WriteLine("Numero inválido. Elija otro número. ");
                }


                
            } while (!valido);
            
            
            Console.WriteLine($"La secuencia de Fibonacci tendrá {numero} numeros");

            // crear la secuencia de fibonacci con tantos valores como el numero elegido
            List<int> fibonacci = CrearFibonacci(numero);
            foreach (var num in fibonacci)
            {
                Console.WriteLine(num + "");
            }
            Console.WriteLine("La secuencia del reves seria: ");
            //crear la inversion para la cual contamos los numeros desde el final -1 pues no existe mientras que la posicion de i sea mayor o igual que 0
            for (int i = fibonacci.Count-1;i>= 0; i--)
            {
                Console.WriteLine(fibonacci[i] + " ");
            }

            //Crea el METODO de la sucesion de fibonacci añadiendo los dos primeros numero 0 y 1 y que se hagan las operaciones futuras partiendo de ellos.
            List<int> CrearFibonacci (int numero)
            {
                List<int>fibonacci = new ();
                for (int i=0; i<numero; i++)
                {
                    if (i == 0)
                    {
                        fibonacci.Add(i);
                    }
                    else if (i == 1)
                    {
                        fibonacci.Add(i);
                    }
                    else
                    {
                        int siguienteNumero = fibonacci[i - 1] + fibonacci[i - 2];
                        fibonacci.Add(siguienteNumero);
                    }

                }
                return fibonacci;
            }
            
        }
    }
}
