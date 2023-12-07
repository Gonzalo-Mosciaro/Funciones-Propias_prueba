namespace FuncionesPropias_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string claveIngresada;
            string claveEsperada = "clavevalida";

            claveIngresada = pedirContraseña(claveEsperada, "Ingrese su contraseña: ", "contraseña demasiado corta o incorrecta: ", 11, 3);

            if (claveIngresada != "")
            {
                Console.WriteLine("la clave tiene los  caracteres esperados y es la misma que clave esperada");
            }
        }

        public static int validarEnteroEnRango(string mensajeIngreso, string mensajeError, int valorMinimo, int valorMaximo)
        {

            int numeroValidado;
            string? lectura;
            bool validar;

            Console.Write(mensajeIngreso);

            validar = int.TryParse(Console.ReadLine(), out numeroValidado);

            while (validar == false || numeroValidado < valorMinimo || numeroValidado > valorMaximo)
            {
                Console.WriteLine($"{mensajeError} rango valido({valorMinimo}-{valorMaximo})");
                Console.Write(mensajeIngreso);
                lectura = Console.ReadLine();
                validar = int.TryParse(lectura, out numeroValidado);
            }

            return numeroValidado;
        }

        static int sumar(int a, int b)
        {
            return a + b;
        }

        static int restar(int a, int b)
        {
            return a - b;
        }

        static float dividir(int a, int b)
        {
            return (float)a / b;
        }
        static int multiplicar(int a, int b)
        {
            return a * b;
        }



        static float calculadora(int numeroA, int numeroB, char operador)
        {
            float resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = sumar(numeroA, numeroB);
                    break;
                case '-':
                    resultado = restar(numeroA, numeroB);
                    break;
                case '/':
                    resultado = dividir(numeroA, numeroB);
                    break;
                case '*':
                    resultado = multiplicar(numeroA, numeroB);
                    break;
            }
            return resultado;
        }

        // tenga 8 caracteres
        // cant error



        static bool esClaveValida(string claveAValidar, int cantidadCaracteres)
        {
            bool resultado;

            if (claveAValidar.Length >= cantidadCaracteres)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        static bool validarClaveConReintentos(string claveAValidar, int cantidadCaracteres, int cantidadErrores)
        {

            int contador = 0;
            bool resultado;

            while (!esClaveValida(claveAValidar, cantidadCaracteres))
            {

                contador++;
            }

            if (contador > cantidadErrores)
            {
                resultado = false;
            }
            else
            {
                resultado = true;
            }

            return resultado;

        }


        static string pedirCadena(string mensaje)
        {
            string palabra;

            Console.Write(mensaje);
            palabra = Console.ReadLine();

            return palabra;
        }


        static bool esMenor(int numero, int limite)
        {
            return numero < limite;
        }


        static string pedirContraseña(string valorEsperado, string pedirIngreso, string mensajeError, int largoContraseña, int cantidadItentos)
        {
            string contrasenia;
            int contador = 0;


            contrasenia = pedirCadena(pedirIngreso);

            while ((contrasenia != valorEsperado || contrasenia.Length < largoContraseña) && cantidadItentos > contador)
            {
                Console.WriteLine(mensajeError);
                contrasenia = pedirCadena(pedirIngreso);
                contador++;
            }

            if (!esMenor(contador, cantidadItentos))
            {
                contrasenia = "";
            }

            return contrasenia;
        }
    }


}