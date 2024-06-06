using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesBasicas
{
    internal class Divisao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um segundo número");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = numero1 / numero2;
            Console.WriteLine("O resultado dessa divisão é " + resultado);
        }
    }
}
