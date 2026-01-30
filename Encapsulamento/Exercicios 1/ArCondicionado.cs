public class ArCondicionado
{
    public int MaxTemperatura {get; private set;}

    public int MinTemperatura {get; private set;}

    public int temperatura {get; private set;}

    public ArCondicionado(int temperaturaAtual )
    {
       
        MaxTemperatura = 30;
        MinTemperatura = 16;
        if ( temperaturaAtual > MaxTemperatura)
        {
            temperatura = MaxTemperatura;
        }
        else if (temperaturaAtual < MinTemperatura)
        {
            temperatura = MinTemperatura;
        }
        else
        {
            temperatura = temperaturaAtual;
        }
            
    }

    public void AumentarTemperatura ( int aumentar)
    {
        temperatura += aumentar;
     

        if(temperatura > MaxTemperatura)
        {
            Console.WriteLine("Error, temperatura não pode ultrapassar o valor maximo de 30");

            temperatura = MaxTemperatura;
        }
        else
        {
            Console.WriteLine($"A temperatura subiu para {temperatura} ");
        }
    }
     public void DiminuirTemperatura ( int diminuir)
    {
        temperatura -= diminuir;
     

        if(temperatura < MinTemperatura)
        {
            Console.WriteLine("Error, temperatura não pode baixar o valor minimo de 16");

            temperatura = MinTemperatura;
        }
        else
        {
            Console.WriteLine($"A temperatura baixou para {temperatura} ");
        }
    }

    
   
}