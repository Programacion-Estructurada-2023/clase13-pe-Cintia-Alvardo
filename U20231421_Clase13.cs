using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For //Foreach

            //Caso simple

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"El número {i}");
            } //Fin for 


            //ELAVORAR UNA TABLA DE MULTIPLICAR DE NÚMERO N
            Console.WriteLine("\nInrese un número para elborar su tabla de multiplicar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int multiplicación = numero * i;
                Console.WriteLine($"\n{numero} x {i} = {multiplicación}");
            }


            //Foreach

            //Declaraar una lista

            List<int> numeros = new List<int> { 24, 10, 8, 35, 14, 7 };

            int minimo = numeros[0]; //Inicializar con valor del indice 0

            foreach (int numero1 in numeros)
            {
                if (numero1 < minimo)
                {
                    minimo = numero1; //Actualizar el valor minimo
                }
            }

            Console.WriteLine("El número mas pequeño en la lista es > " + minimo);

            //VALORES POR ITERACIONES
            //1 NUMERO VALDRIA 24 MINIMO 24    //Comparamos minimo = 24
            //2 NUMERO = 10 MINIMO 24         //Comparamos minimo = 10    
            //3 NUMERO = 8 MINIMO 10          //Comparamos minimo = 8
            //4 NUMERO = 35 MINIMO 8          //Comparamos minimo = 8
            //5 NUMERO = 14 MINIMO 8          //Comparamos minimo = 8
            //6 NUMERO = 7 MINIMO 8          //Comparamos minimo = 7

            Console.ReadKey();
        }
    }
}
