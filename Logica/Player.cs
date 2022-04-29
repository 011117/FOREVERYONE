namespace Logica;
public class Player
{
    public int Life{get;  set;}
    public int Energy{get; set;}
    public int Level{get;  set;}
    public int Fuerza{get; set;}
    public int Agilidad{get; set;}
    public int Inteligencia{get; set;}
    public int Mana {get; set;}
    public int Exp {get; set;}
    public int ExpTotal {get; set;}
    public  int Attack()
   {
      int damage = Fuerza + Agilidad + Inteligencia;
      return damage;
   }
}
