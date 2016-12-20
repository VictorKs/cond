using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o primeiro valor? ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o primeiro valor? ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma é:" + (num1 + num2));


            Console.WriteLine("Deseja Continuar ? 1- SIM  2 - NÃO");
            int rep = int.Parse(Console.ReadLine());
            while(rep==1)
            {
                Console.WriteLine("informe o primeiro valor? ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("informe o primeiro valor? ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Soma é:" + (num1 + num2));
            }


            
            }

        }
    }


