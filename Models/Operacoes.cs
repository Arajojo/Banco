namespace Models{

    public class Operacoes
    {
        public string tipo { get; set; }
        public decimal valor { get; set; }

        public Operacoes(string tipo, decimal valor)
        {
            this.tipo = tipo;
            this.valor = valor;
        }
    }

}