using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeFinal
{
    internal class ContaBancaria
    {
        private int NumeroDaConta;
        private string Titular;
        private string DepositoInicial;
        private float ValorEmConta;

        public ContaBancaria(int numeroDaConta, string titular , float valorEmConta)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            ValorEmConta = valorEmConta;
        }

        public ContaBancaria(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
        }

        public ContaBancaria() { }



        public int GetNumeroDaConta() { return NumeroDaConta; }


        public void setNumeroDaConta(int valor)
        {
            NumeroDaConta = valor;
        }
        public string getTitular() { return Titular; }

        public void setTitular(string valor)
        {
            Titular = valor;
        }
        public float GetValorEmConta() { return ValorEmConta; }

        public void setValorEmConta(float valor){
            ValorEmConta= valor;
        }
        public string getDepositoInicial() {  return DepositoInicial; }

        public void setDepositoInicial(string valor)
        {
            DepositoInicial = valor;
        }

        public void Deposito(float quantia)
        {
            ValorEmConta += quantia;
        }

        public void Saque(float quantia)
        {
            ValorEmConta -= quantia + 5;
        }


        public void CadastroCB()
        {

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            setNumeroDaConta(numero);
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            setTitular(titular);


        }
        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + ValorEmConta.ToString("F2", CultureInfo.InvariantCulture);

        }
        



    }
}
