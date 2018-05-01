using System;
using System.Globalization;

namespace ContaBacariaConsole
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }

        public Conta(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public bool HaveraDeposito(char resposta)
        {
            if (resposta == 's')
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular 
                + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
    }
}
