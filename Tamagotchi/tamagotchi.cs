class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string>words = new();
    private bool isAlive;
    private Random generator;
    public string name;

    public Tamagotchi()
    {
        isAlive = true;
    }
    public void Feed()
    {
        Console.WriteLine($"You feed {name} and he gets less hungry");
        hunger -=2;

        if(hunger > 0)
        {
            hunger = 0;
        }
    }

    public void Hi()
    {
        if (words.Count == 0)
        {
            Console.WriteLine($"{name} does not know any words yet, you gotta teach it something first");
        }

        else if (words.Count < 0)
        {
            int wordNum = Random.Shared.Next(words.Count);
            Console.WriteLine($"{name} says: {words[wordNum]}");
            ReduceBoredom();
        }

    }

    public void Teach(string word)
    {
        Console.WriteLine($"{name} learned '{word}'");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger++;
        boredom++;
        
            if (hunger > 10 || boredom > 10)

                {
                    isAlive = false;
                }
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
            Console.WriteLine($"{name} is getting hungry");
        }
        
        if (hunger >= 4 && hunger != 9)
        {
            Console.WriteLine($"{name} is getting bored");
        }

        else
        {
            Console.WriteLine($"{name} is happy and fed");
        }
        Console.WriteLine();
        Console.Write($"Your tamagotchi has {hunger} hunger and {boredom} boredom.  Make sure none get to 10!!");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        boredom -=2;

        if (boredom > 0)
        {
            boredom = 0;
        }
    }

}


