using System.Security.Cryptography.X509Certificates;

namespace Models
{
    public class Conta
    {
        public int numero { get; private set; }
        public int agencia { get; private set; }
        public decimal saldo { get; protected set; }
        public Titular titular { get; private set; }
        public List<Operacoes> operacoes{ get; set; }

        public Conta(int numero, int agencia, decimal saldo, Titular titular, List<Operacoes> operacoes)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.saldo = saldo;
            this.titular = titular;
            this.operacoes = operacoes;
        }

        public void Depositar(decimal valor)
        {
            if(valor <= 0)
                throw new ArgumentException($"Impossivel informar valores zerados ou negativos({valor})");
        
            saldo += valor;
            operacoes.Add(new Operacoes("Deposito", valor));
        }

        public virtual void Saque(decimal valor)
        {
            decimal valorFinal = saldo-valor;

            if(valorFinal < 0)
            {   
                throw  new ArgumentException($"Saldo indisponivel! Saldo atual - {saldo}");
            }
            saldo -= valor;
            operacoes.Add(new Operacoes("Saque", valor));
        }
        public void Extrato(){
            List<Operacoes> operacoes = this.operacoes;
            int contador = 1;
            foreach(Operacoes i in operacoes)
            {
                Console.WriteLine(@$"------------------------------

   Operação {contador} 
Titular - {titular.nome}
Tipo - {i.tipo} 
Valor - {i.valor}
");
                contador++;

            }
        }

        public void Trasnferencia(Conta conta, decimal valor)
        {

            if(conta is ContaPoupanca)
            {
                conta.Depositar(valor);
                this.Saque(valor);
                Console.WriteLine($"Trasferencia realizada para {conta.titular.nome} no valor de {valor}");
                operacoes.Add(new Operacoes($"Transferencia para {titular.nome}", valor));
            }else
            {
                if(conta is ContaCorrente)
                {
                    conta.Depositar(valor);
                    this.Saque(valor);
                    Console.WriteLine($"Trasferencia realizada para {conta.titular.nome} no valor de {valor}");
                    operacoes.Add(new Operacoes($"Transferencia para {titular.nome}", valor));
                }else
                {
                    if(conta is ContaSalario)
                    {
                        conta.Depositar(valor);
                        this.Saque(valor);
                        Console.WriteLine($"Trasferencia realizada para {conta.titular.nome} no valor de {valor}");
                        operacoes.Add(new Operacoes($"Transferencia para {titular.nome}", valor));

                    }else
                    {
                        conta.Depositar(valor);
                        this.Saque(valor);
                        Console.WriteLine($"Trasferencia realizada para {conta.titular.nome} no valor de {valor}");
                        operacoes.Add(new Operacoes($"Transferencia para {titular.nome}", valor));
                    }
                }
            }
        }


    }
}