// Mab Lib


bool playAgain = true;
string breakLine = "_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-";

string? age, famRelat, job, ageTwo, objects, size, manSettlement, toyBrand, profession, spaceBody;
Console.Clear();

while (playAgain)
{
    Console.WriteLine("We are going to play a quick little Mab Lib game today,");
    Console.WriteLine("Please enter your response to the prompts when they pop up.");

    static bool trueWord(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }
        foreach (char b in input)
        {
            if (!char.IsLetter(b) && b != ' ')
            {
                return false;
            }
        }
        return true;
    }

    // age loop
    while (true)
    {
        Console.WriteLine("Enter a stage of life. Example: old, young, etc. ");
        age = Console.ReadLine();

        if (trueWord(age))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // family relation loop
    while (true)
    {
        Console.WriteLine("Please enter a family relation.");
        famRelat = Console.ReadLine();

        if (trueWord(famRelat))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // job loop
    while (true)
    {
        Console.WriteLine("Please enter a job.");
        job = Console.ReadLine();

        if (trueWord(job))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // second age loop
    while (true)
    {
        Console.WriteLine("Enter another stage of life.");
        ageTwo = Console.ReadLine();

        if (trueWord(ageTwo))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // object loop
    while (true)
    {
        Console.WriteLine("Please enter an object.");
        objects = Console.ReadLine();

        if (trueWord(objects))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // size loop
    while (true)
    {
        Console.WriteLine("Please enter a size.");
        size = Console.ReadLine();

        if (trueWord(size))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // human settlement loop
    while (true)
    {
        Console.WriteLine("Please enter a type of human settlement.");
        manSettlement = Console.ReadLine();

        if (trueWord(manSettlement))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // toy brand loop
    while (true)
    {
        Console.WriteLine("Please enter a toy brand.");
        toyBrand = Console.ReadLine();

        if (trueWord(toyBrand))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // profesion loop
    while (true)
    {
        Console.WriteLine("Please enter another job type.");
        profession = Console.ReadLine();

        if (trueWord(profession))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // space body loop
    while (true)
    {
        Console.WriteLine("Please enter a type of celestial body.");
        spaceBody = Console.ReadLine();

        if (trueWord(spaceBody))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }

    // Story Block
    Console.Clear();
    Console.WriteLine(breakLine);
    Console.WriteLine($"There once was a {age} man who didnt know his {famRelat}.");
    Console.WriteLine($"He was told his whole life what a great {job} his {famRelat} was.");
    Console.WriteLine($"One day he met a couple of {objects}'s that were looking for a {ageTwo} man.");
    Console.WriteLine($"The {age} man knew of this {ageTwo} man and where to find him.");
    Console.WriteLine($"After meeting up with the {ageTwo} man they all headed to the {size} {manSettlement} near by to find a spaceship to hire.");
    Console.WriteLine($"Upon entering the {manSettlement} they began looking for {job} to hire.");
    Console.WriteLine($"The {job} was a scruffy {toyBrand} {profession}, but agreed to fly them where they needed to go.");
    Console.WriteLine($"Thus begins the tale of {spaceBody} Wars.");
    Console.WriteLine(breakLine);

    // Play again block
    Console.WriteLine("Would you like to play again yes/no.");

    bool yesNo = true;

    while (yesNo == true)
    {
        string? userInput = Console.ReadLine();
        if (userInput?.ToLower() == "yes")
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("Here we go again!!!");
            yesNo = false;
        }
        else if (userInput?.ToLower() == "no")
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("See you next time.");
            yesNo = false;
            playAgain = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("That was not a yes or no, try that again.");
            Console.WriteLine(breakLine);
        }
    }


}