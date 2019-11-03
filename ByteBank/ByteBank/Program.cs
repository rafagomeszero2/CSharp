using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("123.456.789-00");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("123.456.789-00");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "1234";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "1234");
                            
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("123.456.789.00");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("123.456.789-00");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("123.456.789-00");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("123.456.789-00");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("123.456.789-00");
            guilherme.Nome = "Guilherme";

            //Funcionario guilherme = new Desenvolvedor("123"); Também funciona
            //tipo funcionario e objeto desenvolvedor

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês " + 
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
