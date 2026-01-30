/*
using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace youername;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine(" Bem vindo a lanchonete");
        Console.WriteLine("Digite o codigo do seu produto e a quantidade desejada");

        string[] Produto = {"Cachorro Quente", "X-Salada", "Batata Frita", "Refrigerante"};
        double[] Preco = {20.99,35.99,10.00,5.00};
        double ValorTotal = 0;

        
        for(int i = 0; i< Produto.Length;i++)
        {
            Console.WriteLine($"Selecione seu produto = {i +1} {Produto[i]} R$:{Preco[i].ToString("F2",CultureInfo.InstalledUICulture)}");

        }

        Console.WriteLine("_____________________________________");
        Console.WriteLine("Digite o codigo do seu produto");

        while(true){
             string [] entrada = Console.ReadLine().Split(' ');

             if (entrada.Length >= 2)
        {
            int codigo = int.Parse(entrada[0]);
            int Quantidade = int.Parse(entrada[1]);

            if(codigo >= 1 && codigo <= entrada.Length)
            {
                double valorUnitario = Preco[codigo -1];
                ValorTotal = valorUnitario*Quantidade;
                Console.WriteLine($"Valor total a pagar é de R$:{ValorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;          
            }
            else
            {
                Console.WriteLine("Código inválido!");
            }
        }
        else
            {
                Console.WriteLine("Entrada inválida. Digite o código e a quantidade separados por espaço.");
            }

        }
           
               
            
         
             
            
    

    }
}
*/

