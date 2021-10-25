using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }


        public Conta(int numero, string titular)
        {
            NumConta = numero;
            TitularConta = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
                 + NumConta
                 + ", Titular: "
                 + TitularConta
                 + ", Saldo: $ "
                 + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
