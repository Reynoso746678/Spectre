using System;

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
                    first();
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

        public static void first()
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("So you want to play? Lets play");
            PromptToPressAnyKey();
            Console.Clear();
            Console.WriteLine("Enter your name");
            string userName = Console.ReadLine().Trim();
            Console.Clear();
            Console.WriteLine(@"
    _____________________________
 / \                             \.
|   |      You are hereby        |.
 \_ |    contracted to finish    |.
    |      the death game        |.
    |     any involvement in     |.
    |     leaving will result    |.
    |       in your demise       |.
    |                            |.
    |                            |.
    |                            |.
    |   _________________________|___
    |  /                            /.
    \_/dc__________________________/.
             ");
             Console.WriteLine("Signed: " + userName);
             PromptToPressAnyKey();
             Console.Clear();
             Console.WriteLine("Now that the formalities are finished lets continue..");
             PromptToPressAnyKey();
             second();
        }

        public static void second()
        {
            Console.Clear();
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
                    
                    
                    
                    ");
                    Console.WriteLine("After arriving and noticing all the rusted armor pieces \naround you, you decided to take a peek");
                    Console.WriteLine("as if you were one of the mice looking for a desperate \nmeal, you hastily scavenge anything around you..");
                    Console.WriteLine("only if you noticed it.. if the greed didn't..");
                    PromptToPressAnyKey();
                    Console.Clear();
                    Console.WriteLine("You felt a sharp pain, you look down..");
                    Console.WriteLine("you see a knife tip between your chest and fog creeping at your feet..");
                    Console.WriteLine("Everything turns black..");
                    PromptToPressAnyKey();
                    Console.Clear();
                    gameOver();
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
            Console.WriteLine(@"'
                  [\
                  |\)                                ____
                  |                               __(_   )__
                  Y\          ___               _(          )
                 T  \       __)  )--.          (     )-----`
                J    \   ,-(         )_         `---'
               Y/T`-._\ (     (       _)                 __
               /[|   ]|  `-(__  ___)-`  |\          ,-(  __)
               | |    |      (__)       J'         (     )
   _           | |  ] |    _           /;\          `-  '
  (,,)        [| |    |    L'         /;  \
             /||.| /\ |   /\         /.,-._\        ___ _
            /_|||| || |  /  \        | |{  |       (._.'_)
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
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadKey();
            youWin();
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

            Console.WriteLine("Game Over");
            PromptToPressAnyKey();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.WriteLine("You win");
        }
    }
}
