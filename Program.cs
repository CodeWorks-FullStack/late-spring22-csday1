// // JS (Import) CS Using
// using System;
// using System.Collections.Generic;
// using System.Threading;
// using day_1.models;

// // Captial letters everywhere!!!

// // Pascal case (UpperCamelCase) for globals and method names
// // the end of every statement must terminate with ';'
// // Console.WriteLine("Hello, World!");

// // Variable Declarations
// // var, const, T
// // Cannot change type after initialization

// // Implicit
// // var firstName = "Mark";
// // Console.WriteLine(firstName);

// // Explicit (providing type)
// // string lastName;
// // lastName = "Ohnsman";

// // Primitives

// // STRINGS
// // defined by "  (no more ` or ' for string)

// // Concat
// // string fullname = firstName + " " + lastName;

// // Interpolation ($ with {} inside the string)
// // string fullname = $"Hello I am {firstName} {lastName}";

// // multi line string (@)
// string rock = @"
//   ____           __           __________               __    
//   |    |    _____/  |_  ______ \______   \ ____   ____ |  | __
//   |    |  _/ __ \   __\/  ___/  |       _//  _ \_/ ___\|  |/ /
//   |    |__\  ___/|  |  \___ \   |    |   (  <_> )  \___|    < 
//   |_______ \___  >__| /____  >  |____|_  /\____/ \___  >__|_ \
//           \/   \/          \/          \/            \/     \/
// ";




// // SECTION Fun with the Console
// Console.BackgroundColor = ConsoleColor.Black;
// Console.ForegroundColor = ConsoleColor.Green;
// Console.Beep();
// Console.Clear();
// Console.WriteLine(rock);
// Console.Write("  What's your name?  ");
// string name = Console.ReadLine();
// string greeting = $"Wake up {name}";

// for (int i = 0; i < greeting.Length; i++)
// {
//   Console.Write(greeting[i]);
//   Thread.Sleep(200);
// }

// // Numbers
// // JS (Number) C# (int, double)

// // Bool (true, false)
// // NO MORE TRUTHY / FALSEY

// // if (greeting.Length > 0)
// // {
// //   System.Console.WriteLine("Helo");
// // }

// // NO Undefined only NULL


// // REFERENCE

// // ARRAY (Not as useful as it once was)

// // on creation the array is provided a length, it is never longer, never shorter
// String[] arrCats = new String[3];
// arrCats[0] = "Mittens";
// arrCats[1] = "Oscar";
// arrCats[2] = "Snowball";
// // cats[1] = null;

// // LIST (the array you want)
// // must be instantiated
// List<String> cats = new List<String>() { "HotShot", "Jerry", "Tim" };

// cats.AddRange(arrCats);

// List<String> formalCats = cats.FindAll(c => c.Length > 4);
// System.Console.WriteLine("");

// // Loops

// //FOR
// // for (int i = 0; i < cats.Count; i++)
// // {
// //   string cat = cats[i];
// //   System.Console.WriteLine(cat);
// // }

// // For Each
// foreach (string cat in cats)
// {
//   Console.WriteLine(cat);
// }

// cats.ForEach(cat => Console.WriteLine(cat));



// // Objects
// // There is a POCO.... Don't use it.

// // Dictionary Key Value Pair

// Dictionary<string, int> catAges = new Dictionary<string, int>();

// catAges.Add("Wiskers", 9);
// catAges.Add("Mittens", 2);
// catAges.Add("Hope", 1);
// catAges.Add("Orion", 104);
// catAges.Add("Rosy", 3);

// if (catAges.ContainsKey("Hicup"))
// {
//   Console.WriteLine(catAges["Hicup"]);
//   catAges["Hicup"] = 7;
// }



// Class
using System;
using System.Threading;
using day_1.models;

Park thePark = new Park();

Console.Clear();
Console.WriteLine(@"
         _       __     __                             __               __                           _         ____             __  
        | |     / /__  / /________  ____ ___  ___     / /_____         / /_  ________________ ______(_)____   / __ \____ ______/ /__
        | | /| / / _ \/ / ___/ __ \/ __ `__ \/ _ \   / __/ __ \   __  / / / / / ___/ ___/ __ `/ ___/ / ___/  / /_/ / __ `/ ___/ //_/
        | |/ |/ /  __/ / /__/ /_/ / / / / / /  __/  / /_/ /_/ /  / /_/ / /_/ / /  / /  / /_/ (__  ) / /__   / ____/ /_/ / /  / ,<   
        |__/|__/\___/_/\___/\____/_/ /_/ /_/\___/   \__/\____/   \____/\__,_/_/  /_/   \__,_/____/_/\___/  /_/    \__,_/_/  /_/|_|  

");
bool running = true;
while (running)
{

  Console.WriteLine("Here are the available dinos:");
  Console.WriteLine(thePark.ParkList());
  Console.WriteLine("Press (a) to adopt or (h) to hatch or (q) to quit");
  char input = Console.ReadKey().KeyChar;
  Console.WriteLine("");

  switch (input)
  {
    case 'a':
      System.Console.Write("Which Dino:  ");
      string name = Console.ReadLine();
      if (thePark.RemoveDino(name))
      {
        Console.WriteLine("Enjoy... JP is not liable for any damage or loss of life or limb");
      }
      else
      {
        Console.WriteLine("Invalid Name");
      }
      break;
    case 'q':
      running = false;
      System.Console.WriteLine("Goodbye");
      break;
    default:
      System.Console.WriteLine("Unknown input");
      Console.Clear();
      break;
  }
  Thread.Sleep(1500);
  Console.Clear();

}



