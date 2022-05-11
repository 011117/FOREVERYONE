using Logica;
public class Hunter:Player
{
       public Hunter()
    {
        this.equipamiento = new Dictionary<string, int>();
        this.inventario =  new Dictionary<string, int>();
        this.Attacks = new Dictionary<string, int>();
        this.Agilidad = 3;
        this.Fuerza = 1;
        this.Inteligencia = 1;
        this.Life = 100;
        this.Energy = 100;
        this.Level = 1;
        this.Mana = 0;
        this.Exp = 0;
        this.ExpTotal = 100;
        this.equipamiento.Add("Arco normal" , 2);
        this.Attacks.Add("Arrow",6);
        
    }
   
}