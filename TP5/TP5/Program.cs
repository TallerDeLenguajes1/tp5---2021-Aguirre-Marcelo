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
            double numero,resultado;
            string operador;

            Console.WriteLine("Ingrese un numero");

            numero= Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("ingrese la opcion que busca: \n1)valorabsoluto \n2)cuadrado \n3)raiz cuadrada \n4)seno \n5)coseno \n6)entero de un flotante");

            operador = Console.ReadLine();

            switch (operador)
            {
                case "1":
                    resultado = Math.Abs(numero);
                    Console.WriteLine(resultado);
                    break;
                case "2":
                    resultado = Math.Pow(numero, 2);
                    Console.WriteLine(resultado);
                    break;
                case "3":

                    resultado = Math.Sqrt(numero);
                    Console.WriteLine(resultado);
                    break;
                case "4":
                    resultado = Math.Sin(numero);
                    Console.WriteLine(resultado);
                    break;
                case "5":
                    resultado = Math.Cos(numero);
                    Console.WriteLine(resultado);
                    break;
                case "6":
                    resultado = Math.Round(numero);
                    Console.WriteLine(resultado);
                    break;
            }
        }
    }

}
