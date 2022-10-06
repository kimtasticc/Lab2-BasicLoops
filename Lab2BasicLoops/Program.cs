bool userContinue;

do
{
    Console.WriteLine("Hello World!");


    Console.WriteLine();


    Console.WriteLine("Please give me a number: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You chose {userNumber}! Let's do some counting exercises.");

    for (int i = userNumber; i >= 0; i--)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine();

    for (int i = 0; i <= userNumber; i++)
    {
        Console.WriteLine(i);
    }


    Console.WriteLine();


    Console.WriteLine("Would you like to continue on? (y/n)?");
    string answer = Console.ReadLine();

    if (answer.ToLower() == "n")
    {
        userContinue = false;
        Console.WriteLine("Okay cya!");
    }
    else
    {
        userContinue = true;
    }
} while (userContinue == true);


Console.WriteLine();


int securityCode = 13579;
int guessAttempt = 5;
bool doorUnlocked = false;

Console.WriteLine("Please enter the correct keycode to unlock this door.");
int userInput = Convert.ToInt32(Console.ReadLine());

while (doorUnlocked == false)
{
    guessAttempt--;

    if (userInput == securityCode)
    {
        Console.WriteLine("The door has been unlocked. Come on in!");
        doorUnlocked = true;
    }
        
    else if (guessAttempt > 0)
    {
        Console.WriteLine("Sorry. Please enter the correct keycode to unlock this door.");
        Console.WriteLine($"You have {guessAttempt} more tries.");
        userInput = Convert.ToInt32(Console.ReadLine());
    }

    else
    {
        Console.WriteLine("You have too many incorrect attempts. You might want to call someone to let you in.");
        break;
    }
}

Console.ReadKey();