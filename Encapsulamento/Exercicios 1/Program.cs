using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Emcapsulamento

{

public class Principal
{
    static void Main (string[]args)
    {
       /*
        Mochila mochila = new Mochila(10.0);
        Item machado = new Item("machado Grande",5.0);
        Item Elefante = new Item ("Elefante africano", 6000.0);

        mochila.AdcionarItem(machado);
        mochila.AdcionarItem(Elefante);

        mochila.Verlista();

        */
/*
        ArCondicionado ar = new ArCondicionado(50);

        ar.DiminuirTemperatura(3);
 */
BancoDeDados novoBanco = new BancoDeDados();



novoBanco.Cadastrar("pedro@email.com","123456");
novoBanco.Cadastrar("maria@email.com","123456");

novoBanco.Logar("pedro@email.com", "123456");

    }
}
public class Item
{
    public string Nome {get; set;}
    public double Peso  {get; set;}

    public Item (string Nome, double Peso)
    {
       this.Nome = Nome;
       this.Peso = Peso;
    }

}
public class Mochila
{
    public double CapacidadeMaxima {get;private set;}
    private List<Item> _itens = new List<Item>();

    public Mochila ( double pesoAtual)
    {
        CapacidadeMaxima = pesoAtual;
    }

    public  void Verlista ()
   {
    if(_itens.Count == 0)
        {
            Console.WriteLine("Mochila vazia");
            return;
        }
    foreach (var lista in _itens)
    {      
        Console.WriteLine($"{lista.Nome} {lista.Peso}");
    }
   }

    public void AdcionarItem (Item novo)
    {
        double PesoAtualMochila = 0;
        
        foreach( var item in _itens)
        {
            PesoAtualMochila += item.Peso;
        }
        double pesoFuturo = PesoAtualMochila + novo.Peso;

        if( pesoFuturo < CapacidadeMaxima)
        {
        Console.WriteLine($"ERRO: Não é possível pegar '{novo.Nome}'. Peso excedido!");
        Console.WriteLine($"Capacidade: {CapacidadeMaxima}kg | Peso necessário: {pesoFuturo}kg");
        }
        else
        {
            _itens.Add(novo);
            PesoAtualMochila = 0;
        }
    }
}
}