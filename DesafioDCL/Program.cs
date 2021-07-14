using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();

    int qtdCarros = 0;
    int comissaoFixa = 0;
    float comissaoVar = 0;
    float salario = 0;
    float valorCarro = 0;
    float totalValorVendas = 0;
    int porcentagem = 0;
    float salarioFinal = 0;

    Console.WriteLine  ("=-=-=-=-=-=- RM CARROS =-=-=-=-=-=-");

    Console.WriteLine("Qual é o seu salário por mês?");
    salario = float.Parse(Console.ReadLine());

    Console.WriteLine("Quantos carros você vendeu no mês?");
    qtdCarros = int.Parse(Console.ReadLine());

    Console.WriteLine("Quanto você ganha em porcentagem por cada carro vendido?");
    porcentagem = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual é o valor da sua comissão fixa?");
    comissaoFixa = int.Parse(Console.ReadLine());

    for(int c = 1; c <=qtdCarros; c ++){
      Console.WriteLine($"Qual o valor do {c}º carro que você vendeu?");
      valorCarro = float.Parse(Console.ReadLine());
      totalValorVendas += valorCarro;
      comissaoVar += (valorCarro / 100 ) * porcentagem; // Ele ganha % do valor do carro
      comissaoFixa += comissaoFixa;
    }
    salarioFinal = salario + comissaoFixa + comissaoVar;
    Console.WriteLine($"Total Vendas: R${totalValorVendas}");
    Console.WriteLine($"Salário Fixo: R${salario}");
    Console.WriteLine($"Comissão Variável: R${comissaoVar}");
    Console.WriteLine($"Comissão Fixa: R${comissaoFixa}");
    Console.WriteLine($"Salário Final: R${salarioFinal}");
  }
}