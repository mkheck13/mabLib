// Mab Lib


bool playAgain = true;
string breakLine = "_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-";

string? age, famRelat, job, famMember, objects, size, manSettlement, toyBrand, profession, spaceBody;
Console.Clear();

while(playAgain){
    Console.WriteLine("We are going to play a quick little Mab Lib game today,");
    Console.WriteLine("Please enter your response to the prompts when they pop up.");

// word check function
    Console.WriteLine("Enter a stage of life: ");
    static bool trueWord(string? input){
        if(string.IsNullOrEmpty(input)){
            return false;
        }
        foreach(char b in input){
            if(!char.IsLetter(b) && b != ' '){
                return false;
            }
        }
        return true;
    }
// age loop
    while(true){
        Console.WriteLine("age");
        age = Console.ReadLine();

        if(trueWord(age)){
            Console.WriteLine(age);
            break;
        }else{
            Console.WriteLine("try again");
        }
    }
// family relation loop
    while(true){
        Console.WriteLine("relation");
        famRelat = Console.ReadLine();

        if(trueWord(famRelat)){
            Console.WriteLine(famRelat);
            break;
        }else{
            Console.WriteLine("try again");
        }
    }
    Console.WriteLine(age + " " + famRelat);















    Console.WriteLine();
// Play again block
    Console.WriteLine(breakLine);
    Console.WriteLine("Would you like to play again yes/no.");

    bool yesNo = true;

    while(yesNo == true){
        string? userInput = Console.ReadLine();
        if(userInput?.ToLower() == "yes"){
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("Here we go again!!!");
            yesNo = false;
        }else if(userInput?.ToLower() == "no"){
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("See you next time.");
            yesNo = false;
            playAgain = false;
        }else{
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("That was not a yes or no, try that again.");
            Console.WriteLine(breakLine);
        }
    }


}