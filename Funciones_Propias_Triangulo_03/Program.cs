namespace Funciones_Propias_Triangulo_03
{
    internal class Program

        /*Crear una función llamada "CalcularAreaTriangulo" que tome tres parámetros de tipo double: "baseTriangulo" y
        "alturaTriangulo". La función debe calcular el área del triángulo y retornarla

        Desarrollar una funcion que reciba un valor numérico por parámetro, que represente la temperatura en Celsius. Realizar
        la conversión a Farenheit y retornarla.

        Visibilidad comportamiento retorno*/

    {/// <summary>
     /// 
     /// </summary>
     /// <param name="baseTriangulo"></param>
     /// <param name="alturaTriangulo"></param>
     /// <returns></returns>
        public static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            //Scope: alcance y visibilidad de la función.
            double resultado;

            resultado = baseTriangulo * alturaTriangulo / 2;

            return resultado;
        }
        /// <summary>
        /// Convierte grados Celcius en grados Fahrenheit.
        /// </summary>
        /// <param name="celsius">Temperatura a convertir.</param>
        /// <returns>Temperatura Fahrenheit.</returns>
        public static double ConvertirCelciusAFahrenheit(double celsius)
        {

            double fahrenheit;

            fahrenheit = celsius * (9 / 5) + 32;

            return fahrenheit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertirCelciusAFahrenheit(25));
        }
    }
}