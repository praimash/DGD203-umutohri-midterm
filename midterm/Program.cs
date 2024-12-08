using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace game;


internal class Program
{
    

    public static void Main()
    {
      
      Gamemenu gamemenu = new Gamemenu();
     


        {
            
            gamemenu.chooseCharacter();
            gamemenu.quest();
            gamemenu.healthbar();
            gamemenu.question1();
            gamemenu.healthbar();
            gamemenu.rule();
            gamemenu.question2();
            gamemenu.healthbar();
            gamemenu.rule();
            gamemenu.question3();
            gamemenu.healthbar();
            gamemenu.rule();
            gamemenu.question4();
            gamemenu.healthbar();
            gamemenu.rule();
            gamemenu.finish();

        }






    }
}
   
  
