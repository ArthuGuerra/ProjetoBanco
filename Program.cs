using Banco.Models;
using System.Collections.Generic;
using System.Globalization;

Console.WriteLine("Wellcome Bank of war");
Console.WriteLine("");

Console.WriteLine("Enter NumberAccount");
int numberAccount = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Enter Holder");
string holder = Console.ReadLine();
Console.WriteLine("");

Bank bank= new Bank(numberAccount,holder);

bank.DepositoInicial();
Console.WriteLine("");

bank.Depositar();
Console.WriteLine("");

bank.Saque();








