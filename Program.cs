using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace primer_paso
{
    internal class Program
    {
        static void Main(string[] args)
      {
            int numero = 10;
            string texto = "Tomas";
            bool verdaderofalso = false;
            double decimales = 10;

            Console.WriteLine("hola mundo con C#");
            Console.WriteLine("hola" + texto + " su numero es " + numero);
            Console.WriteLine($"hola {texto} su numero es {numero}");

            string nombre = "";
            int edad = 0;
            string mayoria = "";

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad > 17)
            {
                mayoria = "es mayor de edad";
            }
            else
            {
                mayoria = "es menor de edad";
            }
            Console.WriteLine($"bienvenido {nombre} su edad es {edad} por lo tanto {mayoria}");

            int num1 = 0;
            int num2 = 0;
            
            int suma = 0;
            int resta = 0;
            int mult = 0;
            int div = 0;

            Console.WriteLine("ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            Console.WriteLine($"la suma de {num1} + {num2} es : {suma}");
            Console.WriteLine($"la resta de {num1} - {num2} es: {resta}");
            Console.WriteLine($"la multi de {num1} * {num2} es: {mult}");
            Console.WriteLine($"la div de {num1} / {num2} es: {div}");

       }
    }
}
