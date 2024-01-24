namespace Ejercicio2multiploC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe un numero de dos digito");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 10)
            {
                Console.WriteLine("escribe un numero de dos digitos");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            else
            {

            }
        }
    }
}
