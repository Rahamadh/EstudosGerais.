
/*
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    

static void Main (string[]args)
{
    Saudar();
    saudarNovamente("preparece");
    saudarNovamente("A luta continua");
    Console.WriteLine(Calcula.calculaDobro(50,50));
}

static void Saudar ()
{
    Console.WriteLine("bem vindo");
}

static void saudarNovamente ( string saudacao)
    {
        Console.WriteLine($"Ola guerreiro {saudacao}");
    }

}

public class Calcula
{
    public static int calculaDobro ( int valor1, int valor2)
    {
        int resultado = valor1* valor2;
        return resultado;
    }
}

public class Meutest
{
    static string testando ( string test)

    {
        return test;
    }
}
*/
/*
using System;

public class ExercicoDeMetodo
{
 static void Main( string[]args)
    {
        int vidaAtual = MinhaPocao.pocaoDeCura(60,50);

        Console.WriteLine(vidaAtual);
    }
}
public class MinhaPocao
{
    public static int pocaoDeCura (int vida, int pocao)
    {
        int Calcula = vida + pocao;

        if( Calcula > 100)
        {
            Console.WriteLine("A vida não posso ultrapassar 100");
            Calcula = 100;

            
            
        }
       
        return Calcula;
    } 
}
*/
/*
using System;

class Program
{
    static void Main (string[]args)
    {
        Random random = new Random();
        
        int DanoJogador = random.Next(50,150);
        int DanoCausado = Inimigo.AtacaInimigo(100,DanoJogador);
        
        

    }
}

public class Inimigo
{
    public static int AtacaInimigo ( int VidaAtual, int dano )
    {
        int calulo = VidaAtual - dano;

        if (calulo < 0)
        {
            calulo = 0;
            Console.WriteLine();
            Console.WriteLine ($"Voce reduziu o inimigo a {calulo} pontos" );
            
        }
        else
        {   Console.WriteLine();
            Console.WriteLine($"O Inimigo resistiu ao seu ataque e ficou com {calulo} pontos");
        }
        return calulo;
    }
}

*/

using System;
using System.Data;
using System.Threading; // <--- NECESSÁRIO para o Thread.Sleep

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- TURNO DO JOGADOR ---");
        int acaoJogador = escolhaJogador(1);

        if (acaoJogador == -1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">> O jogador perdeu a vez por excesso de erros!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine(">> Jogada confirmada! Processando ação...");
            // Aqui você colocaria o switch do jogador (dano, defesa, etc)
        }

        Console.WriteLine("\n..."); // Efeito de espera
        Thread.Sleep(1500); // Espera 1.5 segundos

        Console.WriteLine("\n--- TURNO DO INIMIGO ---");
        int acaoInimigo = escolhaInimigo();
        
        // Aqui você colocaria a lógica de dano baseada na 'acaoInimigo'
    }

    // --- MÉTODO DO JOGADOR ---
   public static int escolhaJogador(int acao)
    {
        
        int tentativa = 0;
        int maxTentativa = 3;

        while (true)
        {
            Console.WriteLine("Digite sua ação (1-Atacar, 2-Defender, 3-Magia):");
            string entrada = Console.ReadLine();

            // Ajustei para aceitar até o 3
            if (!int.TryParse(entrada, out acao) || acao < 1 || acao > 3)
            {
                tentativa++;
                Console.WriteLine($"Ação inválida! Tentativa {tentativa} de {maxTentativa}");

                if (tentativa >= maxTentativa)
                {
                    return -1; // Código de erro (Perdeu a vez)
                }
            }
            else
            {
                Console.WriteLine($"O jogador selecionou a ação número {acao}");
                return acao;
            }
        }
    }

    // --- MÉTODO DO INIMIGO ---
   public static int escolhaInimigo()
    {
        Random random = new Random();
        
        // CORREÇÃO: Next(1, 4) gera 1, 2 ou 3. (O último número é exclusivo)
        int acao = random.Next(1, 4); 

        // Vamos traduzir o número para texto para ficar bonito na tela
        string nomeAcao = "";
        
        switch(acao) 
        {
            case 1: nomeAcao = "ATACAR"; break;
            case 2: nomeAcao = "DEFENDER"; break;
            case 3: nomeAcao = "USAR MAGIA"; break;
        }

        Console.WriteLine($"O inimigo decidiu: {nomeAcao} (Opção {acao})");

        return acao;
    }

}
public class StatusPlayer
{
     
      public  int VidaJogador = 100;
      public int ManaJogador = 30;
      public bool defesaJogador = false;

      private static Random random = new Random();

      public int GerarAtaque ()
    {
        
        return random.Next(5, 15);
        
    }
     public int GerarMagia ()
    {
        
        return random.Next(5, 15);
        
    }
           

}