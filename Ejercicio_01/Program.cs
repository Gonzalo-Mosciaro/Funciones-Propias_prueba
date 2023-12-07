namespace Ejercicio_01
{
    internal class Program
    {

        /* Gonzalo Mosciaro.
         * Pedir al usuario que valide el numero de legado (1-1000) y el sueldo (10000-100000). 
         * Calcular cuanto es el aguinaldo del sueldo y sumarlo al mismo*/

        static int Sumar(int unNumero, int otroNumero)
        {
            int suma;
            suma = unNumero + otroNumero;

            return suma;
        }
        static int Division(int unNumero, int otroNumero)
        {
            int division;
            division = unNumero / otroNumero;

            return division;
        }
        static int Validacion(int unNumero, int primerNumero, int segundoNumero, String mensaje/*, String mensajeDos*/)
        {

            while (unNumero < primerNumero || unNumero > segundoNumero)
            {
                Console.WriteLine($"{mensaje}");
                unNumero = int.Parse( Console.ReadLine() );
            }

            /*Console.WriteLine($"{unNumero}");*/

            return unNumero;
        }
        static int Ingresar(String mensaje)
        {
            int numero;
            Console.WriteLine($"{mensaje}");
            numero = int.Parse(Console.ReadLine());

            return numero;
        }
        static void Main(string[] args)


        {
            int legajo;
            int sueldo;
            int aguinaldo;
            int total;

            legajo = Ingresar("Ingrese el numero de legajo: ");
            Validacion(legajo, 1, 1000, "Reingrese el numero de legajo");


            sueldo = Ingresar("Ingrese un sueldo: ");
            Validacion(sueldo, 10000, 100000, "Reingrese el sueldo");


            aguinaldo = Division(sueldo, 2);

            total = Sumar(sueldo, aguinaldo);

            Console.WriteLine($"El numero de legajo es {legajo}, que gana un sueldo de ${sueldo}, " +
                $"con un aguinaldo de ${aguinaldo} que en su total da ${total}");



            
        }
    }
}
