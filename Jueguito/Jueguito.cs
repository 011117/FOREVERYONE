using Logica;
public class VisualJueguito
{
    static void Main(){
        Console.Title = "FOREVERYONE";

    while(true)
    {
        
        Console.Clear();
        System.Console.WriteLine("Bienvenido presione Enter para continuar o Esc para salir");
        ConsoleKey key = Console.ReadKey(true).Key;
        switch(key)
        {
            case ConsoleKey.Enter:
            NewGame();
            break;
            case ConsoleKey.Escape:
            return;
            
          default:
               break;
        }
        
        
    }
    }
    private static void NewGame()
    {
        while(true)
        {
            Console.Clear();
        System.Console.WriteLine("Selecione una clase");
        System.Console.WriteLine("W- Warrior");
        System.Console.WriteLine("H- Hunter");
        System.Console.WriteLine("Z- Wizard");

        ConsoleKey key = Console.ReadKey(true).Key;
           switch(key)
           {
               case ConsoleKey.W:
                Warrior warrior =  new Warrior();
                NewGamePlayer(warrior);
                break;
                case ConsoleKey.H:
                Hunter hunter =  new Hunter();
                NewGamePlayer(hunter);
                break;
                case ConsoleKey.Z:
                Wizard wizard = new Wizard();
                NewGamePlayer(wizard);
                break;
                case ConsoleKey.Escape:
                Main();
                break;
               default:
               break;
           }
        }
    }
    private static void NewGamePlayer(Player player)
    {
        if(player.Exp >= player.ExpTotal)
        {
          LevelUp(player);
        }
        
        while(true)
        {
            Console.Clear();
            System.Console.WriteLine("Menu");
            System.Console.WriteLine("[S]tats");
            System.Console.WriteLine("[I]nventario");
            System.Console.WriteLine("[M]ision");
            System.Console.WriteLine("[A]rena");
            ConsoleKey key = Console.ReadKey(true).Key;
            switch(key)
            {
                case ConsoleKey.S:
                PrintStats(player);
                break;
                case ConsoleKey.M:
                Quest(player);
                break;
                case ConsoleKey.A:
                Enemy enemy = new Enemy();
                Battle(player,enemy);
                break;
                case ConsoleKey.I:
                Inventory(player);
                break;
                case ConsoleKey.Escape:
                Main();
                break;
                default:
                break;
            }
        }
    }
    private static void PrintStats(Player player)
    {
        while(true)
        {
          Console.Clear();
          System.Console.WriteLine("Fuerza : {0}",player.Fuerza);
          System.Console.WriteLine("Agilidad : {0}",player.Agilidad);
          System.Console.WriteLine("Inteligencia : {0}",player.Inteligencia);
          System.Console.WriteLine("Level {0}",player.Level);
          System.Console.WriteLine("Mana {0}",player.Mana);
          System.Console.WriteLine("Vida {0}",player.Life);
          System.Console.WriteLine("Energia {0}",player.Energy);
          System.Console.WriteLine("Exp: {0}/{1}",player.Exp,player.ExpTotal);
          System.Console.WriteLine("[A]tras");

          ConsoleKey key = Console.ReadKey(true).Key;
          if(key == ConsoleKey.A)
          {
              NewGamePlayer(player);
          }
        }
    }
    private static void Quest(Player player)
    {
        player.Exp += 5;
        
        while(true)
        {
            Console.Clear();
            System.Console.WriteLine("Enhorabuena a completado la mision y ha ganado 5 exp");
            System.Console.WriteLine("Presione Enter para regresar");
            ConsoleKey key =  Console.ReadKey(true).Key;
            if(key == ConsoleKey.Enter)
            {
                NewGamePlayer(player);
            }
        }
    }
    private static void LevelUp(Player player)
    {

        player.Exp = 0;
        player.ExpTotal += 50;
        player.Level += 1;
        if(player.Fuerza > player.Agilidad)
        {
            player.Fuerza += 3;
            player.Agilidad += 2;
            player.Inteligencia += 2;
        }
        else if(player.Agilidad > player.Fuerza)
        {
            player.Fuerza += 2;
            player.Agilidad += 3;
            player.Inteligencia += 2;
        }
        else if(player.Inteligencia > player.Fuerza)
        {
            player.Fuerza += 2;
            player.Agilidad += 2;
            player.Inteligencia += 3;
        }
        while(true)
    { 
      Console.Clear() ;
      System.Console.WriteLine("Felicidades ha subido de nivel!!!!!!");
      System.Console.WriteLine("Presione Enter para regresar");
      ConsoleKey key =  Console.ReadKey(true).Key;
      if(key == ConsoleKey.Enter)
      {
          NewGamePlayer(player);
      } 
    }
    }
    private static void Battle(Player player, Enemy enemy)
    {
        bool win = false;
        while(true)
        {
          Console.Clear();
          System.Console.WriteLine("Life:{0}  Enemy Life:{1}",player.Life,enemy.Life);
          var attack = 0;
          ConsoleKey tecla = new ConsoleKey();
          foreach(var item in player.Attacks)
          {
           attack = item.Value;
           tecla = (ConsoleKey)item.Key[0];
          System.Console.WriteLine("[{0}]{1}",item.Key[0],item.Key);
          }
          System.Console.WriteLine("");
          ConsoleKey key = Console.ReadKey(true).Key;
          if(key == tecla)
          {
              foreach(var item in player.Attacks)
              {
              System.Console.WriteLine("Has infligido {0} puntos de danno",item.Value);
              }
              System.Console.WriteLine("El enemigo ha infligido {0}",enemy.Attack());
              
              enemy.Life -= attack;
              if(enemy.Life <=0)
             {

             win = true;
             EndBattle(player,win);

             }
              player.Life -= enemy.Attack();
               if(player.Life <=0)
             {

              win = false;
              EndBattle(player,win);

             }
          }
          
        
        }
    }
    private static void EndBattle(Player player,bool win)
    {
       
        if(win)
        {
             while(true)
             {
             Console.Clear();
             
             System.Console.WriteLine("Has ganado!!!. Recibes 10 exp");
             player.Exp += 10;
             System.Console.WriteLine("Presione Enter para continuar");
             ConsoleKey key = Console.ReadKey(true).Key;
             if(key ==  ConsoleKey.Enter)
             NewGamePlayer(player);
             
             }
            
        }
        else if(!win)
        {
             while(true)
             {
            Console.Clear();
            
            System.Console.WriteLine("Has perdido!!!");
            System.Console.WriteLine("Presione Enter para continuar");
            ConsoleKey key = Console.ReadKey(true).Key;
            if(key ==  ConsoleKey.Enter)
            NewGamePlayer(player);
             }
        }
    }

    private static void Inventory(Player player)
    {
         while(true)
         {
             System.Console.WriteLine("Equipamiento:");
             foreach(var item in player.equipamiento)
             {
                 System.Console.WriteLine("{0} - {1}",item.Key,item.Value);
             }
             System.Console.WriteLine("\n");
             System.Console.WriteLine("Inventario:");
             System.Console.WriteLine("\n");
             System.Console.WriteLine("[A]tras");
             ConsoleKey key = Console.ReadKey(true).Key;
             if(key == ConsoleKey.A)
             {
                 NewGamePlayer(player);
             }
         }
    }

    }


