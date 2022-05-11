using Logica;
public class Wizard:Player
{
   
   public Wizard()
   {
       this.equipamiento = new Dictionary<string, int>();
       this.inventario =  new Dictionary<string, int>();
       this.Attacks =  new Dictionary<string, int>();
       this.Agilidad = 1;
       this.Inteligencia = 3;
       this.Fuerza = 1;
       this.Life = 100;
       this.Level = 1;
       this.Energy = 100;
       this.Mana = 30*this.Inteligencia;
       this.Exp = 0;
       this.ExpTotal = 100;
       this.equipamiento.Add("baston normal" , 2);
       this.Attacks.Add("Magic",6);
   }
   
}