public class Personagem
{
    public int Vida {get; private set;}
    public int Mana {get; private set;}
    public int Stamina {get; private set;}

    public Personagem(int vida, int mana, int stamina)
    {
        this.Vida = vida;
        this.Mana = mana;
        this.Stamina = stamina;
    }
    public void ReceberBonus (Raca racaEscolhida)
    {
        Vida += racaEscolhida.bonusVida;
    }
}
public abstract class  Raca
{
    public int bonusVida {get; protected set;}
}
public class Anao: Raca
{
    public Anao ()
    {
        bonusVida = 20;
    }
}