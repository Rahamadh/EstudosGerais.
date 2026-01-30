using System;
using System.Collections.Generic;

using System.Globalization;

namespace Exercicios
{
     class Progran

    {
       static void Main (string[]args)
        {
           /* 
            Console.WriteLine("Digite 3 numeros separado por espaço");
            List<int> number = new List<int>();
            int indece;
            
           string [] entrada = Console.ReadLine().Split(' ');
           
           for( int i = 0; i<entrada.Length; i++)
            {
              if(int.TryParse(entrada[i], out int valor))
              {
               number.Add(valor);      
              }
              else
                {
                    Console.WriteLine("Numero invaçodo");
                }
            }
            Console.WriteLine(number[0]);

          


           */
        /* Carros carros = new Carros();

         carros.AdcionarPreco(TiposCarro.Caravan,50.00);
         carros.AdcionarPreco(TiposCarro.Variante,40.00);
         carros.AdcionarPreco(TiposCarro.Opala,60.00);

         carros.VerTodosOsCarros();

         */
         /*
         Console.WriteLine("Digite um numero profano");
         double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         
        
        while ( x >= 0.0)
         {
         double raiz = Math.Sqrt(x);
         Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
         Console.WriteLine("Digite outro numero maligno");
         x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
         }
         Console.WriteLine("Numero invalido");
         */
        }  
    }




  


    public class Carros
    {
        private Dictionary<TiposCarro, double> carros = new Dictionary<TiposCarro, double> ();

        public void AdcionarPreco (TiposCarro tipo, double valor) // metodo para acrescentar valor aos carros
        {
            carros[tipo] = valor;
        }
    
    
     public  double VerPrecoCarro(TiposCarro tipos)  //Metodo para acessar valor do dicionario.
        {
           if(carros.TryGetValue(tipos, out double preco))
           {
                return preco;
            }
            else
            {
                Console.WriteLine("Carro invalido");
                return 0;
            }
        }

     public void VerTodosOsCarros ()
        {
            foreach(var car in carros)
            {
                Console.WriteLine($"Modelo {car.Key} Preço {car.Value:F2}");
            }
        }   
        public Carros()
        {
            carros[TiposCarro.Fusca] = 20.00;
            carros[TiposCarro.Brazilia] = 30.00;
        }
    }
    public enum TiposCarro
    {
        Fusca,
        Brazilia,
        Variante,
        Opala,
        Caravan,

        
    }
}