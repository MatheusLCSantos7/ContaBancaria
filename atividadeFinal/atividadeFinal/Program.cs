using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool opc = false;
            ContaBancaria conta = new ContaBancaria();

            do
            {
                int selec = menu();
                Console.Clear();

                switch (selec)
                {
                    case 1:
                        conta.CadastroCB();
                        break;
                    case 2:
                        Console.WriteLine(conta);
                        break;
                    case 3:
                        Console.WriteLine("Digite a baixo a quantia a ser depositada: ");
                        float quantiaDeposito = float.Parse(Console.ReadLine());
                        conta.Deposito(quantiaDeposito);
                        break;
                    case 4:
                        Console.WriteLine("Digite a quantia a ser sacada: ");
                        float quantiaSaque = float.Parse(Console.ReadLine());
                        conta.Saque(quantiaSaque);
                        break;
                    case 0:
                        opc = true; 
                    break;
                }
            }
            while (!opc);
        }

        static int menu()
        {
            Console.WriteLine("Menu:\r\n ========================================\r\n1 - Cadastrar conta Bancaria\r\n2 - Mostrar dados da Conta\r\n3 - Realizar deposito\r\n4 - Realizar saque\r\n0 - Sair\r\nSelecione uma opção: ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }

    }
}
