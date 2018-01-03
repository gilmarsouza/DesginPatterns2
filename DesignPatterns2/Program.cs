using DesignPatterns2.Capitulo1;
using DesignPatterns2.Capitulo2;
using DesignPatterns2.Capitulo3;
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
            #region Capítulo 1
            //var conexao = new ConnectionFactory().GetConnection();
            //var comando = conexao.CreateCommand();
            //comando.CommandText = "select * from tabela";
            #endregion

            #region Capítulo 2
            //var notas = new NotasMusicais();

            //var doReMiFa = new List<INota>() {
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),

            //    notas.Pega("do"),
            //    notas.Pega("sol"),
            //    notas.Pega("fa"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa")
            //};

            //var piano = new Piano();
            //piano.Toca(doReMiFa);
            #endregion

            #region Capítulo 3
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            #endregion


        }
    }
}
