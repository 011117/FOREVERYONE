using Logica;
public class Enemy
{
    public int Life {get; set;}
    public Enemy()
    {
        this.Life = 100;
    }
    public int Attack()
    {
        return 5;
    }
}