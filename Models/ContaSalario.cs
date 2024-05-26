namespace Models
{
    public class ContaSalario : Conta
    {
        public string empresa { get; set; }
        public int anosDeFidelidade { get; set; }
        public ContaSalario(int numero, int agencia, decimal saldo, Titular titular, List<Operacoes> operacoes) : base(numero, agencia, saldo, titular, operacoes)
        {
            
        }

        public override string ToString()
        {
            string apresentacao =
            @$"

            Informação da conta salario:
            
            Numero = {this.numero}
            Agencia = {this.agencia} 
            Saldo = {this.saldo} 
            Titular = {this.titular.nome} 
            ";

            return apresentacao;

        }
    }
}