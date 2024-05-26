using System.Runtime.CompilerServices;

namespace Models
{
    public class ContaCorrente : Conta 
    {
        //sempre quando se faz o processo de heranca, ela herda tudo menos o construtor --
        public string perfilInvestidor { get; set; }
        public decimal taxaRendimentoAD { get; set; }
        public  ContaCorrente(int numero, int agencia, decimal saldo, Titular titular, List<Operacoes> operacoes) : base(numero, agencia, saldo, titular, operacoes)
        {

        }

        public override string ToString()
        {
            string apresentacao =
            @$"

            Informação da conta corrente:
            
            Numero = {this.numero}
            Agencia = {this.agencia} 
            Saldo = {this.saldo} 
            Titular = {this.titular.nome} 
            ";

            return apresentacao;

        }

        public override void Saque(decimal valor)
        {
            decimal valorFinal = saldo - valor;
            if(valorFinal < 0)
                throw new ArgumentException("Não há saldo para saque!");

            saldo = valorFinal;
        }
    }
}