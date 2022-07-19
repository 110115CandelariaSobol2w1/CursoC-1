using System;

namespace trabajo_final
{
    class Program
    {
        static void Main(string[] args)
        {
            //             Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.A partir de dichos datos informar:

            //              a.El mayor de los números pares. *********
            //              b.La cantidad de números impares. *********
            //              c.El menor de los números primos.

            //              Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o 
            //              false según corresponda.

            int n, mayorPar, impares = 0, menorPrimos;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            menorPrimos = n;
            mayorPar = n;

            while (n != 0)
            {
                
                if (n % 2 != 0)
                {
                  impares++;
                } else if (n > mayorPar)

                 {
                     mayorPar = n;
                 }

                 if (primo(n))
                 {
                     if (n < menorPrimos)
                        menorPrimos = n;
                 }

                Console.WriteLine("Ingrese otro numero");
                n = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("El mayor de los numeros pares es " + mayorPar);
            Console.WriteLine("La cantidad de numeros impares es " + impares);
            Console.WriteLine("El menor de los numeros primos es " + menorPrimos);

        }

        static bool primo(int a)
        {
            int con = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a / i == 0)
                {
                    con++;
                }

            }

            if (con == 0)
                return true;
            else
                return false;
        }
    }
}
