using System.Globalization;
using System.Linq.Expressions;

Console.WriteLine("Welcome to tamagotchi!");

Tamagotchi tama = new Tamagotchi();

Console.WriteLine("Choose a name for your tamagotchi");

tama.name = Console.ReadLine();

Console.WriteLine($"Awesome! {tama.name} is a sick name.");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();

while (tama.GetAlive() == true)
{
    Console.Clear();
    tama.PrintStats(); 
    Console.WriteLine("");
    Console.WriteLine("What would you like to do now?");
    Console.WriteLine($"1. Teach {tama.name} a new word");
    Console.WriteLine($"2. Talk to {tama.name}");
    Console.WriteLine($"3. Feed {tama.name}");
    Console.WriteLine("4. Do nothing");

    string action = Console.ReadLine();

    if (action == "1")
    {
        Console.WriteLine("What word?");
        string word = Console.ReadLine();
        tama.Teach(word);
    }

    if (action == "2")
    {
        tama.Hi();
    }

    if (action == "3")
    {
        tama.Feed();
    }

    if (action == "4")
    {
        Console.WriteLine("You sit and stare at your tamagotchi. It gets uncomfortable...");
    }

    while (action != "1" && action != "2" && action != "3" && action != "4")
    {
        Console.WriteLine("That's not an option");
        action = Console.ReadLine();
    }

    tama.Tick();
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}

Console.Clear();
Console.WriteLine($"OH SHIT. {tama.name} died");
Console.WriteLine("Press any key to quit");
Console.ReadKey();