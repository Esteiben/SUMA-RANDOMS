/*Generar un número aleatorio N entre 0 y 20, luego realizar un ciclo para generar 2 número P y Q hasta que P + Q = N. 
 * Ejemplo: N=15, P=3 y Q=10 se repite porque P+Q no es igual a N, si se vuelve a generar P=9 y Q=6 entonces sale del lazo porque P+Q=N. 
 * Se deben de mostrar los valores de N y los que que se van generando de P y Q indicando si cumplen o no la condición.*/
using System;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, P, Q, R;
            Random rnd = new Random();

            for (int i = 0; i < 1; i++)
            {
                N = rnd.Next(21);
                P = rnd.Next(21);
                Q = rnd.Next(21);
                R = P + Q;
                Console.WriteLine("P = {0} ; Q = {1} ; N = {2}", P, Q, N);
                if (P + Q == N )
                {
                    Console.WriteLine("P + Q es igual a N: {0} + {1} = {2}", P, Q, N);
                    break;
                }
                else
                {
                    Console.WriteLine("P + Q NO es igual a N: {0} + {1} = {2}", P, Q, R);
                    i = i-1;
                }
            }
        }
    }
}