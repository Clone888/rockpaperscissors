using rockpaperscissors;
using System.ComponentModel.Design;
using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Channels;


// Sets background to color black
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();

// Sets textcolor to green
Console.ForegroundColor = ConsoleColor.Green;


string Option = string.Empty;
bool game = true;


while (true)
{
    Console.WriteLine("Choose 2 player game or play against a BOT.");
    Console.WriteLine("\t\t1. Two Players");
    Console.WriteLine("\t\t2. One Player");
    string firstChoice = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.Clear();


    if (firstChoice == "1")
    {
        Option = "pvp";
        break;

    }
    else if (firstChoice == "2")
    {
        Option = "bot";
        break;
    }
    else
    {
        Console.WriteLine("This is not a vaild option");
        continue;

    }
}

Player firstName = new Player();
Player secondName = new Player();
string playerOne = string.Empty;
string playerTwo = string.Empty;


while (Option == "pvp") // Player VS Player

{
    // Player one enter name
    Console.Write("Player one enter your name: ");
    firstName.name = Console.ReadLine();


    // Player two enter name

    Console.Write("Player two enter your name: ");
    secondName.name = Console.ReadLine();
    Console.WriteLine();
    Console.Clear();


    //Radomize start order

    string[] randomPlayer = { firstName.name, secondName.name };
    Random rnd = new Random();
    int index = rnd.Next(0, randomPlayer.Length);

    //Announce who will start
    Console.WriteLine(randomPlayer[index] + " - YOU START!");

    playerOne = randomPlayer[index];

    // Player 2
    playerTwo = string.Empty;

    if (firstName.name == playerOne)
    {
        playerTwo = secondName.name;
    }
    else
    {
        playerTwo = firstName.name;
    }


    Console.WriteLine("Player 1, " + playerOne + " Starts the game");
    Console.WriteLine("Player 2, " + playerTwo + " Goes second");


    while (true)
    {

        Console.WriteLine();
        Console.WriteLine();
        Console.Write(playerOne + " make a choice! (With numbers)");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1. " + input.Rock);
        Console.WriteLine("2. " + input.Paper);
        Console.WriteLine("3. " + input.Scissors);
        firstName.choice = Console.ReadLine();
        Console.Clear();


        if (firstName.choice != "1" && firstName.choice != "2" && firstName.choice != "3")
        {
            Console.WriteLine("You did'nt pick right number");
            continue;

        }

        while (firstName.choice == "1" || firstName.choice == "2" || firstName.choice == "3")
        {

            Console.WriteLine("It's your turn " + playerTwo + " (With numbers)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. " + input.Rock);
            Console.WriteLine("2. " + input.Paper);
            Console.WriteLine("3. " + input.Scissors);
            secondName.choice = Console.ReadLine();
            Console.Clear();

            if (secondName.choice != "1" && secondName.choice != "2" && secondName.choice != "3")
            {
                Console.Clear();
                Console.WriteLine("You did'nt pick right");
                Console.WriteLine();
                Console.WriteLine();
                continue;

            }
            else
            {
                break;
            }


        }

        if (firstName.choice == secondName.choice)
        {
            Console.WriteLine("Draw, no one was given any points");
            Console.WriteLine("Try agian!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(playerOne + " Have: " + firstName.point + " point");
            Console.WriteLine(playerTwo + " Have: " + secondName.point + " point");


        }
        //// This gives player 1, 1 point
        else if
            (firstName.choice == "1" && secondName.choice == "3" ||
            firstName.choice == "2" && secondName.choice == "1" ||
            firstName.choice == "3" && secondName.choice == "2")
        {
            firstName.point++;
            Console.WriteLine(playerOne + " wins and get one point! And have: " + firstName.point + " point");
            Console.WriteLine(playerTwo + " loss and get zero point! And have: " + secondName.point + " point");
            Console.WriteLine();
            Console.WriteLine();
        }

        else // This gives player 2, 1 point
        {
            secondName.point++;
            Console.WriteLine(playerOne + " loss and get one point! And have: " + firstName.point + " point");
            Console.WriteLine(playerTwo + " wins and get zero point! And have: " + secondName.point + " point");
            Console.WriteLine();
            Console.WriteLine();


        }



        // Reach the goal
        if (firstName.point == 2 || secondName.point == 2)
        {
            break;
        }

        firstName.choice = string.Empty;
        secondName.choice = string.Empty;
    }

    break;
}





while (Option == "bot") // Player VS Computer
{

    //BOT name
    playerTwo = "Boten Anna";


    Console.Write("Enter your name: ");
    firstName.name = Console.ReadLine();

    while (true)
    {

        Console.WriteLine();
        Console.WriteLine();
        Console.Write(firstName.name + " make a choice! (With numbers)");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1. " + input.Rock);
        Console.WriteLine("2. " + input.Paper);
        Console.WriteLine("3. " + input.Scissors);
        firstName.choice = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Your choice: " + firstName.choice);


        if (firstName.choice != "1" && firstName.choice != "2" && firstName.choice != "3")
        {
            Console.WriteLine("You did'nt pick right number");
            continue;

        }

        while (firstName.choice == "1" || firstName.choice == "2" || firstName.choice == "3")
        {


            //BOT Choice

            Random rndChoice = new Random();
            int botChoice = rndChoice.Next(1, 4);
            secondName.choice = botChoice.ToString();
            Console.WriteLine("Boten Anna choose: " + secondName.choice);
            Console.ReadKey();
            break;

        }

        if (firstName.choice == secondName.choice)
        {
            Console.WriteLine("Draw, no one was given any points");
            Console.WriteLine("Try agian!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(firstName.name + " Have: " + firstName.point + " point");
            Console.WriteLine(playerTwo + " Have: " + secondName.point + " point");


        }
        //// This gives player 1, 1 point
        else if
            (firstName.choice == "1" && secondName.choice == "3" ||
            firstName.choice == "2" && secondName.choice == "1" ||
            firstName.choice == "3" && secondName.choice == "2")
        {
            firstName.point++;
            Console.WriteLine(firstName.name + " wins and get one point! And have: " + firstName.point + " point");
            Console.WriteLine(playerTwo + " loss and get no point! And have: " + secondName.point + " point");
            Console.WriteLine();
            Console.WriteLine();
        }

        else // This gives player 2, 1 point
        {
            secondName.point++;
            Console.WriteLine(firstName.name + " loss and get one point! And have: " + firstName.point + " point");
            Console.WriteLine(playerTwo + " wins and get no point! And have: " + secondName.point + " point");
            Console.WriteLine();
            Console.WriteLine();


        }




        // Reach the goal
        if (firstName.point == 2 || secondName.point == 2)
        {
            break;
        }

        firstName.choice = string.Empty;
        secondName.choice = string.Empty;

    }
    break;
}



if (firstName.point == 2)
{
    Console.Clear();
    Console.WriteLine(firstName.name + " wins the game!");
    Console.ReadKey();

}
if (secondName.point == 2)
{
    Console.Clear();
    Console.WriteLine(playerTwo + " wins the game!");
    Console.ReadKey();

}




//  Rock, paper , scissors
//  2 spelar som skriver in sina namn
//  Slumpa start spelare
//  Bäst av tre
// Extra, välj BOT eller spelare.

//tips!
//använda enums för olika inputs: sten sax påse, win lose draw
//tips class för player
//Lägg upp på GIT! Kommentera koden.