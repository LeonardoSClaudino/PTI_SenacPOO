﻿using System.Globalization;
namespace ProjetoPTI;

public abstract class Veículo
{
  protected double TaxaDiaria { get; set; }
  public Veículo(double taxaDiaria)
  {
    TaxaDiaria = taxaDiaria;
  }
  public abstract double CalcularValorTotal(int numDiarias);
}
public class Carro : Veículo
{
  public Carro() : base(50.0)
  {

  }
  public override double CalcularValorTotal(int numDiarias)
  {
    return numDiarias * TaxaDiaria;
  }
}

public class Moto : Veículo
{
  public Moto() : base(25.0)
  {

  }
  public override double CalcularValorTotal(int numDiarias)
  {
    return numDiarias * TaxaDiaria;
  }

}

class Program
{
  public static void Main(string[] args)
  {
    Carro carro = new Carro();
    Moto moto = new Moto();

    int numDiarias = 10;

    double valorTotalCarro = carro.CalcularValorTotal(numDiarias);
    double valorTotalMoto = moto.CalcularValorTotal(numDiarias);

    Console.WriteLine("Valor total para 10 diárias com Carro: R$" + valorTotalCarro);
    Console.WriteLine("Valor total para 10 diárias com Moto: R$" + valorTotalMoto);
  }
}
