using System;

namespace Strings_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string inicial = "ave, banco, comida, duda, ejercicio, fuente, girasol";
            string coma = ",";
            //FUENTE;EJERCICIO;DUDA;COMIDA;BANCO
            System.Console.WriteLine(inicial);
            inicial += coma;

            inicial = inicial.Replace(",", ";");
            inicial = inicial.ToUpper();

            string[] inicialArray = inicial.Split(" ");
            
            for(int i = inicialArray.Length - 2; i > 0; i--)
            {
                System.Console.Write(inicialArray[i]);
            }
        }
    }
}
