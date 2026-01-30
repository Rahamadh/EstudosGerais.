public class BancoDeDados
{
    private Dictionary <string, Usuario> _bancoDeDanos = new ();


    public bool Cadastrar (string email, string senha)
    {
        if(string.IsNullOrWhiteSpace(email)&& string.IsNullOrWhiteSpace(senha))
        {
            Console.WriteLine("Hmmmm temos um problema");
            return false;
        }
        else if(_bancoDeDanos.ContainsKey(email))
        {
            Console.WriteLine("Esse usuário já existe");
            return false;
        }
        else
        {
            Usuario newUser = new Usuario (email, senha);
            _bancoDeDanos.Add(email, newUser);
            Console.WriteLine($"Usuário cadastrado com sucesso com a senha");
            return true;
        }
    }
    public bool Logar (string email, string senha)
    {
        if(_bancoDeDanos.TryGetValue(email, out var encontrado))
        {
            return encontrado.ValidarSenha(senha);
        }
        else
        {
            Console.WriteLine("Senha invalida");
            return false;
        }
    }


}
public class Usuario
{ 
    public string Email {get; private set;}
    private string Senha {get;set;}
    public Usuario (string email, string senha)
    {
        Email = email;
        Senha = senha;
    }
    public  bool ValidarSenha (string senha)
    {
        if(senha == Senha)
        {
            Console.WriteLine("Senha invalida bem vindo");
            return true;
        }
        else
        {
            Console.WriteLine("Senha invalida");
            return false;
        }
    }
   
}
