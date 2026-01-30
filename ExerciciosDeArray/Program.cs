// Soma apartir de um array

/*
using System;
class Program
{
    static void Main (string[]args)
    {
        int[] ouro = {10,50,5,20,100};
        int contador = 0;

        for(int i = 0; i <ouro.Length; i++)
        {
            contador += ouro[i];
        }

        Console.WriteLine(contador);

    }
}
*/
/*
// Loop com array
using System;

class Program
{
    static void Main (string[]args)
    {
        Console.WriteLine("Veja qual inimigo e mais poderoso");

        int[] Forca = {100,4000,90,500,700};
        int maiorForca = 0;

        for ( int i = 0; i< Forca.Length; i++)
        {
            if(Forca[i] > maiorForca  )
            {
                maiorForca = Forca[i];
            }
        }
        Console.WriteLine(maiorForca);

        

    }
}
*/

/*
using System;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Bem vindo a Loja de Alqumia, Qual poção deseja comprar?");
        string[] cardapio = {"poção de cura","antidoto", "poção de mana","elixir"};
        int indece = -1;

        for(int i =0; i<cardapio.Length;i++)
        { 
            Console.WriteLine($"Lista Disonivél codigo {i +1} {cardapio[i]}");
            
            
        }
        string entrada = Console.ReadLine();
        int codigo = int.Parse(entrada);

        if( codigo >= 1 && codigo <= cardapio.Length)
        {    
            
            Console.WriteLine($"voce comprou {cardapio[codigo -1]}");
        }
        else
        {
            Console.WriteLine("nenhum produto selecionado");
        }


    }
}

*/
// Manipulação de strings inverter palavra.
/*/
using System;
using System.ComponentModel.DataAnnotations;

class function
{
    static void Main(string[]args)
    {
        Console.WriteLine("Console.log: Diz: Digite uma palavra");
     string Name = Console.ReadLine();
     
     
     for ( int j = Name.Length -1; j>= 0; j--)
        {
            Console.Write(Name[j]);
        }
     

   }  

}
*/
/*
using System;

class Program
{
    static void Main (string[]args)
    {
        int[] Forca = {10,50,60,30,5};
        int menorForca = Forca[0];

        for( int i = 0; i < Forca.Length; i++)
        {
            if(Forca[i] > menorForca  )
            {
                menorForca = Forca[i];
            }
        
        }
        Console.WriteLine(menorForca);
    }
}

*/

// verifica a maior palavra

using System;

class word
{
    static void Main (string[]args)
    {
        Console.WriteLine("Digite 3 palavras");
        string[] palavra = Console.ReadLine().Split(' ');
        string maiorPalavra = "";

        for(int i = 0; i < palavra.Length; i++)
        {
            if(palavra[i].Length > maiorPalavra.Length )
            {
                maiorPalavra = palavra[i];
            }
        }
        Console.WriteLine(" A maior palavra é"  + maiorPalavra);
        Console.WriteLine(maiorPalavra.Length);


    }
}