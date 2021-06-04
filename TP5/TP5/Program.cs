using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto1();
            Punto2();
            Punto3();
        }
        public static void Punto1()
        {
            int aux, numero;
            int inverso = 0;
            string cadena;

            Console.WriteLine("ingrese un numero : ");
            cadena = Console.ReadLine();

            numero = Convert.ToInt32(cadena);

            if (numero > 0)
            {
                while (numero > 0)
                {
                    aux = numero % 10;
                    numero = numero / 10;
                    inverso = inverso * 10 + aux;
                }

                Console.WriteLine("El numero ingresado, al invertirlo queda como: " + inverso);
            }
            else
            {
                Console.WriteLine("El numero ingresado es menor a 1, no se invertira.");
            }

        }
        public static void Punto2()
        {
            int numeroA, numeroB;
            float resultado;
            string operador;

            Console.WriteLine("ingrese la operacion siguiendo el siguiente orden: numero, enter operador, enter numero");

            numeroA = Convert.ToInt32(Console.ReadLine());
            operador = Console.ReadLine();
            numeroB = Convert.ToInt32(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    resultado = numeroA + numeroB;
                    Console.WriteLine(resultado);
                    break;
                case "-":
                    resultado = numeroA - numeroB;
                    Console.WriteLine(resultado);
                    break;
                case "*":
                    resultado = numeroA * numeroB;
                    Console.WriteLine(resultado);
                    break;
                case "/":
                    resultado = numeroA / numeroB;
                    Console.WriteLine(resultado);
                    break;
            }

        }
        public static void Punto3()
        {

        }
    }

}
