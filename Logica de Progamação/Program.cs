// metodo tryparse
/*
using System;
using System.Net;
class Program
{
static void Main (string[]args)

{
Console.WriteLine("digite seu nome");

string name = Console.ReadLine();

int idade;

Console.WriteLine("digite sua idade");

while (!int.TryParse(Console.ReadLine(), out idade))

        {
         Console.WriteLine("Digite uma Idade Valida.");   

            
        }
        Console.WriteLine($"bem vindo{name}, sua idade é {idade}");

   }

}

*/
//Tabuada

/*
Console.WriteLine(" Bem vindo a atabuada");
Console.WriteLine("Digite um numero para montarmos uma tabuada do 1 ao 10");

int  number;

while(!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Insira um numero valido");
}
Console.WriteLine($"Tabuada do {number}");

int result;

for (int i =0; i<11; i++)
{     
    result = number*i;
    Console.WriteLine($"{number} X {i} = {result}");

}

*/
/*
Console.WriteLine("digite a quantida de peça, e o valor");
int QuantiaDePeca;
double PrecoDaPeca;
while(true)
{
    if(!int.TryParse(Console.ReadLine(), out QuantiaDePeca))
    {
        Console.WriteLine("Quantidade Invalida!");
        continue;
    }
    if(!double.TryParse(Console.ReadLine(), out PrecoDaPeca))
    {
        Console.WriteLine("Valor invalido");

        continue;
    }

    double total = PrecoDaPeca * QuantiaDePeca;

    Console.WriteLine($"Valor a pagar é = {total:F2}");

    break;
}

*/

// dobro do numero.
/*
Console.WriteLine("digite um numero profano");

double number;

while (!double.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Digite apenas numeros");
}
double Dobro = number*2;
double Tiplo = number*3;

Console.WriteLine($" dobro umero é {Dobro:F2}");
Console.WriteLine($"o tiplo do seu numero é {Tiplo:F2}");

*/
/*
Console.WriteLine("Digite dua Data de Nascimento");

int Data;

while(!int.TryParse(Console.ReadLine(), out Data))
{
    Console.WriteLine(" UM BUG TERRIVEL ACONTECEU...IMPOSSIVEL!!!!!!");
}

int ano = 2077;

Console.WriteLine($" no ano de {ano} voce terá {ano - Data} de idade");

*/

