namespace SindicoPronto.Models
{
    public class ContaCondominio
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public string Responsavel { get; set; }
        public double Saldo { get; private set; }

        public ContaCondominio()
        {
            
        }
        public ContaCondominio(int numero, string titular, string responsavel)
        {
            Numero = numero;
            Titular = titular;
            Responsavel = responsavel;  
        }
        public ContaCondominio(int numero,string titular,string responsavel,double saldo) :this(numero,titular,responsavel) 
        {           
            Saldo = saldo;                
        }
        public void Deposito(double quantia)
        {
            Saldo +=quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= (quantia - 5.0);
        }

    }
}
