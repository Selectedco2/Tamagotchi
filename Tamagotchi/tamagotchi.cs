class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string>words = new();
    private bool isAlive;
    private Random generator;
    public string name;


    public void Feed()
    {
        hunger = hunger-2;
    }

    public void Hi()
    {
        Console.WriteLine(words);
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        words.Add(word);

        
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger++;
        boredom++;
        isAlive = hunger < 10 && boredom < 10;
    }

    public void PrintStats()
    {
        if (hunger == 9)
        {
            Console.WriteLine("YOUR TAMAGOTCHI IS STARVING. FEED IT");
        }

        if (boredom == 9)
        {
            Console.WriteLine("YOUR TAMAGOTCHI IS DEPRESSED. PLAY WITH IT OR SOMETHING");
        }

        if (boredom >= 4 && boredom != 9)
        {
            Console.WriteLine("Your tomagotchi is getting hungry");
        }
        
        if (hunger >= 4 && hunger != 9)
        {
            Console.WriteLine("Your tomagotchi is getting bored");
        }

        else
        {
            Console.WriteLine("Your tamagotchi is happy and fed");
        }
        Console.WriteLine();
        Console.Write($"Your tamagotchi has {hunger} hunger and {boredom} boredom. Make sure none get to 10!!");
    }

    public bool GetAlive()
    {
        return true;
    }

    private void ReduceBoredom()
    {
        boredom--;
    }

}


