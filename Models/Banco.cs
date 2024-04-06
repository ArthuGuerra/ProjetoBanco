using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco.Models
{
    public class Bank
    {
        public int NumberAccount { get; private set; }
        public string Holder { get; set; }
        public double Saldo { get; private set; }

        public Bank(){}
        public Bank(int numberAccount,string holder)
        {
            NumberAccount = numberAccount;
            Holder = holder;
        }



        public void DepositoInicial()
        {
             Console.WriteLine("Desejas realizar um deposito inicial ?  ");
            string resp = Console.ReadLine();

            if(resp == "S" || resp == "sim")
            {
                Console.WriteLine("informe o valor de deposito");

                double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Saldo += deposito;

                Console.WriteLine($"Novo Saldo: {Saldo.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Deposito inicial cancelado. ");
                Console.WriteLine($"Saldo inicial: {Saldo.ToString("F2",CultureInfo.InvariantCulture)}");

            }
        }

        public void Depositar()
        {
           
            Console.WriteLine("Informe o valor de deposito");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
            Saldo += deposito;
            Console.WriteLine($"Novo Saldo: {Saldo.ToString("F2",CultureInfo.InvariantCulture)}");
            
        }

        public void Saque()
        {

            Console.WriteLine("Informe o valor de saque");
            double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
            Saldo -= saque + 5;
            Console.WriteLine($"Novo Saldo: {Saldo.ToString("F2",CultureInfo.InvariantCulture)}");

        }

        public void Dados()
        {
            Console.WriteLine($"Number Account: {NumberAccount}");
            Console.WriteLine($"Holder: {Holder}");
            Console.WriteLine($"Saldo: {Saldo.ToString("F2",CultureInfo.InvariantCulture)}");
        }

    }
}