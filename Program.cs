using System.Globalization;
using ProjetoBancoYou.Models;

Console.WriteLine("Olá, seja bem vindo ao banco Guerra. Iremos fazer seu cadastro");
Console.WriteLine("Digite seu nome por favor!");
string nome = Console.ReadLine();
Console.WriteLine("\n");
Console.WriteLine("Digite 8 números da conta nesse formato por favor ####-#### ");
string numeroConta = Console.ReadLine();

Console.WriteLine("O senhor(a) deseja fazer um depósito inicial ? ");
string resposta = Console.ReadLine();


if (resposta == "s" || resposta == "S")
{
    Console.WriteLine("Digite o valor do depósito por favor");
    decimal saldo = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);
    Banco cliente = new Banco(numeroConta,nome,saldo);

    Console.WriteLine("Depósito feito com sucesso!");
    Console.WriteLine("\n");
    Console.WriteLine($"Saldo atual: {saldo.ToString("F2",CultureInfo.InvariantCulture)}");
    Console.WriteLine("\n");

    cliente.Dados();
    Console.WriteLine("\n");
    cliente.Depositar();
    Console.WriteLine("\n");
    cliente.Sacar();
    Console.WriteLine("\n");
    cliente.Dados();
    

}
else
{
    Banco cliente = new Banco(numeroConta, nome);

    cliente.Dados();
    Console.WriteLine("\n");
    cliente.Depositar();
    Console.WriteLine("\n");
    cliente.Sacar();
    Console.WriteLine("\n");
    cliente.Dados();
}





// é isso, espero que tenham gostado. deixa o like tmj
