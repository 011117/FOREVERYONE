using Logica;
public class Warrior : Player
{
   public Warrior()
   {
       this.equipamiento = new Dictionary<string, int>();
       this.inventario =  new Dictionary<string, int>();
       this.Attacks =  new Dictionary<string, int>();
       this.Life = 100;
       this.Energy = 100;
       this.Level =  1;
       this.Fuerza = 3;
       this.Agilidad=1;
       this.Inteligencia = 1;
       this.Mana = 0;
       this.Exp = 0;
       this.ExpTotal = 100;
       this.equipamiento.Add("espada normal", 2);
       this.Attacks.Add("Sword",6);
      
   }
    
   
}