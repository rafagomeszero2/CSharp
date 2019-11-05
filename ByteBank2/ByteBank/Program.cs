using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("Catch no main");
            }


            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }


            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas1.txt");

            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }


        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(880, 220);
                ContaCorrente conta2 = new ContaCorrente(123, 456);

                conta1.Transferir(12345, conta2);
                conta1.Sacar(12345);
            }

            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Saldo);
                Console.WriteLine(e.ValorSaque);

                Console.WriteLine(e.Message);
                Console.WriteLine("Saldo Insuficiente");
            }

            catch (ArgumentException e)
            {
                Console.WriteLine("Argumento com erro:" + e.ParamName);
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(ContaCorrente.TaxaOperacao);
        }
    }
}
