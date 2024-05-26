namespace Models
{
    public class ContaPoupanca : Conta
    {
        public decimal taxaRendimentoAA { get; set; }
        public decimal taxaRendimentoAM { get; set; }

        public ContaPoupanca(int numero, int agencia, decimal saldo, Titular titular, List<Operacoes> operacoes) : base(numero, agencia, saldo, titular, operacoes)
        {
            
        }

        public override string ToString()
        {
            string apresentacao =
            @$"

            Informação da conta poupanca:

            Numero = {base.numero}
            Agencia = {this.agencia} 
            Saldo = {this.saldo} 
            Titular = {this.titular.nome} 
            ";

            return apresentacao;

        }
    }
}