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
string choiceOne = string.Empty;
string choiceTwo = string.Empty;
int point1 = 0;
int point2 = 0;


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
        choiceOne = Console.ReadLine();
        Console.Clear();


        if (choiceOne != "1" && choiceOne != "2" && choiceOne != "3")
        {
            Console.WriteLine("You did'nt pick right number");
            continue;

        }

        while (choiceOne == "1" || choiceOne == "2" || choiceOne == "3")
        {

            Console.WriteLine("It's your turn " + playerTwo + " (With numbers)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. " + input.Rock);
            Console.WriteLine("2. " + input.Paper);
            Console.WriteLine("3. " + input.Scissors);
            choiceTwo = Console.ReadLine();
            Console.Clear();

            if (choiceTwo != "1" && choiceTwo != "2" && choiceTwo != "3")
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

        if (choiceOne == choiceTwo)
        {
            Console.WriteLine("Draw, no one was given any points");
            Console.WriteLine("Try agian!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(playerOne + "Have: " + point1 + " point");
            Console.WriteLine(playerTwo + "Have: " + point2 + " point");


        }
        //// This gives player 1, 1 point
        else if
            (choiceOne == "1" && choiceTwo == "3" ||
            choiceOne == "2" && choiceTwo == "1" ||
            choiceOne == "3" && choiceTwo == "2")
        {
            point1++;
            Console.WriteLine(playerOne + " wins and get one point! And have: " + point1 + " point");
            Console.WriteLine(playerTwo + " loss and get zero point! And have: " + point2 + " point");
            Console.WriteLine();
            Console.WriteLine();
        }

        else // This gives player 2, 1 point
        {
            point2++;
            Console.WriteLine(playerOne + " loss and get one point! And have: " + point1 + " point");
            Console.WriteLine(playerTwo + " wins and get zero point! And have: " + point2 + " point");
            Console.WriteLine();
            Console.WriteLine();


        }



        // Reach the goal
        if (point1 == 2 || point2 == 2)
        {
            break;
        }

        choiceOne = string.Empty;
        choiceTwo = string.Empty;
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
        choiceOne = Console.ReadLine();


        if (choiceOne != "1" && choiceOne != "2" && choiceOne != "3")
        {
            Console.WriteLine("You did'nt pick right number");
            continue;
           
        }

        while (choiceOne == "1" || choiceOne == "2" || choiceOne == "3")
        {


            //BOT Choice

            Random rndChoice = new Random();
            int botChoice = rndChoice.Next(1, 4);
            choiceTwo = botChoice.ToString();
            Console.WriteLine(choiceTwo);
            Console.ReadKey();
            break;

        }

        if (choiceOne == choiceTwo)
        {
            Console.WriteLine("Draw, no one was given any points");
            Console.WriteLine("Try agian!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(firstName.name + " Have: " + point1 + " point");
            Console.WriteLine(playerTwo + " Have: " + point2 + " point");


        }
        //// This gives player 1, 1 point
        else if
            (choiceOne == "1" && choiceTwo == "3" ||
            choiceOne == "2" && choiceTwo == "1" ||
            choiceOne == "3" && choiceTwo == "2")
        {
            point1++;
            Console.WriteLine(firstName.name + " wins and get one point! And have: " + point1 + " point");
            Console.WriteLine(playerTwo + " loss and get no point! And have: " + point2 + " point");
            Console.WriteLine();
            Console.WriteLine();
        }

        else // This gives player 2, 1 point
        {
            point2++;
            Console.WriteLine(firstName.name + " loss and get one point! And have: " + point1 + " point");
            Console.WriteLine(playerTwo + " wins and get no point! And have: " + point2 + " point");
            Console.WriteLine();
            Console.WriteLine();


        }




        // Reach the goal
        if (point1 == 2 || point2 == 2)
        {
            break;
        }

        choiceOne = string.Empty;
        choiceTwo = string.Empty;


       



    }
    break;
}



if (point1 == 2)
{
    Console.Clear();
    Console.WriteLine(firstName.name + " wins the game!");
    Console.ReadKey();

}
if (point2 == 2)
{
    Console.Clear();
    Console.WriteLine(playerTwo + " wins the game!");
    Console.ReadKey();

}





//Random randomPlayer = Random.Next(playerTwo, playerOne);


//Random round = new Random();
//int start = 0;

//start = round.Next(0, 2);



//if (start == 0)
//{
//Console.WriteLine(playerOne.name1 + " starts!");

//}
//else if (start == 1)
//{
//Console.WriteLine(playerTwo.name2 + " starts!");
//}










//  Rock, paper , scissors
//  2 spelar som skriver in sina namn
//  Slumpa start spelare
//  Bäst av tre
// Extra, välj BOT eller spelare.

//tips!
//använda enums för olika inputs: sten sax påse, win lose draw
//tips class för player
//Lägg upp på GIT! Kommentera koden.