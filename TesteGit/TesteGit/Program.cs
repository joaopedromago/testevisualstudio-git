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

            Console.WriteLine("Teste - Usando git com Visual Studio 2015");

            for (int i = 0; i < 32; i++)
                Console.WriteLine(obj.receberMSG());

            Console.ReadKey();
        }
    }
}
