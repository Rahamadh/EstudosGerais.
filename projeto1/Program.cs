
/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("digite seu nome");
        string? user = Console.ReadLine();
        if (user != null)
        {

            Console.WriteLine($"ola,{user} bem-vindo ao c#");
        }
        else
        {
            Console.WriteLine("nennhum nome digitado");
        }
    }


}

*/
/*
Console.WriteLine("digite um numero");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite outro numero");
int num2 = Convert.ToInt32(Console.ReadLine());



    int result = num1 + num2;
Console.WriteLine($"a soma dos seus numeros é{result}");

*/
/* verifica idade
Console.WriteLine("digite sua idade");

string? input = Console.ReadLine();

if (int.TryParse(input, out int idade))
{

    if (idade >= 18)
    {
        Console.WriteLine("voce e maior de idade");
    }
    else
    {
        Console.WriteLine("voce e menor de idade");
    }


}
else
{
    Console.WriteLine("idade invalida");
}     
    
*/
/* par ou impar
Console.WriteLine("digite um numero");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("numero par");
}
else
{
    Console.WriteLine("numero impar");
}
*/
/* contador
int contador = 1;

int contar = 0;

for (int i = 10; i >= contador; i--)
{

    Console.WriteLine(i);
      contar = i;
}


*/
/* tabuada
Console.WriteLine("digite um numero");
int tabuada = Convert.ToInt32(Console.ReadLine());

int contador = 10;
int mult = 0;

for (int i =1;i<= contador;i++)
{
    mult = i * tabuada;
    Console.WriteLine($"{tabuada}x{i}={mult}");
}

*/

//numeros pares soma.
/*
Console.WriteLine("digite um numero");
int contador = Convert.ToInt32(Console.ReadLine());

int soma = 0;
string pares = "";


for (int i = 1; i <= contador; i++)
{
    if (i % 2 == 0)
    {
        soma += i;
        if (pares != "")
        {
            pares += " + ";

        }
        pares += i;
    }
} 
    if (pares == "")
    {
        Console.WriteLine($"não ha numeros paress entre 1 e {contador} ");
    }
    else
    {
        Console.WriteLine($"{pares} = {soma} ");   
    }

Console.WriteLine($"a soma do valores pares de 1 a {contador} e {soma}");

*/
// nota do aluno

/*
string[] alunoName = { "pedro", "joão", "maria" };
double[] notaAluno = new double[alunoName.Length];


for (int i = 0; i < alunoName.Length; i++)
{
    Console.WriteLine($"digite a nota de {alunoName[i]}");

    while (!double.TryParse(Console.ReadLine(), out notaAluno[i]))
    {
        Console.WriteLine("nota invalida");
    }

}
for (int i = 0; i<alunoName.Length;i++)
{
    if (notaAluno[i] >= 7)
    {
        Console.WriteLine($"{alunoName[i]} aprovado! com a nota {notaAluno[i]:F1}");
    }
    else
    {
        Console.WriteLine($"{alunoName[i]} reprovado com a nota {notaAluno[i]:F1}");
    }
}

*/
//
//fatorial
/*
using System;

class Program
{
    static void Main()
    {





        Console.WriteLine("digite um numero");

        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("numero invalido, tente novamente.");

            return;
        }
        long fatorial = CalcularFatorial(number);

        Console.WriteLine($"o fatorial de {number} e {fatorial}");
    }
    static long CalcularFatorial(int n)
    {
        long resultado = 1;

        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}
*/
/*
Console.WriteLine("Digite uma palavra");

string? palavra = Console.ReadLine();

if (string.IsNullOrEmpty(palavra))
{
    Console.WriteLine("palavra invalida");
    return;
}
string invertida = "";

for (int i = palavra.Length -1; i >= 0; i--)
{
    invertida += palavra[i];
}

Console.WriteLine($"sua palavra invertida:{invertida}");

*/

/*
using System;

class CalculaDobro
{
    static int Dobro(int number)
    {
        return number * 2;
    }

    static void Main()
    {
        Console.WriteLine("digite um numero");
        int valor = int.Parse(Console.ReadLine());

        int result = Dobro(valor);

        Console.WriteLine($"o dobro de {valor} e {result}");
    }
}

*/
/*
using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set;}
}
class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa();

        pessoa1.Nome = "carlos";
        pessoa1.Idade = 30;

  Console.WriteLine($"nome:{pessoa1.Nome} {pessoa1.Idade}");
    }
}

*/

// Exercicois de logica de Progamação.

/*
using System;
using System.Globalization;

class Program{
    static void Main(string[] args)
    {
        

Console.WriteLine(" Bem vindo ao exercicios");    

Console.WriteLine(" digite o codigo de um produto, quantidade do puduto e valor & novamente para o produto dois, tudo na mesma linha");
string[] valores = Console.ReadLine()!.Split(' ');

int cod1 = int.Parse(valores[0]);
int qte1 = int.Parse(valores[1]);
double preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

int cod2 = int.Parse(valores[3]);
int qte2 = int.Parse(valores[4]);
double preco2 = double.Parse(valores[5], CultureInfo.InvariantCulture);

double total = qte1 * preco1 + qte2 * preco2;

Console.WriteLine("valor a pagar: R$" + total.ToString("F2", CultureInfo.InvariantCulture));


}
}


*/
/*
using System.Globalization;
//pega um valor digitado pelo usuario e converte para double
double raio = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

// fixa o valor de pi
double pi = 3.14159;
//calcula a area
double area = pi * raio;

Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InstalledUICulture));
*/
/*
Console.WriteLine("calcule a area do retangulo");

double largura = 10.5;
double altura = 20.5;

double calculo = largura * altura;

if( calculo >= 100)
{
    Console.WriteLine("O valor do retangulo é " + calculo);
}
else
{
    Console.WriteLine(calculo + "hmmm então...");
}

*/
// Verifica se contem letra
/*
using System;
using System.Linq;

Console.WriteLine( "digite uma palavra");

string word = Console.ReadLine()!;

if (word.ToLower().Contains('a'))
{
    Console.WriteLine("letra A presente");

}
else
{
    Console.WriteLine("não contem a lenha a");
}
*/

Random aleatorio = new Random();
int NumeroSecreto = aleatorio.Next(1, 100);

Console.WriteLine("Eu estou pensando num numero de 1 a 100 tente adivinhar");

while(true)
{
    Console.WriteLine("digite um numero");
    string entrada = Console.ReadLine()!;

    if(!int.TryParse(entrada, out int saida))
    {
        Console.WriteLine(" numero invalido, tente novamente");
        continue;
    }
    else if ( saida > NumeroSecreto)
    {
        Console.WriteLine("Seu numero e maior que o meu, tente mais uma vez");
    }
    else if (saida < NumeroSecreto)
    {
        Console.WriteLine("Seu numero é menor que o meu");
    }
    else
    {
        Console.WriteLine(" voce acertou!!!");
         break;
    }

    

}