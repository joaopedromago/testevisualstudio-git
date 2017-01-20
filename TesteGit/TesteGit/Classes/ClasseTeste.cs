using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGit.Classes
{
    class ClasseTeste
    {
        private static int idMensagem = 0;

        public string receberMSG()
        {
            string message = "Olá " + ++idMensagem;
            return message;
        }
    }
}
