using System.Xml;

namespace FuncionesPropias_01
{
    internal class Program
    {


        static int Ingresar(String mensaje)
        {
            int numero;
            Console.WriteLine($"{mensaje}");
            numero = int.Parse(Console.ReadLine());

            return numero;
        }
        static int Sumar(int unNumero, int otroNumero)
        {
            int suma;
            suma = unNumero + otroNumero;

            return suma;
        }



        static void Main(string[] args)
        {
            int unNumero;
            int otroNumero;
            int suma;

            unNumero = Ingresar("Ingrese el numero deseado: ");
            otroNumero = Ingresar("Ingrese otro numero: ");

            suma = Sumar(unNumero, otroNumero);

            Console.WriteLine($"{suma}");
        }
    }
}