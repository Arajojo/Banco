using System.Runtime.InteropServices;
using Models;

namespace ProgramaPrincipal{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Criação das listas

            List<Operacoes> operacoesCp = new List<Operacoes>();
            List<Operacoes> operacoesCc = new List<Operacoes>();
            List<Operacoes> operacoesCs = new List<Operacoes>();
            
        
            //------------------
            Endereco endereco1  = new Endereco
            {
                numero = 120,
                logradouro = "Rua das orquideas, Jundiai, SP",
                complemento = "Perto do mercado do seu zé"
                
            };

            Titular titularcc = new Titular
            {
                nome = "Arthur",
                documento = "3242342",
                endereco = endereco1,
                telefone = "11939284928"
            };
            Titular titularcp = new Titular
            {
                nome = "Gabriel",
                documento = "3242342",
                endereco = endereco1,
                telefone = "11939284928"
            };
            Titular titularcs = new Titular
            {
                nome = "Matheus",
                documento = "3242342",
                endereco = endereco1,
                telefone = "11939284928"
            };

            ContaSalario cs = new ContaSalario(0001, 0316, 0, titularcs, operacoesCs);

            
            Console.WriteLine("----------------------------------");
            cs.Depositar(1000);
            //conta.Depositar(-20);
            cs.Saque(500);
            //cs.Saque(500);
            Console.WriteLine(cs);
            cs.Extrato();
            Console.WriteLine("----------------------------------");

            ContaPoupanca cp = new ContaPoupanca(2, 3531, 0, titularcp, operacoesCp);
            cp.Depositar(1453.34m);
            cp.Saque(453.34m);
            Console.WriteLine(cp);
            cp.Extrato();
            Console.WriteLine("----------------------------------");

            ContaCorrente cc = new ContaCorrente(2, 3531, 0, titularcc, operacoesCc);
            cc.Depositar(5453.34m);
            cc.Saque(453.34m);
            Console.WriteLine(cc);
            cc.Extrato();

            cc.Trasnferencia(cp, 1000);
            Console.WriteLine(cp);
            cc.Extrato();
            

        }
    }
}