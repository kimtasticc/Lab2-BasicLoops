int securityCode = 13579;
int guessAttempt = 5;

bool doorUnlocked = false;

Console.WriteLine("Please enter the correct keycode to unlock this door.");
int userInput = Convert.ToInt32(Console.ReadLine());

do
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
} while (doorUnlocked == false);

Console.ReadKey();

// My attempt at the Optional Stretch is below. It seems to run as intended so please let me know if the coding is what you would expect?
// I'm having a pretty tough time understanding methods. Thanks!

DoorKeyCode(securityCode, guessAttempt);

bool DoorKeyCode(int securityCode, int guessAttempt)
{
    Console.WriteLine("Please enter the correct keycode to unlock this door.");
    int userInput = Convert.ToInt32(Console.ReadLine());

    while (userInput != securityCode)
    {
        guessAttempt--;

        if (guessAttempt > 0)
        {
            Console.WriteLine("Sorry. Please enter the correct keycode to unlock this door.");
            Console.WriteLine($"You have {guessAttempt} more tries.");
            userInput = Convert.ToInt32(Console.ReadLine());
        }

        else
        {
            Console.WriteLine("You have too many incorrect attempts. You might want to call someone to let you in.");
            return false;
        }
    }

    Console.WriteLine("The door has been unlocked. Come on in!");
    return true;
}

Console.ReadKey();