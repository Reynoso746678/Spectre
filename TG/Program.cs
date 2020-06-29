using System;
using System.Collections.Generic;
using System.Linq;

namespace TG
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            Console.Title = "Text Adventure";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 95;
            
            gameTitle();

        }

        static void PromptToPressAnyKey()
        {
            Console.WriteLine("\nPress any key...\n");
            Console.ReadKey();
        }

        
        public static void gameTitle()
        {
            Console.WriteLine(@"
                                _    .  ,   .           .
                *  / \_ *  / \_      _  *        *   /\'__        *
                  /    \  /    \,   ((        .    _/  /  \  *'.
            .   /\/\  /\/ :' __ \_  `          _^/  ^/    `--.
                /    \/  \  _/  \-'\      *    /.' ^_   \_   .'\  *
              /\  .-   `. \/     \ /==~=-=~=-=-;.  _/ \ -. `_/   \
            /  `-.__ ^   / .-'.--\ =-=~_=-=~=^/  _ `--./ .-'  `-
            /       `.  / /       `.~-^=-=~=^=.-'      '-._ `._
                                Welcome to Spectre
            ");
            PromptToPressAnyKey();
            Console.Clear();
            Console.WriteLine("before we continue, What is your age?");
            Console.ReadKey(true);
            int age;
            
            if (int.TryParse(Console.ReadLine().Trim(), out age))
            {
                if (age >= 18)
                {
                    Console.Clear();
                    Console.WriteLine("Great, you're at a perfect age to play, get ready.");
                    PromptToPressAnyKey();
                    Console.Clear();
                    second();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hmm..");
                    PromptToPressAnyKey();
                    Console.Clear();
                    Console.WriteLine("You're a bit too young. Goodbye");
                    Console.WriteLine("Press Enter to try again");
                    PromptToPressAnyKey();
                    Console.Clear();
                    gameTitle();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I said age");
                PromptToPressAnyKey();
                Console.Clear();
                gameTitle();

            }

        }

        
        public static void second()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string choice;
            Console.WriteLine("After a long perilous Journey to find the cure for you sick mother"); 
            Console.WriteLine("you took a trail into a forest that an old woman from\na local town you passed by told you about");
            Console.WriteLine("after what seems like hours of aimlessly following a \ntrail that seemed to dissapear after every step");
            Console.WriteLine("You finally see a break from the trees..");
            PromptToPressAnyKey();
            Console.Clear();
            Console.WriteLine(@"
                  ^
                 / \
            ^   _|.|_   ^
          _|I|  |I .|  |.|_
          \II||~~| |~~||  /
           ~\~|~~~~~~~|~/~
             \|II I ..|/
        /\    |II.    |    /\
       /  \  _|III .  |_  /  \
       |-~| /(|I.I I  |)\ |~-|
     _/(I | +-----------+ |. )\_
     \~-----/____-~-____\-----~/
      |I.III|  /(===)\  |  .. |
      /~~~-----_________---~~~\
     `##########!\-#####%!!!!!| |\
    _/###########!!\~~-_##%!!!\_/|
    \##############!!!!!/~~-_%!!!!\
     ~)#################!!!!!/~~--\_
  __ /#####################%%!!!!/ /
  \,~\-_____##############%%%!!!!\/
  /!!!!\ \ \~-_###########%%%!!!!\
 /#####!!!!!!!\~-_#######%%%!!!!!!\_
/#############!!!\#########%%%!!!!!!\
            
             ");
            Console.WriteLine("You arrive at an eerie Castle..");
            Console.WriteLine("Leaves, mud, and remnants of old rusty armor are scattered about");
            PromptToPressAnyKey();
            Console.WriteLine("From your surroundings, it looks like no one, if anything has been around for quite awhile..");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Walk towards the Castle");
            Console.WriteLine("2. Look around");
            Console.WriteLine("3. Run back from wince you came");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower().Trim();
            Console.Clear();
             switch (choice)
             {
                 case "1":
                 case "walk towards the castle" :
                 case "walk" :
                 {
                    Console.WriteLine("You decide to start walking towards the castle..");
                    Console.WriteLine("Passing up decaying bones and mice running past your ankles, you proceed");
                    PromptToPressAnyKey();
                    Console.Clear();
                    Console.WriteLine("you arrive at the gate house..");
                    PromptToPressAnyKey();
                    Console.Clear();
                    Console.WriteLine("..You let yourself in");
                    PromptToPressAnyKey();
                    Console.Clear();
                    third();
                    break;
                 }

                 case "2" :
                 case "look around" :
                 case "look" :
                 {
                    Console.WriteLine(@"

            |>>>+           |~|_|~|_|~|                              |>>>+
            |              _|---------|_          .                  |
    |~|_|~|_|~|_|~|       [_|_________|_]         |>>>>>+      |~|_|~|_|~|_|~|
    |_____________|         |=========|   +       |            |_____________|
      | [].~[] .|           | ~ [+].  |   +       |              |.~[]. [].|
      |_________| |>>       |  .   ~  |  /~\   u-u|u-u-u         |_________|
         \   /    |         | ~ [+] . |  |u|   |. .O . |            \.. /
     #   ||.|~|_|~|_|~|     |. ~ .    |  |~|   | . O. .|         |~|_|.|_|~|_|~|
   #'#   ||.-u-^^-u-u-u^^~-~-~-~-~-~-~-~~---~~-~-~-~^^-~-~-~-~^^-u-u-u-u-u-u-u-u
  ####   ||  . --  ~ . --  . ^    . ~ .  .   ^  .   --  .  .  -- . .   ||\ o |
 ###`##  || . /**\ .  /**\  |V| ~  .[o] . ~ |V|  . /**\ .   ./**\     .||  \_|
#`##~##  ||   |[]|    |[]|  |.|-v-v-v-v-v-v-|.|    |[]|      |[]| .    || o o\
##~#\### ||.   -- .  ~ --   |o| .~_______~ .|o|    .--    .   -- ~  .  || ~ .|
##\###\# ||  . ~  ~     .   |o|  .|\:|:/|.  |o| .  ~  ~  .  ~    .   ~ || .~ |
#\#'##/# ||.    .  ~ .~   . |.|. ~|::|::|~ .|.|  .   ..~   ~ .  ~ .   .||.__~|
#~#\/##  ||_________________|_|___|/:|:\|___|_|________________________|| ||.|
 ##/#    /------------------------_______------------------------------||_||_|
  ||    /''''''''''''''''''''''''_________'''''''''''''''''''''''''''''''''''''\
  ||   /''''''''''''''''''''''''___________'''''''''''''''''''''''''''''''''''''|
  ||__/''''''''''''''''''''''''_____________''''''''''''''''''''''''''''''''''''|
 _|/''''''''''''''''''''''''''_______________'''''''''''''''''''''''''''''''''''|
/''''''''''''''''''''''''''''_________________''''''''''''''''''''''''''''''''''|                 
                    ");
                    Console.WriteLine("After arriving and noticing all the rusted armor pieces \naround you, you decided to take a peek");
                    Console.WriteLine("as if you were one of the mice looking for a desperate \nmeal, you hastily scavenge anything around you..");
                    Console.WriteLine("only if you noticed it.. if the greed didn't..");
                    PromptToPressAnyKey();
                    Console.Clear();
                    death();
                    break;
                 }

                 case "3" :
                 case "run back from wince you came" :
                 case "run" :
                 case "run away" :
                 {
                     Console.WriteLine("As you see some rotting corpses in the distance, you mumble under your breath \n'Oh nah, Fuck this' \nyou turned around as quickly as you appeared");
                     Console.WriteLine("while you walked towards the forest you entered, you start noticing a fog that \ndidn't seem to be there before");
                     Console.WriteLine("As you mumble more obsceneties under your breath, you start hearing another set \nof foot steps besides your own. ");
                     PromptToPressAnyKey();
                     Console.Clear();
                     Console.WriteLine("You become weary and start to hurry the pace, problem is that you lost the \ntrail you were following");
                     Console.WriteLine("You become more frantic as the fog is so thick at this point you can't even \nsee your hands in front of your face");
                     Console.WriteLine("Fear starts to set in, you start to sweat");
                     Console.WriteLine("Everything goes black..");
                     PromptToPressAnyKey();
                     Console.Clear();
                     gameOver();
                     break;
                 }

             }

        }
        public static void third()
        {
            
            Console.WriteLine(@"
                  [\
                  |\)        
                  |          
                  Y\         
                 T  \     
                J    \   
               Y/T`-._\ 
               /[|   ]|                 |\         
               | |    |                 J'         
               | |  ] |    _           /;\         
              [| |    |    L'         /;  \
             /||.| /\ |   /\         /.,-._\       
            /_|||| || |  /  \        | |{  |       
  L/\       | \| | '` |_ _ {|        | | U |   /\
 /v^v\/\   `|  Y | [  '-' '--''-''- -'`'   | ,`^v\ /\,`\
/ ,'./  \.` |[   |       [     __   L    ] |      /^v\  \
,'     `    |    |           ,`##Y.   ]    |___Y Y____,_,,_,,_
--   -----.-(] [ |   ]     o/####U|o      ]|| /`-, Y   _   Y  Y
   Y Y  --;`~T   |      }   \####U|[\ _,.-(^) ,-'  _  (^)__  _
  Y  YY   ;'~~l  |   L     [|\###U'E'\  \ \Y-` _  (^) _Y  _
 Y  Y Y   ;\~~/\{| [      _,'-\`= = '.\_ ,`   (^)(^) (^) (^)
     --   ;\~~~/\|  _,.-'`_  `.\_..-'  _ . ,_ Y_ Y_ _Y  _Y__
    _    _; \~~( Y``   Y (^) / `,      (^)      _   (^) (^)
   (^)  (^)`._~ /  L \  _.Y'`  _  ` --  Y - - -(^) - Y - Y -
    Y    Y    `'--..,-'`      (^)   _  -    _   Y ____
      --           _    _ --   Y   (^)   _ (^)  ===   ----
          __   -  (^)  (^)      --- Y   (^) Y
      _            Y    Y                Y          
            
            ");
            Console.WriteLine("as you walk into the gatehouse, you notice something.. off");
            Console.WriteLine("The courtyard is quite, no more mice running around, no \nwind bustling through.. just.. noiseless");
            PromptToPressAnyKey();
            Console.Clear();
            Console.WriteLine(@"
            
    ████████████████████████████████████▓▓▓▓▓▓█▒▓▓▓▓▓▒██▒██▒▒▒▒▒▒▒╠▒▒▒╠║║║
    ████████████████████▒▓███▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒║▒▒▒▒▒▒▒▒▒▒▒║╢Ñ╠⌠╠││╫▀
    █████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒╢▒▒║▒▒▒▒║║╠╠╠╠╠││║│Ñ
    █████████████▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▓▓███▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒╠∩╠║║║║║╠╠╠│╠Ñ║║
    ██████████▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▒▓████▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒║║║║║║╠║╠╠║║║║║
    ███████▒▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒║▒║║║║║║║║║║║║║▒
    █████▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▒███████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒║║║║║║║║║║║║║▒▒▒
    ███▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓███████▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒║║║║║║║║║║▒▒▒▒▒
    █▓▒▒▒▒▒▒▒▒▒▒║║║║║▒▒▒▒▒▒▒▒▒▓▓▓█▓▒███████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒║║║║║▒▒▒▒▒▒▒▒
    █▓▒▒▒▒▒▒▒║║║║║║║║║▒▒▒▒║▒▒▒▒▓▓▓▓▒███████▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓
    ▒▒▒▒▒▒▒▒║║║╠╠││╠║║▒║▒▒▒▒▒▒▒▓█▓█▒████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓
    ▒▒▒▒▒▒▒║║╠╠││││▐║║║▒▒▒▓▒▒║▓██████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓
    ▒▒▒▒▒▒║║╠╠│∩∩│∩╚║∩`│▒▒░║▓█████████████████▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓
    ▒▒▒▒▒║║║╠││∩∩∩ ╙│╔░▒▓▓▒▒▒█████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓
    ▒▒▒▒▒▒║║╠│∩│∩∩`:│║░▓▓▓▓▓███████████████████▓▓▓█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓█
    ▒▒▒▒▒▒║║╠∩∩│∩∩` ╚▒▓▓▓▓▓▓▒███████▓██████████▓▓▒█▓▓▒▓▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██
    ▓▒▒▒▒▒║╠║∩∩∩   :▒▓▓█▓███████████████████████████▒▓▓█▒▓▓▒▒▒▒▒▒▒▒▓▓▓▓███
    ▓▓▓▒▒▒▒║∩╚┤∩`┌ ║▒▓███████████████████████████████▓▓██▓▓█▒▒▓▒▒▓▓▓▓▓▓███
    █▓▓▓▒▒▒▒▒╢║∩(∩(▓▒▓████████████████████████████████████▓█▓▒█▓▓▓▓▓▓▓████
    ███▓▓▓▒▓▒▒▒░░╞▒▓██████████████████████████████████████████▒█▓█▓▓██████
    █████▓▓▓▓▓▒▒▒▒▓▒███████▒██████████████████████████████████████████████
    ██████████▓▓▒▒█████████▒██████████████████████████████████████████████
    ██████████▓▓▓█████████████████████████████████████████████████████▓███
    ████████████████████████████████████████████████████████████████▓▓▓███
            
            ");
            string choice;
            Console.WriteLine("An Unnatural Fog starts rolling through the courtyard\n You turn around and notice a figure moving as effortlessly towards you");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Go deeper into the castle");
            Console.WriteLine("2. Walk towards the shadow");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower().Trim();
            Console.Clear();
            switch(choice)
            {
                case "1" :
                case "deeper" :
                case "go deeper" :
                case "go deeper into the castle" :
                {
                    Console.WriteLine("You quickly start running as if your legs \nalready knew what to do");
                    Console.WriteLine("As you run into the Castle, you suddenly hit the ground... ");
                    Console.WriteLine("while on the ground you look what you tripped on");
                    Console.WriteLine("as your eyesight refocuses you see a rock");
                    PromptToPressAnyKey();
                    Console.Clear();
                    Console.WriteLine(@"
                           ,--.
                          {    }
                          K,   }
                         /  `Y`
                    _   /   /
                   {_'-K.__/
                     `/-.__L._
                     /  ' /`\_}
                    /  ' /     
            ____   /  ' /
     ,-'~~~~    ~~/  ' /_
   ,'             ``~~~%%',
  (                     %  Y
 {                      %% I
{      -                 %  `.
|       ',                %  )
|        |   ,..__      __. Y
|    .,_./  Y ' / ^Y   J   )|
\           |' /   |   |   ||
 \          L_/    . _ (_,.'(
  \,   ,      ^^''' / |      )
    \_  \          /,L]     /
      '-_`-,       ` `   ./`
         `-(_            )
             ^^\..___,.--`
                    
                    ");
                    Console.WriteLine("It wasn't a rock");
                    Console.WriteLine("The remains of a past adventurer");
                    Console.WriteLine("then you notice something moving in the corner of your eye..");
                    PromptToPressAnyKey();
                    Console.Clear();
                    fifth();
                    break;
                }
                case "2" :
                case "walk" :
                case "shadow" :
                case "walk towards the shadow" :
                {
                    Console.WriteLine("You decide to take fate into your own hands");
                    Console.WriteLine("Confidence in your self.. or complete idiocy..\nyou decide to walk towards the shadow in the fog");
                    PromptToPressAnyKey();
                    Console.Clear();
                    Console.WriteLine("fog envelopes you, you can't see where you're walking or even your hands in front of your face");
                    Console.WriteLine("But you do hear.. footsteps and a grey figure prominently in the fog");
                    PromptToPressAnyKey();
                    Console.Clear();
                    fourth();
                    break;
                    
                }


            }
            
        }

        public static void fourth()
        {
            Console.WriteLine("You see the figure stop a few feet in front of you");
            Console.WriteLine("Your heartbeat is racing, you feel the adrenaline coursing through you veins");
            Console.WriteLine("It speaks");
            PromptToPressAnyKey();
            Console.Clear();
            Console.WriteLine(@"
    ██████████████████████████████████████████████████████████████████████
    █████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓████████████████████████
    █████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████████████████████
    █████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒█▓▒▓▒▒▓▓▓▓▓▓▓▓▓████████████████████
    █████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒███▒▒▒▒▒▒▓▒▓▓▓▓▓▓▓▓▓▓█████████████████
    ███████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒▓▓▓▓▓▓████████████████
    ████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒║▓█▒╢▒║▒▒▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓██████████████
    ██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌║║███▒∩Ñ▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓█████████████
    ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓║██▒╠█████∩∩▒▒▒▓▒▒▒▒▒▒▒▓▓▓▓▓▓████████████
    ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒║▀█▒▄████M█╡Ñ║M▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓███████████
    ███▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓║╠║║║██████╚╙∩#╙██▒▒▒▒▒▒▒▒▒▓▓▓▓███████████
    ███▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒█▒║╠│╡║███████│▒Γ║█▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓██████████
    ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓███░╠└└║Ñ███████▒▒╓█▒▒▌▒▒▒▒▒▒▒▒▓▓▓▓▓██████████
    ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒█████│K╓,└╚█████▀╫∩▓▒║▒Ñ▒▓▒▒▒▒▒▓▓▓▓▓▓██████████
    ███▓██▓▓▓███▓▓█▓▓▓▓▒▒║▒║▒▒█▒█▒▒▓▒▄:████║▌╠╢▒▒▒║▒▓▓▒▒▓▒▒▓▓▓▓▓██████████
    ████████████████▓▓▓▒▒▒▒║█║▒▒║▒▒▒▒╠█▒██▒█┤║▒▒▒Ñ▒▒█║▓▒▒▓▓▓▓▓▓▓██████████
    ██████████████████▒▒▒▒║▒║█║▒▒▒█▒▒╢║███▀║▒▒║█∩║▒▒▒▒▒▒▒▒▓▓▓▓▓▓██████████
    █████████████████▒▒▒▒▒║█▒█▌║▒▒║█▒▒▒█▀∩#▒║║▒Ñ╔▒▒║Ñ║█║▓▒▒▓▓▓▓███████████
    █████████████████▒█▒▒▓▒█▒▒█▒▒▒▒▒███▒▒▒▒▒▒▒Ñ║║▒▒▒║█▒║▓▒║▓▓▓████████████
    █████████████████▒█▒▒║▒║█║▒█▒▓▒▒█▀▒▓▒║▒║▓╠║╢▒▒▒▒██▒█▒▒▒███████████████
    ████████████████▓██▓▒▒█▒█▒▓████▒▒▓▒║▒▒▓▒║▒▒▒║▓▒║█▒▓█▒▓▓███████████████
            ");
            Console.WriteLine("'Why are you here'");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. looking for something");
            Console.WriteLine("2. Here for a challenge");
            Console.WriteLine("3. Run");
            Console.WriteLine("Choice: ");
            string choice;
            choice = Console.ReadLine().Trim().ToLower();
            Console.Clear();
            switch (choice)
            {
              case "1" :
              case "look" :
              case "looking" :
              case "looking for something" :
              {
                Console.WriteLine("Please, I'm looking for medici-");
                Console.WriteLine("It interupts you");
                PromptToPressAnyKey();
                Console.Clear();
                Console.WriteLine("Oh.. you're just like the rest");
                Console.WriteLine("Always in need..");
                PromptToPressAnyKey();
                Console.Clear();
                Console.WriteLine("The only thing that you could see in this fog, fades away");
                PromptToPressAnyKey();
                Console.Clear();
                death();
                break;
              }
              
              case "2" :
              case "here" :
              case "here for a challenge" :
              {
                Console.WriteLine("You smirk");
                Console.WriteLine("I'm here for a cha-");
                Console.WriteLine("It interupts you");
                PromptToPressAnyKey();
                Console.Clear();
                Console.WriteLine("Oh.. you're just like the rest");
                Console.WriteLine("Sad");
                PromptToPressAnyKey();
                Console.Clear();
                Console.WriteLine("The only thing that you could see in this fog, fades away");
                PromptToPressAnyKey();
                Console.Clear();
                death();
                break;
              }

              case "3" :
              case "run" :
              {
                Console.WriteLine("You decided to get away from the figure, as quickly as possible");
                PromptToPressAnyKey();
                death();
                break;
                
              }
            }
            PromptToPressAnyKey();
            Console.Clear();
            
        }
        
        public static void fifth()
        {
            Console.WriteLine("While looking in the corner you start to hear something hollow dropping");
            Console.WriteLine(".. then some metal scraping on the ground..");
            PromptToPressAnyKey();
            Console.Clear();

            Console.WriteLine(@"

                                       ╓#ñ
                                    ╓#▓▀└
                                 ╓#▓▓╙
                              .╔▓▓╜`
                           .╔▓▓▀╙       .╓»x╓,
                        .╓▒▓▓╙        ╔║║∩││`│▒▄
                      ╓#▓▓▀`         ╓▒║▒▒▓▒▒▒▒█Γ
                   ╓#▓▓▓╙            ║▒▒▒▒╓║▒▒,║Γ
            (∩▓ ╓#▓▓▓╜                ▓▀▓▒▒║▒██▓
            ╞░█▓██▀                   ▒▒██▓█▌
         .##╢▓██▀                      │▒▓███
        .║███▒███                #m,   ╞▒███
     ▄▄#██▀███                ╓▒▒▓▓▓║░#╢║╙▀▀▓
    ▓██▌   ▀▒█▄             .#▓╙╙░║▒▒║▄▒▀▀█▓▓▒▒½▒M▄,
     ╙╙     ╙▒█▌          .#▓  ⌠▒▓▓│▓▒▒▒▒▒▒▒▒▒▓█▓▒▒,
             ╙▓▀▌       .#▓  ╓║▀▓▓╚▒▒▄▄▄╠╠Ñ╠▒▒▒▒▀╙╙▒▄
               ██▌    ╓#▒  .▄▒▒▒▒∩▒▓▓▒▒Ñ╠╠╠╠▒▒▓▒    ╙▓m
                ▀█▓»#░╜     ╓▒▓▒▒▓▒█▒▓▒Ñ│╙╠╠╠▒▒█       ╙▓m
                 └▓█▀'      ▒▓▓█Ñ║▒║▓█╙╙╙╙▒▒▒▒▓          ╙▓m
                           .▓█▓╜╙▄#║▓▒▀▀▀▒▒▀▒▓             ╙▒M,.
                           ╓█`.#╙▄R╙║▒▒▓▓▓▀▒▓∩          .▄▓███████▓▓▄,
                                   (░╙██▒▒█╙           ┌███████████████▓▄
                                   ▐░║▒▓╙              ║███████████████████▄
                              .,,, ║▒╫█▒,              └█████████████████████▄
                             ▒▒▒▒╢▒▓▓▓█▓m#▓▓µ           ▀██████████████████████▄
     
              ");
              string choice;
              Console.WriteLine("An armed skeleton appears");
              PromptToPressAnyKey();
              Console.WriteLine("Clearly the reason for the skull");
              Console.WriteLine("A crack of its hips and it starts walking towards you");
              Console.WriteLine("What do you do?");
              Console.WriteLine("1: Fight");
              Console.WriteLine("2: Run");
              Console.WriteLine("Choice: ");
              choice = Console.ReadLine().ToLower().Trim();
              Console.Clear();
              switch(choice)
              {
                case "1" :
                case "fight" :
                {
                   Console.WriteLine("You decide to fight the skeleton");
                   Console.WriteLine("Even though, you don't have a weapon..");
                   PromptToPressAnyKey();
                   Console.Clear();
                   Console.WriteLine("Pulling back you fist, you decide to swing");
                   Console.WriteLine("The skeleton unfazed, raises its metal shield");
                   Console.WriteLine("You felt a crunch as it deflects the punch, and you wreath your fist in pain");
                   Console.WriteLine("then you feel a sharp pain through your stomach");
                   PromptToPressAnyKey();
                   Console.Clear();
                   gameOver();
                  break;
                }

                case "2" :
                case "run" :
                {
                  Console.WriteLine("You stumble to your feet at the sight of it");
                  Console.WriteLine("As you feet scrape the floor to get away");
                  Console.WriteLine("You see an entrance to the castle");
                  PromptToPressAnyKey();
                  Console.Clear();
                  Console.WriteLine(@"
          
          ▓▓▓▒║▒▓██▒▒▒▒▓▒▒▒▒▒▓▓╢▒▀▀▀╢╢╫║█▒█▀██▒▒██████▓▒║▒▓▒
          ▓▓█▓▓▓███▒▒▓▒▒▒▒▓▒▒▒▒▒▒▒▒▒▒▒▒▒╡╢╫║▒▒╢▒▀████▒█▓▓█▒▒
          ██████▓██▒▓▓▒██▒▒█▒▒▒╠║▒▒▒▒║█▒╠▀▒▓╫▒NN║▒║▒▒▓▒█▒▓▓█
          ███▓▒▒▒▀▒███▒▒▒║▒▒▓╫▓▒▒▒▒▒▓▓▓▓█▒▒N╢▒▀▒▓▒║╢▒█▒▀███▒
          █▒▓║▒╢███▒▒██▓█╠ÑÑ║M#Q▒▒▒▒▒#MÑÑÑ╙▀▓▓▒▒▒▒█▓▒▀▒║▓▓█▓
          █▒▓▒███▓▒██▀ÑÑ╠▒▓▓█▀▒▒▒▒▒▀║▒▒█▓▓▓▒NÑ▀▀▓▒║▒███▒╠▀╙║
          ▒▒▒██▓████▓▒▓▒▀╢║▒▒▓▓▓▒▒▒▓▓▓▓▒▒Ñ║▒▀▒▒#╙██▒╙▓▒▓▒║▒∩
          ▓▒██▓▒███▒██▒║▒▓▒▒▓▒▒▒▒██▓▒▒▒▒▒▒▒╫Ñ╢Ñ╫█▒▒▀▓▒║╠█▒▒▒
          ▒█▓█▒█▒▒▒█████▓▓▒███▒█▓▓▓▓▓▒▒█▓█▒▒╢▒▒╢║█▄▀▒█▒▒▓▒M╫
          █▒▒▒█Ñ║║█▀▀██▒▒█▒▒████████████▒▓██▒▒▒▓▒▓║█Ñ▒█▒▒▒█▒
          ██▓▓█▒▒██▓▓▒▒▓▒▒█████████████████▒██▒▓▒▒▓█∩╬║▒▒▒██
          █████▒▓█▓▒█▒╫▒████████████████████▒║█▓█L/╫█▀██████
          █████▒█▒▒█▀▀║▓████████▒██▒▒▒███████▓█▓▓▓▒▓█╠║████▒
          █▒█║▒▒▒█▀▀░N▒║████▓█▓▓██████▒▒█████▓█▒▒█████║██▒▒█
          ▒▒▒█▒█║▒▒╠║╠▌║███▒▒▓██▒▒█▓▓▓▒▓▒████▒║▒╠ ╓▄█║▒█▒▓▒█
          ▓█▒█▒▌╫Ñ▒║▒║▓████▒▒█▒▒║▒█▒▒▒▒██▒███▒▒█▒∩║▒█Ñ▒║▓║▒╢
          ▓█║▒▒▒█║▒Ñ│▐▒██▓▓▒▒▓▒▒▒▒█▓▒▒▒▓▓▒████▒▒▒M∩▒║▒▒▒█▒▓▒
          ▒██▒█▒█║∩│∩║░███████▓▓▓▓█▓█▒▓█▓▓████▒▒∩∩ ▒║█╢▒██▒▒
          █▒█▒▓▒▌║╙╠∩║▐██▒▒▒██▒▒▒▒█▒▒▒▒██▒▒███▒█▓▒∩║║▒▒▒▒▓█▒
          █▓█▓▒█▒▓║∩│▒║███▒▓╢▓▓▒▒▒█▒▒▒▒▓▓▓▓███▒║▒▒∩║╢█▒▒▒█░▒
          ████▒█╢▌M∩│▓╫███▒▒███▒▒▓█▒▒▒████████▒╢▓▓∩∩╙║▓▒▒███
          Ñ█▒█▒█║▒╢┼W▌█████████▒█▒█▒▒▒█████████▒█▒╠∩░║█╫▒║█║
          ∩▒│▒▐▒║∩│∩▐▒█████████▓▒▒█▒▓▓█████████╢█▒╢∩║║▒▒▒║▒Ñ
          (╜│`▐`║` └║M██████████▒▒██▒██████████▒█║Ñ└╚∩║╚╠└▒╚
          ╫M╢╖▒N▒   ║▐█████████▒██▒██▓█████████▌║∩` ▐M▒M▓#▒░
          ▓▒#█▒NN▌  ▒▐██▓█████████▒█▒██████████▒▐∩ ╓▌│Ñ║▌▄▄╫
          ▒W┐║▒∩└▒  ╞║█████████▒▒██▓▒██████████▌▒  ║▌│╠█▌╚╙║
          ░│Ñ█║∩:▓  ║╫████▓▓███████████▓█▓██████║∩ ⌠▌└╚║█∩N║
          ││:█╔:(▌∩^███▓M▓▓▓▓▒╢╜▒▒▒▒▒▒MMM▒╢▓▓▓▓██M∩N█:N║▓∩∩⌠
          ∩│║█QQ▒▒▒▒▒▒▒▒▒▒▒▒▒▀▒▒▒▒▒║▒▒▒▒╙▒▒▒▒▒▒▒▒▒▒██▓▓██▌││
          █▒█▒▒▒▒███▒██▒▒▒╠▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒╠╠▒▒▒║▒▒▒█▒█▒▒▒
          ╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙╙▀╙╙╙╙▀▀▀▀▀▀╙╙▀▀╙╙╙
                  ");
                  
                  Console.WriteLine("Doors bigger than anything back at home");
                  Console.WriteLine("You rush to the door");
                  Console.WriteLine("you start hearing a scraping noise following you");
                  Console.WriteLine("Afraid to look back you push the door");
                  PromptToPressAnyKey();
                  Console.Clear();
                  Console.WriteLine("It opens");
                  PromptToPressAnyKey();
                  Console.Clear();
                  Console.WriteLine(@"

            ▒▒▒▒Ñ╙┘╫╢▄µ╙∩∩╙╙Ñ∩∩∩∩╓»∩.;∩(y│∩(∩▒▒▒╙∩N½╖N∩⌠∩:╙N∩∩»¿∩││╓#Ñ∩│
            ╝╢#╬▒K▒▀║▒▒▒M(∩:∩:┌╓╜└`.▄#▀Ñ∩∩∩│∩∩      7∩,└┤∩∩∩│∩│∩│∩┘∩││Q▄
            ╙╙Q▄««┘ⁿ½┤╙╢Ñ▒⌠⌠│#╜└.▄∩└   │▄▓██▓▓#╗╗▄▄, 7┌∩│ ╘∩└▄▄▄æ#∩╙╙╙ÑÑ
            └┌╔╔NNN∩N∩∩░½▒│╓╜:.#╙   ╓▄▓▒████████████▒▓▄│░  `,└  ..┌╔│∩││
            │Ñ∩│∩N┘ ÑN│∩║║Ñ└ #Ñ  .▄▓███████████████▒▒▒▒▒░NN╔ ∩∩│∩│N│∩∩∩│
            │@µ∩┐∩∩m#░││∩│∩╓╚` ┌▄▒████████████████▒▒▒▒▒▒▒▒∩Ñ∩∩│NN∩∩∩)⌠∩∩
            æ½M∩╙╙╙╙╙╙╫▄∩ #∩ ⌠╓▒█████████████████████████▒▒∩│∩│││N│┤∩⌐∩∩
            ││∩∩∩│∩│╢N┤Ñ:║∩ │╔▒████████▒██████████████████▒M ∩▐∩N∩∩╙∩⌠││
            ∩∩:│∩∩∩N▒Ñ│∩N░  ║▒████████████████████████████▌Ñ∩│∩M▐╚N╚M∩\│
            ∩∩N∩∩N│ÑÑ∩│∩.∩∩y▒████████████▒███████║██████▒▒▒M┤∩▐Γ║∩╚╚∩└,7
            ∩∩N╙░║∩▐▒▒╢╠║∩ ║▒▒▒██████████▓▓▒▒▒▒███▓███████▓#∩N║MMM#║K╚∩7
            ∩N@╢░║▒▒▒▒╢M╜M╙╠▓▒▒▒▒██▓██████████████████████▓╠│╠R,⌠║╙Ñ░╙LV
            N├╠│╞▒░▒▒Ñ╠║▒▒▒████▒▓████████████████████████▒▒▓ÑN╠Ñ║M║∩NN∩∩
            │├M║∩││▒Ñ╠∩∩Ñ∩▐▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒Ñ╡∩∩ÑM∩│K││#║
            │∩∩│Ñ││▒▒ÑN∩╙│║▒▒███▓▒▒▒▒▒▒▓█▓▓███████▒▓▒▒▒▒▒█▒MÑ╢∩∩│∩│╙∩∩│║
            │╚│║┤N┼▒▒▒╢⌠╓∩▒▓▒▒▒▒▒▒▒█▓█▓▓▓▒▒█▓▓█▒▒▒█▒▒▒▒▒▒▒▓Ñ║║Ñ║∩N∩╓∩│⌠║
            AN║╙▒▒▒▒▒▒║║╚║║▒▒▓▓▓▓▓▓▓▓█▓▓▒▒▒▓▒▒▒▒▓▓▓▒▒▒▓╢▒▓▓-║╠╡∩│ÑÑ║│║║║
            │NN⌠Ñ║║▒▒▒▒║║N║▒▒█▒███▓██▓▓▓▒▓╢▓▒▒▒▓▒▒▒▒▓▓██▓▒▓ ║║∩│││┤║╠║╠║
            ╠╫╡╠Ñ║║▒▒▒▒▒║║║▒║█▒▒▒▒▒▒▒▒▒▒▓▒▓▓▓█▒▒▒▒▓▓█▒█▓▒█¡║╠╡N∩∩╠Ñ∩╠║║
            ║∩╙╚NÑ║▒▒║▒║║╠║▓██▓▒▒▒▒▒▒▒██▒▒▒▒║▒▓██▓▓▓▒▓▓█▓▒▒∩║ÑÑ▒│⌠Ñ╠Ñ╫Ñ║
            ║░∩▐∩║▒▒▒╢▒▒▒▒║▓███▒▓▒▒▒▒▒███▓██▒▒█▒▒▒██▒██▒▓▓▓│▒▒Ñ▒║╢││║║▒▀
            ║║Ñ╠║Ñ╠▒▒╢▒║║▒╫▒███▒▓▒▒▓▒▓██▒▒█▌▓▒▒▒█▓█▒▒▓▓▒███│▒▒W▒║M∩│Ñ║║▓
            ║║┤╠║║║▒▒▓Ñ║║▒█▒██▒▒█▒▒█▒▒███▓▓▒▒▒█▒█▓▒█▒▓▓▒██▌│▒Ñ╠Ñ║╢Ñ∩Ñ╠▒╢
            ║╠║║║╢╫▒▒▒║▒║║█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█.▒║║║┤│┤┤║Ñ║║
            ║║║╠╢╢▒▒▒▒║║║║█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█(▒┤∩╙Ñ╠╠ÑÑ╠╢║
            ║║∩║║╠▒▒▒Ñ▒║║╠████▒█████▒▒▓████▒▒▒█▒█████▓█▒██▌└╢Ñ╢║Ñ║║N╠Ñ▒║
            ║║║Ñ║╠▒▓▒▒║║║║████████████▓████▒▒▒║▓█████▒█▓██▌│Ñ║Ñ╫▒∩║Ñ∩▀Ñ║
            ║╢║║║║▒▒▒▒▒║║▐████▓▒▓▓▓▓▓██▓███▒█▒██▓██▓▓▓▓███▌N∩╠║Ñ║▒▒▒▒▒▓█
            ╠░╢╠╢║▒▒▒▒╢▒╠║████▒█████▒██▓██████▒▒███▓▓█████▌/▒Ñ║▒╢▓▒▒▒▒║║
            ╢║Ñ║∩║▓▒▒▒▒║║║█████████████▒███▒█▒▒▒▓█▒█▒█▓▒██▒▐▒▒▓▓▒▒▒║╢▒▒▓
                  ");
                  Console.WriteLine("You hastily shut it when you get in");
                  Console.WriteLine("fearing its not enough, you find a wood beam");
                  Console.WriteLine("and bar it from ever opening again");
                  PromptToPressAnyKey();
                  Console.Clear();
                  sixth();
                  break;
                }
              }
        }

        public static void sixth()
        {
          Console.WriteLine("You hear frustrated thumps at the door as you catch your breath");
          Console.WriteLine("Knowing you're safe, for the time being");
          Console.WriteLine("What do you want to do?");
          Console.WriteLine("1. Look around");
          Console.WriteLine("2. Rest");

          Console.WriteLine("Choice: ");
          string choice;
          choice = Console.ReadLine().Trim().ToLower();
          Console.Clear();
          switch (choice)
          {
            case "1" :
            case "look" :
            case "look around" :
            {
               Console.WriteLine(@"
          
    ▒▒▒║╢▒▒▒▒▒▒║║║║║║║║║Ñ│││∩∩∩∩∩∩∩∩∩∩∩∩│N∩(∩\)∩∩∩∩∩∩∩∩∩∩∩∩└││┤ÑÑ║║║║║║║║│║║║▒Ñ║▒███
    ▒▒║║║║║║║║║║║║║║││Ñ∩∩│N∩▄▄▄▄▄▄╗████████████▄N∩∩││∩           ╚║╠╠║Ñ│Ñ║║▒▒║▒█████
    ▒▒▒║║║║║║║║║║║║│      ∩▐██████████████████████▓║║║              │││║║║▒║║▓█████▒
    ╢▒║║▒╢▒║║║║║║║││        ██████████████████████▒▒║                  ║║Ñ║██████▒▒▒
    █▒▒▒▒▒▒▒▒▒╢║║          ⌠▀▀█████████████████████▒▒║                  │▓████▒▒║▒▒▒
    █████▓█▒▒▒▒▒║║            Ñ▀██████████████████▓▒▒║║╠               N▒█▒▒║▒▓▒▓▒▓█
    ████████████▒▒░             ⌠▀████████████████▒║▒╢╢║║║               ▒▒▒║▒█▒▓██▒
    ▓▓▒▓▓▒▒║████▒                 ║███████████████▓██▓▒╢Ñ║               ▒▒▒▓╢██▒▒██
    █████▓▓▒▒▓▒╢█▒                ▓███████████████▒███▒▒Ñ                ▓▒▓█▒██▒▒██
    ██████████▓▓█∩                ▒████████████████▒▒▒▒▒Ñ               ║▒██████▒███
    ▓███████████▒                 M████████████████▒██▒╚ML               ██▒█▒▒█▒███
    ████▒███▒▒██▒                  ███████▀███████▒▒▓▒▒MM▒Γ⌠             ║█║╢╢╢▌████
    ██████▒██▒█▒╢                  ▓██▒██▒▒▒██▒███▒▒▒▒▒N∩║               ║▒▒╢│▒▓████
    ███████▒▒▒█▒▒▒N               ▓███▒▒▒▒▒▒▒▒▒█████▒▒▓▓╢░              M▓▒║▒▒▒▓████
    ████████╢╢Ñ▒██▒              ╢████▒▒▒▒▒▒▒▒▒██▒█▓▓▒N▒▒░              ▒█▒▒▒▓▒▓████
    ██████▒▒▒▓▓▒╫█▒╫            ▓▀▓▓██▒▒▒▒▒▒▒▒▒███▒█▓▓▒╠▒▓              █▒║▓▓▒▒█████
    █████▒██████▒                  ███▒▒▒▒▒▒▒▒▒███▒▓▒▒▒╢∩▒               ║█▒▒▒╠█████
    █████▒██████▒                  ███▒▒█████▒▒████▒▓▒▒▒╢∩▒              ║█▒▒▒╠█████
    █████▒▒▓▓▓▒▒▀▒╕         ║╢▒M▒▒▒▒║║▒█▒█▒▒▒▒██▒▓▒▒▒╠░░~#∩(╔╔∩«#⌐ ▐  │  ║██████████
    ██████▒██▒▒▒▀       M╠▒▒██▓▓▓▓▓█████████████████▓╙║▒▒╢╢█▓┤╢▒░N║▓▓▓▓║╠Ñ║█▒▒██████
    █▓█████▒█▒▒▒∩∩` ╘╪╢╣╛║▓▓▀▒▓▓▓▀▀╣▓▀▀▀▓██▀▒████▒██▒╠▓▓▓┼╫▒▒▒▒║▒▒▒▒██▒▒╠▒▓█▒▒▒█████
    ██▀▀▀▀║╪╝▒Ñ▒Ñ   │Ñ║▒╠╠N▓M▀▀Ñ╫▓▓▀Ñ████Ñ▒▒▒█▒▒███▒Ñ▒▓▒╢╡│╫██╡║╫█▓█╢╫█▒▒▒▒▒▒▒▒█▒███
    ÑÑ▒╙Ñ╠│▓▀▀▀NN   ∩│Ñ▒▓█▀▀Ñ▒▓▀▀▒∩▓██▀½┼▓▓█▓╡▄████Ñ╠▒▒▒Ñ││▒██▒▒∩▀██▓▒▒╙▒█▓▓▒▒▒█▓███
    Ñ▄▀▀▀▀▀K▓▓▓▒M⌂.:N║╠│Ñ▒▒▒▒▒ÑÑ╠██▀▀∩K▓▓▓▓M┼æ████▄│▄▒▓▒Ñ││╠███▒∩Ñ▀███▒╠▒████▒▒▓▓██▓ 
          ");
              Console.WriteLine("With a quick glance you can see a chair.. maybe a throne?");
              Console.WriteLine("A lot of beautiful adornments of royalty bestrewn on the floor");
              PromptToPressAnyKey();
              Console.Clear();
              Console.WriteLine("The chair seems to calling to you");
              Console.WriteLine("You start walking to the chair");
              Console.WriteLine("Hearing constant whispers, you never noticed the fog \nSweeping through the room coming from the cracks of the door");
              PromptToPressAnyKey();
              Console.Clear();
              seventh();

              break;
            }
            case "2" :
            case "rest" :
            {

              Console.WriteLine("You decide to rest");
              Console.WriteLine("A little worn out, you pick a corner and slip into a nap");
              PromptToPressAnyKey();
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("Not knowing that you'd never wake up again");
              PromptToPressAnyKey();
              Console.Clear();
              gameOver();
              break;
            }
          }
        }
        
        public static void seventh()
        {

          Console.WriteLine("You touch the throne");
          Console.WriteLine("The whispers stop");
          Console.WriteLine("A low bellow voice echoes the chamber");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("'I know why you are here'");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("'I have a proposition for you..'");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("'If you answer my riddle correctly, I'll give you the medicine'");
          Console.WriteLine("'but..'");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("'If you lose'");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("'You will be our new king'");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("'Rule these lands.. and the dead'");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("'Lets begin'");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          phrases();
          
        }
        
        public static void eighth()
        {
          ghost();
          Console.WriteLine("Be proud");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("You may have the medicine");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("But we will meet again");
          PromptToPressAnyKey();
          Console.Clear();
          ghost();
          Console.WriteLine("Farewell");
          PromptToPressAnyKey();
          Console.Clear();
          youWin();
        }
        public class Riddle
        {
          public string Text { get; set;}
          public string Answer { get; set;}

          public bool IsCorrect(string answer)
          {
            return String.Compare(answer, Answer, true) == 0;
          }
          
        }
       public static void phrases()
        {
          var riddles = new List<Riddle>()
            {
              new Riddle { Text = "I have cities, but no houses. I Have Mountains, but no trees. \nI have water, but no fish. \nWhat am I?", Answer = "a map"},
              new Riddle { Text = "I speak without a mouth and hear without ears. \nI have no body, but come alive with the wind. \nWhat am I?" , Answer = "an echo"},
              new Riddle { Text = "You measure my life in hours and I serve you by expiring. \nI'm quick when I'm thin and slow when I'm fat. \n The wind is my enemy. \nWhat am I?", Answer = "a candle"}

            };

            Random random = new Random();

            foreach (var riddle in riddles.OrderBy(r => random.Next()))
              {
                  Console.WriteLine (riddle.Text);

                  do
                  {
                      var answer = Console.ReadLine().Trim().ToLower();
                      if(riddle.IsCorrect(answer))
                      {
                        Console.Clear();
                        Console.WriteLine("Correct");
                        PromptToPressAnyKey();
                        Console.Clear();
                        Console.WriteLine("You are worthy");
                        PromptToPressAnyKey();
                        Console.Clear();
                        eighth();
                        break;
                      }
                      Console.Clear();
                      Console.WriteLine("Wrong");
                      PromptToPressAnyKey();
                      Console.Clear();
                      Console.WriteLine("You are not worthy");
                      PromptToPressAnyKey();
                      Console.Clear();
                      gameOver();
                      break;
                  } 
                while (true);
                break;
              }
         }
    
        

        public static void restart()
        {
          string choice;
          Console.WriteLine("So you died, wanna go again?");
          Console.WriteLine("1. Yes");
          Console.WriteLine("2. No");
          choice = Console.ReadLine().Trim().ToLower();
          Console.WriteLine("Choice: ");
          Console.Clear();
          switch (choice)
          {
            case "1" :
            case "yes" :
            {

              Console.WriteLine("Good Choice");
              PromptToPressAnyKey();
              Console.Clear();
              second();
              break;
            }
            case "2" :
            case "no" :
            {
              Console.WriteLine("Disapointing");
              PromptToPressAnyKey();
              Environment.Exit(0);
              break;
            }
          }

        }

        
        public static void death()
        {
          Console.WriteLine(@"
                    
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╠╔█████████▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒░│▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒∩ ╝██████████▌║▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒▒┐╓└▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╬/`╙█████████░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒▒▒▒▓▄╙▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒#╢║█████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒▒▒▒▒▓▓▓╬▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐████████╒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒▒▒▒▒▒▒█▓▓▄╙▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒k▀███████║▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓█M╬▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╠▄███████╚▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒╠▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╜╠▄▄▄▄▄▓▓██████████▓▄╙╙▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒╙#██████████████████████▓▄╙▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▒▒▒▒▒▒▒▒▒╙╫██████████████████████████▓ ║▒▒▒▒▒▒▒▒▒▒▒▒▒

▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▒▒▒▒,▄████████████████████████████ ║║▒▒▒▒▒▒▒▒▒▒▒▒

║║║║║║║║║║║║║║▒▒▒▒▒▒▒▒▒▒▒▒▒▒║▒▒▓▓█▓██████████████████████████████ ║║▒▒▒▒▒▒▒▒▒▒▒▒

║║║║║║║║║║║║║║║║║║║║║║║║║║║║║║║ ║████████████████████████████████,╚║║▒▒▒▒▒▒▒▒▒▒▒

╠║║║║║║║║║║║║║║║║║║║║║║║║║║║║ ▄▓█████████████████████████████████▓ ║║║║║║║║║║║║║

│││││││╠│╠╠╠╠╠╠╠╠╠╠╠╠╠╠╠╠╠Ñ ▄▓█████████████████████████▀▒█████████⌐Ñ║║║║║║║║║║║║

│││││││││││││││││││││││∩░`▄▓█████████████████████████▀Ñ╠║║████████∩│╠╠╠╠╠╠╠╠╠╠╠╠

∩∩∩∩∩∩∩∩│∩││││││││││││∩│ ▓██████████████████████████▓▓░│││╙███████┌│││││││││││││

               :∩∩∩∩∩∩  ▄████████████████████████∩│Ñ╙▒▓▓▓▒▄│██████└│││││││││││││

                      `╒█████████████████████████∩∩  `└└╙▒▓▓██████  ∩∩│∩∩∩∩∩∩∩∩∩                 
                    
                    ");
                    Console.WriteLine("You felt a sharp pain, you look down..");
                    Console.WriteLine("you see a knife tip between your chest and fog creeping at your feet..");
                    Console.WriteLine("Everything turns black..");
                    PromptToPressAnyKey();
                    Console.Clear();
                    gameOver();
        }

        public static void gameOver()
        {
            Console.WriteLine(@"
            
     
     
                                   ∩∩
                           .:
                        ┌⌠:: `::::              . ∩   ;┐
                      ≈⌠∩∩∩∩(∩∩∩∩: : :                   ∩╔
                    ┌N∩⌠N∩∩││∩∩│∩∩∩     :   :   ::(:∩ .(:∩│░,
                  (│∩│∩│││N∩∩∩∩∩∩∩∩∩∩∩∩∩ :∩:::∩∩∩∩└`∩   └`∩└│╔
                ╓∩∩││∩│││││││∩NN∩∩∩∩∩│∩∩∩∩ ∩  :│⌠∩∩∩∩  .╔∩│∩∩│∩
              ╓N∩││││║NN┤│N││││║░∩││││∩∩:∩.∩;∩∩∩` ∩∩y¿││∩││╔░╓│∩
             ╔│││││││N∩Ñ║╢∩││N║║║║∩∩∩∩∩∩∩∩⌠∩╓#M∩∩(┌┐│Ñ∩│║║▓▓▓▓▓▓▄∩
            (∩⌠│││∩╚∩│││││∩││║║╠║║╠∩∩∩∩╓#▓▓▓▓▓▒▒▒╠∩│▒╙╙╙M║██████▓▓░
            │││∩│∩╠∩NN││Ñ│∩∩││╠╠╠║░∩∩╠▒▓▓▓▓▓▓▒▒▒▒║│╙Ñ∩∩││▒▓▀▒▒╢▓▒▒Ñ,
            │││││∩∩▐N┤N▒∩││││╚║║║║╠▒▒║▒▓▓▓▓▓▓▒▓▒▒▒▒M∩╙K∩⌠(▄▄▄╠║╢║║║∩
             ││Ñ│∩│╜Ñ│∩∩└M∩∩│││Ñ╠Ñ│╠╢▒▒▒▒▒▒▀▒▒║▒║▒║█▒∩∩║╢████▒Ñ║║Ñ║N∩
              │∩│#∩│∩│││∩│∩∩∩∩╚∩∩│∩∩│║║▀███▌║▒▒║╠║║▀∩⌠(╙║▀████░│∩╙╙Ñ∩∩
              └││Ñ││││││││∩∩∩∩│∩∩│││││║▒╠╚█▓▒▒Ñ║║Ñ∩∩∩∩:∩▐║█████M╙╓▒∩│∩∩,
               └│∩│∩││││││N∩⌠│∩│╠∩∩└││∩│∩╙╙╙Ñ││⌠│▄∩∩∩∩.j███████▌│╙ÑÑ∩∩│)
                │ÑÑ║╠║╠╠╠╠╠║║│║╢▒░∩N│╚∩│∩∩N├∩││║█▀∩∩∩∩:│████████∩│∩∩∩│N∩
                 │╚│╠╠║║║╠║░║║▒▒Ñ││││∩NNÑ│N∩NNM││∩:∩:∩∩ └▀███▀█▒NN│∩`
                  │∩╠║╠║║║╢╢║╠╠║║╠Ñ╠╠║║╠║Ñ║∩N│││╙∩∩∩∩│∩  ` │∩┐.╚∩∩║,
                  └@µÑ║║▓█▒#▒░║Ñ║╠▒▒▒▒▒║║║Ñ╓╓#N│∩│⌠│││∩∩∩∩∩│║∩∩∩├│╠∩∩,
                    ╢▒│╠███▒▒██▓████▒▓████████▓▓NNN│││∩∩│N││∩│((▄≈R║∩╡
                     ╘╠▓║▓████▒▒▒▒▒║▓▓█▓▒██████▒▒▒▒║║╠│║▒▒M╙▒▒╙▌└▀▌ '║⌐
                       ╙║║▒████▓Ñ╙╠Ñ║▒▒▒▒╙██▀▀Ñ▀█▓▒▒╫▓▓█Ñ█▌∩╙▌∩╙∩└║∩.╙╙`
                       : ╙╠║▓█▓▓▓∩│││╚Ñ║│∩╙▓▒▒▒╢║▒╙▒╙▀∩▀∩│▀L▄╫╖▄║▓▐MMM
                        └││╠Ñ╠║▒▒▓║┤││││║╠N╙▓▒▒▓Ñ▒█▓▒m▒╠└║Ñ∩▒∩(█▒█▓▒Ñ║
                          └N│║╚╙▒▒▒║╠∩∩╠╠║╢∩∩╙▒╚╙▀█▓▒▒▒▒⌂║█▄█▒╠▀░Ñ║║▒∩∩
                               `└└Ñ║║Ñ║║∩║║▒║N││╢▒░∩╙▒▒║Ñ░╢│Ñ╠∩╙╙∩:╠││∩
                                  │╠║║╠▒║║╠║╠║∩∩Ñ,└│╘╙└││││∩│N⌠∩(│││║N∩∩
                                   ╙║║║║║║╠║║║░∩∩Ñ∩∩∩ :│NM∩││││░NNÑ│║░M∩
                                    ╙╫▒║▒▓▓▓▓▒▒║║∩░N∩∩∩│∩╓∩∩⌠╙║╠╠░∩⌠││∩│
                                        └ └└└╙╙▒▒░│║∩∩│N∩││││││∩∩││N│╓N∩
                                               └└└╙╙╜╫╪▒▒▒▒▒▄▒▒▒▒▒▒╙╙`
            ");

            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over");
            PromptToPressAnyKey();
            Console.Clear();
            restart();
        }

        public static void youWin()
        {
            
            Console.WriteLine(@"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~   ~~~~~~~~~~~~~~~~~~~~~~~~
            ");
            Console.WriteLine("You finally made it back");
            Console.WriteLine("You win");

            PromptToPressAnyKey();
            Environment.Exit(0);
        }

        public static void ghost()
        {
          Console.WriteLine(@"
    ██████████████████████████████████████████████████████████████████████
    █████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓████████████████████████
    █████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████████████████████
    █████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒█▓▒▓▒▒▓▓▓▓▓▓▓▓▓████████████████████
    █████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒███▒▒▒▒▒▒▓▒▓▓▓▓▓▓▓▓▓▓█████████████████
    ███████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒▓▓▓▓▓▓████████████████
    ████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒║▓█▒╢▒║▒▒▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓██████████████
    ██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌║║███▒∩Ñ▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓█████████████
    ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓║██▒╠█████∩∩▒▒▒▓▒▒▒▒▒▒▒▓▓▓▓▓▓████████████
    ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒║▀█▒▄████M█╡Ñ║M▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓███████████
    ███▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓║╠║║║██████╚╙∩#╙██▒▒▒▒▒▒▒▒▒▓▓▓▓███████████
    ███▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒█▒║╠│╡║███████│▒Γ║█▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓██████████
    ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓███░╠└└║Ñ███████▒▒╓█▒▒▌▒▒▒▒▒▒▒▒▓▓▓▓▓██████████
    ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒█████│K╓,└╚█████▀╫∩▓▒║▒Ñ▒▓▒▒▒▒▒▓▓▓▓▓▓██████████
    ███▓██▓▓▓███▓▓█▓▓▓▓▒▒║▒║▒▒█▒█▒▒▓▒▄:████║▌╠╢▒▒▒║▒▓▓▒▒▓▒▒▓▓▓▓▓██████████
    ████████████████▓▓▓▒▒▒▒║█║▒▒║▒▒▒▒╠█▒██▒█┤║▒▒▒Ñ▒▒█║▓▒▒▓▓▓▓▓▓▓██████████
    ██████████████████▒▒▒▒║▒║█║▒▒▒█▒▒╢║███▀║▒▒║█∩║▒▒▒▒▒▒▒▒▓▓▓▓▓▓██████████
    █████████████████▒▒▒▒▒║█▒█▌║▒▒║█▒▒▒█▀∩#▒║║▒Ñ╔▒▒║Ñ║█║▓▒▒▓▓▓▓███████████
    █████████████████▒█▒▒▓▒█▒▒█▒▒▒▒▒███▒▒▒▒▒▒▒Ñ║║▒▒▒║█▒║▓▒║▓▓▓████████████
    █████████████████▒█▒▒║▒║█║▒█▒▓▒▒█▀▒▓▒║▒║▓╠║╢▒▒▒▒██▒█▒▒▒███████████████
    ████████████████▓██▓▒▒█▒█▒▓████▒▒▓▒║▒▒▓▒║▒▒▒║▓▒║█▒▓█▒▓▓███████████████
          ");
        }
    }
}
