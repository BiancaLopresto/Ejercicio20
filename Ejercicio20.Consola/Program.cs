namespace Ejercicio20.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;

            Console.Write("Ingrese el primer numero: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            numero2=double.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("No se pueden ingresar dos numeros iguales");
            }else
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine($"{numero1} es mayor que {numero2}");
                }else
                {
                    Console.WriteLine($"{numero2} es mayor que {numero1}");
                }
            }
        }
    }
}