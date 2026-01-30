public class Produtos
{
    public string TipoProduto {get; private set;}
    public string Categoria {get;set;}
    
    public double Preco {get; private set;}

    private int CodigoProduto;

    public Produtos(string TipoProduto, string Categoria, double Preco, int CodigoProduto)

    {
        this.TipoProduto = TipoProduto;
        this.Categoria = Categoria;
        this.Preco = Preco;
        this.CodigoProduto = CodigoProduto;
        
    }
    

    
}
public class BancoDeDados 
{
    public Dictionary<string, Produtos> _produtos = new();

       
    public bool CadasTrarProduto (string TipoProduto, string Categoria, double Preco, int CodigoProduto)
    {
    
        if(_produtos.ContainsKey(TipoProduto))
        {
         Mostrar.exibir("Double kill enemy");
            
            return false;
        }
        {
           Produtos novos = new Produtos (TipoProduto, Categoria, Preco,CodigoProduto);
           _produtos.Add(TipoProduto, novos);
           return true; 
        }
    }
    

}
public static class Mostrar
{
  public static void exibir (string Mensagem)
  {
    Console.WriteLine(Mensagem);
  }
    
   
}