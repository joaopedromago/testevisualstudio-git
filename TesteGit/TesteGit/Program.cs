using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGit.Classes;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseTeste obj = new ClasseTeste();
            int num = 0;
            bool b = false;

            Console.WriteLine("Teste - Usando git com Visual Studio 2015");
            Console.WriteLine();
            Console.WriteLine("Digite um número");
            //Fazer o teste do valor digitado, forçando a digitação de um número inteiro válido
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Digite um número Válido");
                    b = false;
                    if (int.TryParse(Console.ReadLine(), out num))
                    {
                        b = true;
                    }
                } while (b ==false);
            }

            Console.Clear();

            for (int i = 0; i < num; i++)
                Console.WriteLine(obj.receberMSG());

            Console.ReadKey();
        }
    }
}
