using DesignPatterns2.Capitulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            var conexao = new ConnectionFactory().GetConnection();
            var comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";
        }
    }
}
