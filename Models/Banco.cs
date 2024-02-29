using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoBancoYou.Models
{
    public class Banco
    {
        private string _nome;

        public string NumeroConta { get; private set;}
        public decimal Saldo { get; private set; }

        public Banco(string numeroConta, string nome)
        {   
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = 0;
        }
        
        public Banco (string numeroConta, string nome, decimal saldo) :this(numeroConta,nome)
        {
            Saldo = saldo; 
        }

        public string Nome 
        {
            get => _nome;  

            set
            {
                if (value == null)
                {
                    throw new Exception("Nome inválido");
                }
                else 
                {
                   _nome = value;
                }
            }
        }


        public void Depositar()
        {
            Console.WriteLine("Ola, seja bem-vindo!");
            Console.WriteLine("Quanto o senhor(a) deseja depositar ? ");
            decimal valor = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);

            Saldo += valor;
            Console.WriteLine("Depósito feito com sucesso!");
            Console.WriteLine("\n");
            Console.WriteLine($"Saldo atual: R${Saldo.ToString("F2",CultureInfo.InvariantCulture)}");

        }

        public void Sacar()
        {
            Console.WriteLine("Ola, seja bem-vindo!");
            Console.WriteLine("Quanto o senhor(a) deseja sacar ? ");
            decimal valor = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);

            Saldo -= valor + 5;  // taxa de 5 reais por saque
            Console.WriteLine("Saque feito com sucesso!");
            Console.WriteLine("\n");
            Console.WriteLine($"Saldo atual: R${Saldo.ToString("F2",CultureInfo.InvariantCulture)}");
        }

        public void Dados()
        {
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Nome do Titular: {_nome}");
            Console.WriteLine("\n");
            Console.WriteLine($"Numero da Conta: {NumeroConta}");
            Console.WriteLine("\n");
            Console.WriteLine($"Saldo Atual: R${Saldo.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}