//Calcular IMC
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Calculadora de IMC ===\n");

        // Leitura da altura
        Console.Write("Digite sua altura em metros (ex: 1.75): ");
        if (!double.TryParse(Console.ReadLine(), out double altura) || altura <= 0 || altura > 3)
        {
            Console.WriteLine("Altura inválida! Programa encerrado.");
            return;
        }

        // Leitura do peso
        Console.Write("Digite seu peso em kg (ex: 78.5): ");
        if (!double.TryParse(Console.ReadLine(), out double peso) || peso <= 0 || peso > 500)
        {
            Console.WriteLine("Peso inválido! Programa encerrado.");
            return;
        }

        // Cálculo correto do IMC
        double imc = peso / (altura * altura);

        // Mostra o resultado com 2 casas decimais
        Console.WriteLine($"\nSeu IMC é: {imc:F2}");

        // Classificação (ordem do mais grave para o menos grave)
        if (imc >= 40.0)
        {
            Console.WriteLine("Obesidade grau III (mórbida)");
        }
        else if (imc >= 35.0)
        {
            Console.WriteLine("Obesidade grau II (severa)");
        }
        else if (imc >= 30.0)
        {
            Console.WriteLine("Obesidade grau I");
        }
        else if (imc >= 25.0)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc >= 18.5)
        {
            Console.WriteLine("Peso normal (faixa saudável)");
        }
        else
        {
            Console.WriteLine("Abaixo do peso");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

*/
/*
Console.WriteLine("digite um numero de 0 a 10");

int number;

while(true) 

{
    if(!int.TryParse(Console.ReadLine(), out number))
    {
    Console.WriteLine("Voce deve digitar um numero");

    continue;
    }
    
    else if (number >10 || number <0)
    {
        Console.WriteLine("O numero deve ser de 0 a 10");

        continue;
    }

    break;
}



Console.WriteLine(number);

*/

// funções em C#

/*
using System;

class Program
{
    


static int MinhaFuncao (int a, int b)
    {
        return a+b;
    }
static void Main(string[]args)
{
Console.WriteLine(MinhaFuncao(5,5));

}
}

*/
/*
using System;
using System.Reflection;

class Program
{
static void Main (string[]args)
{
    string[] aluno = {"aluno 1","aluno 2","aluno 3"};
    double[] NotaAluno = new double [aluno.Length];

    for( int i = 0; i< aluno.Length;i++)
        {
            string NomeAluno = aluno[i];
            double nota;


        Console.WriteLine($"Digite a nota do {NomeAluno}");

        while (true)
            {
                if(double.TryParse(Console.ReadLine(), out nota))
                {
                    if (nota >= 0 && nota <=10)
                    {
                       

                        break;
                    }
                    else
                    {
                         Console.WriteLine("A nota deve ser de 0 a 10, tente novamente");
                    }
                  
                   
                }
                 else
                    {
                         Console.WriteLine("Voce deve digitar um numero");
                    }
                   
                
                
            }
            NotaAluno[i] = nota;
        }

        Console.WriteLine("\n=== Resultado ===");
        Console.WriteLine("Aluno\t\tNota");
        Console.WriteLine("---------------------");

       for( int j = 0; j< aluno.Length; j++)
        {
            Console.WriteLine($"O aluno {aluno[j]} tirou a Nota {NotaAluno[j]:F1}");
        }
    }

}

*/

/*


/*
// validação de dados.
using System;
using System.Reflection.Metadata;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main(string[]args)
    {
        
        Console.WriteLine("Olá, Digite seu nome e sua Idade");
        string NameUser = Console.ReadLine();
    

        while(true)
        {
            if (string.IsNullOrWhiteSpace(NameUser) || NameUser.Any(char.IsDigit))
            {
                Console.WriteLine("Digite um nome");
                NameUser = Console.ReadLine();

                continue;
            }
           
            break;
        }

        Console.WriteLine("digite sua idade");

        int idade;
        string verifica;

        while(!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.WriteLine("Numero invalido, tente novamente");
            

            continue;
        }

        if( idade >= 18)
        {
            verifica = "Maior de Idade";
        }
        else
        {
            verifica = "menor de Idade";
        }

        Console.WriteLine($"Olá {NameUser}, voce é {verifica}  ");

    }
}

*/
/*
string[] NameUser = {"user1","user2","user3"};
string[] PassUser = {"123","456","789"};

while (true){
Console.WriteLine("Digite seu nome de usuário");

string loginUser = Console.ReadLine();

Console.WriteLine("Digite sua senha");

string PassLogin = Console.ReadLine();

bool verifica = false;

int indece =-1;

for(int i = 0; i< NameUser.Length;i++)
{
    if(loginUser == NameUser[i] && PassLogin == PassUser[i])
    {   indece = i;
        verifica = true;
        break;
    }


   
}
if(verifica)
{
    Console.WriteLine($"bem vindo {NameUser[indece]}");

     break;
}
 else
    {
        Console.WriteLine("Senha ou nome incorretos");
    }

   
}

*/

// ingressar na legião.
/*
using System;
using System.Globalization;

class Program
{
    static void Main (string[]args)
    {
        Console.WriteLine("=== RECRUTAMENTO DA LEGIÃO ===");
        Console.WriteLine("Digite sua IDADE e sua ALTURA na mesma linha (separados por espaço).");
        Console.WriteLine("Exemplo: 18 1.75");

        while(true)
        {
            string entrada = Console.ReadLine();
            string[] dados = entrada.Split(' ');

            if(dados.Length < 2)
            {
                Console.WriteLine("voce tem que digitar altura e idade");

                continue;
            }

            string textoIdade = dados[0];
            string textoAltura = dados[1];

            int idade;
            double alura;

            bool idadeValida = int.TryParse(textoIdade, out idade); // tenta converter os dados da variaveç TextoIdade e guardar em dados no indice 0
            bool alturaValidade = double.TryParse(textoAltura, NumberStyles.Any, CultureInfo.InvariantCulture, out alura); 

            if( idadeValida && alturaValidade)
            {
                if(idade >= 18 && idade <= 45 && alura >= 1.70)
                {
                    Console.WriteLine("Bem vindo a legião");
                    break;
                }
                else
                {
                    Console.WriteLine("Recruta dispensado");
                }
            }
            else
            {
                Console.WriteLine("Dados invalido ERROR!!!");
            }
            
        }
        Console.ReadKey();
    }
}

*/

//calcul a area do triangulo.
/*
using System;
using System.Globalization;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Calcula a Area do triangulo");
        double area = 0;
        double basee = 0;
        double altura = 0;
        string entrada;

void funcaoBase ()
{
            
      
        while(true)
        {
            Console.WriteLine("Digite O valor da Base");
            entrada = Console.ReadLine();
            if(!double.TryParse(entrada, out basee))
            {
                Console.WriteLine("numero invalido, tente novamente");
            }
            else
            {
                break;
            }
        }
         while(true)
        {
            Console.WriteLine("Digite O valor da altura");
            entrada = Console.ReadLine();
            if(!double.TryParse(entrada, out altura))
            {
                Console.WriteLine("numero invalido, tente novamente");
            }
            else
            {
                break;
            }
        }
        area = (altura*basee)/2;

        Console.WriteLine($"{basee:F4}");
        Console.WriteLine("Aperte qualquer Botão para finalizar o programa.");
        Console.ReadKey();

      }
        
    }
}

*/
/*
// Exercios de função.

using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class program
{
    

static void Main(string[] args)
{

  
    int entradaA;
    int entradaB;
  
     
    Console.WriteLine("digite o numero de A");
    string ValorA = Console.ReadLine();

    Console.WriteLine("digite o valor de B");
    string ValorB = Console.ReadLine();

    bool ValidarA = int.TryParse(ValorA, out entradaA);
    bool ValidarB = int.TryParse(ValorB, out entradaB);

    if (ValidarA && ValidarB)
    {
        int resultado = Soma (entradaA, entradaB);
        Console.WriteLine($"{resultado}");
    }
    else
    {
        Console.WriteLine("numero invalido");
        
    }
    
    
    

 }
 static int Soma (int a, int b)
  {
    return a + b;
   }
}
*/
/*
using System;
using System.Data.SqlTypes;

namespace Myfunction;

public class Program {

    static void Main(string[]args)
    {
        saudar();
        int contar = soma (5,8);
        Console.WriteLine(contar);
    
    }
    static void saudar ()
    {
    Console.WriteLine("Olá");
    }
    
    static int soma (int a, int b)
    {
     return a + b;   
    }
}

*/
// contador letras 
/*
using System;

class program
{
    static void Main(string[]args)
    {
        Console.WriteLine("digite um palavra");

        string word = Console.ReadLine().ToLower();
        int contador = 0;


        while (true)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("Valor invalido");
            }
            else
            {
                break;
            }
        
        }
        for( int i =0; i< word.Length; i++)
        {
            if (word[i] == 'a')
            {
                contador++;
            }
        }

        Console.WriteLine($"Sua palavra tem {contador} letras A ");
           
    }
}
*/
/*
// inventario.

using System;
// using System.Reflection; <--- Não precisa desse aqui

class Program
{
    static void Main(string[] args)
    {
        string[] inventario = { "machado", "espada", "cajado" };

        Console.WriteLine("Inventário: machado, espada, cajado.");
        Console.WriteLine("Digite os itens que deseja equipar (separados por espaço):");

        string entrada = Console.ReadLine().ToLower();
        string[] ItensDigitado = entrada.Split(' ');

        // Essa variável serve para saber se AO MENOS UM item funcionou
        bool algumItemEquipado = false; 

        // 1º Loop: Passa por cada palavra que o usuário digitou
        for (int i = 0; i < ItensDigitado.Length; i++)
        {
            bool encontrar = false;

            // 2º Loop: Verifica se a palavra atual existe no inventário
            for (int j = 0; j < inventario.Length; j++)
            {
                if (ItensDigitado[i] == inventario[j])
                {
                    // Adicionei um espaço depois de Equipamento
                    Console.WriteLine($"Equipamento {inventario[j]} selecionado!");
                    algumItemEquipado = true;
                    encontrar = true;
                    break; // Achou o item no inventário, para de procurar no inventário
                }
            }

            // Se rodou todo o inventário e não achou esse item específico
            if (!encontrar)
            {
                Console.WriteLine($"Item '{ItensDigitado[i]}' não encontrado na mochila.");
            }
        }

        // Se no final de tudo, nenhum item foi válido
        if (!algumItemEquipado)
        {
            Console.WriteLine("Nenhum equipamento válido foi selecionado.");
        }
    }
}
*/
// numero aleatorio
/*
using System;

class Program
{
    static void Main(string[]args)
    {
        Random NumRandom = new Random();
         int SecretNumber = NumRandom.Next(0,100);

         Console.WriteLine("Eu estou pensando num numero de 0 a 100");
         Console.WriteLine("Consegue adivinhar?");
        
         int number;

         while(true){
            Console.WriteLine("Chute um numero");
            string entrada = Console.ReadLine();
           
            if(!int.TryParse(entrada, out number))
            {
            Console.WriteLine("Digite um numero valido de 0 a 100");
            continue;
   
            }
             if (number > SecretNumber)
            {
                Console.WriteLine("Seu numero e maior, tente mais uma vez");
               
            }
            else if (number < SecretNumber)
            {
                Console.WriteLine("Seu numero e menor, tente mais uma vez");
            
            }
            else
            {
                Console.WriteLine("Voce acertou o valor do meu numero");
                break;
            }
         
         }
    
    }
}

*/

// Combate por turno

using System;
class Program
{
    static void Main(string[] args)
    {
        int VidaJogador1 = 100;
        int VidaJogador2 = 100;

        Random random = new Random();
        
        int atacar;
        Console.WriteLine("Digite 1 para atacar o jogador 2");

        while(true)
        {   Console.WriteLine("\n--------------------------------");
            Console.WriteLine($"Sua Vida: {VidaJogador1} | Inimigo: {VidaJogador2}");
            Console.WriteLine("Digite 1 para atacar!");
            string acao = Console.ReadLine();
            
            if(!int.TryParse(acao, out atacar) || atacar !=1)
            {
                Console.WriteLine("Ação invalida, voce perdeu seu turno");
    
            }
            //turno do jogador 1
            else
            {   int danoJogador = random.Next(5, 15);
                VidaJogador2 = VidaJogador2 - danoJogador;
                Console.WriteLine($"POW! Você causou {danoJogador} de dano!");
                
            }
            if( VidaJogador2 <= 0)
            {
                Console.WriteLine("Voce derrubou o jogador 2");
                break;
                
            }
            Thread.Sleep(1000);
            Console.WriteLine("O inimigo prepara o ataque...");
            Thread.Sleep(500);

            int danoInimigo = random.Next(5,15);

            VidaJogador1 = VidaJogador1 - danoInimigo;

            Console.WriteLine($"O inimigo leh acertou e causou {danoInimigo} de dano");

            if( VidaJogador1 <= 0)
            {
                Console.WriteLine("Voce foi derrotado");
                break;
            }


        }
    }
}