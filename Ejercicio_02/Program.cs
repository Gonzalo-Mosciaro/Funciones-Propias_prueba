using System.Reflection.Metadata.Ecma335;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1)
            string palabra;
            bool respuesta;

            palabra = pedirCadena("Ingrese una palabra: ");
            respuesta= verificarLargoPalabra(palabra, 8);

            if(respuesta == true)
            {
                Console.WriteLine("La palabra contiene mas de 8 caracteres");
            }
            else
            {
                Console.WriteLine("La palabra contiene menos de 8 caracteres");
            }*/

            /* 2)
            int numero;

            numero = Ingresar("Ingrese un numero: ");

            determinarPrimo(numero);*/

            int numero;

            numero = Ingresar("Ingrese un valor: ");

            aumentoValor(numero, 80);

        }


        /*1)Crear una función que evalúe si una palabra es corta o larga. 
        Se considera larga si tiene más de 8 caracteres.*/
        static bool verificarLargoPalabra(string palabra, int largoPalabra)
        {
            bool respuesta;
            respuesta = false;

            if(palabra.Length> largoPalabra)
            {
                respuesta = true;
            }

            return respuesta;
        }

        static string pedirCadena(string mensaje)
        {
            string palabra;

            Console.Write(mensaje);
            palabra = Console.ReadLine();

            return palabra;
        }


        /* 2. Crear una función que determine si el número recibido por parámetro es primo o no.*/

        static int determinarPrimo(int numero)
        {
            int auxiliar;
            int sumaRestos;

            sumaRestos = 0;

            for (int i = 1; i <= numero; i++)
            {
                auxiliar = numero % i;

                if (auxiliar == 0)
                {
                    sumaRestos = sumaRestos + 1;
                }
            }

            if (sumaRestos <= 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo!!");
            }
            return numero;
        }
        static int Ingresar(String mensaje)
        {
            int numero;
            Console.WriteLine($"{mensaje}");
            numero = int.Parse(Console.ReadLine());

            return numero;


        }

        /* 3. Se requiere la creación de una función que cumpla con los siguientes requisitos:
           La función debe recibir tres parámetros: 'valor' (numérico), 'porcentaje' (numérico) 
           y 'esAumento' (booleano).
           Si el parámetro 'esAumento' es verdadero, la función debe aumentar el 'valor' 
           original aplicando el 'porcentaje' dado. 
           Si el parámetro 'esAumento' es falso, la función debe disminuir el 'valor' original 
           aplicando el 'porcentaje' dado. 
           El resultado obtenido después de aplicar el porcentaje al 'valor' original debe 
           ser retornado por la función.*/

        static int aumentoValor(int valor, int porcentaje)
        {
            bool aumento = false;
            int aumentando;
            int disminuyo;

            if (valor < (valor + (valor * porcentaje / 100)))
            {
                aumento = true;
                aumentando = valor + (valor * porcentaje / 100);
                Console.WriteLine($"{aumentando}");
            }
            else
            {
                disminuyo = valor - (valor * porcentaje / 100);
                Console.WriteLine($"{disminuyo}");
            }
            return valor;
        }
    }
}
