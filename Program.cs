using rockpaperscissors;
Player playerOne = new Player();
Player playerTwo = new Player();



Console.Write("Player one enter your name: ");
playerOne.name1 = Console.ReadLine();

Console.Write("Player two enter your name: ");
playerTwo.name2 = Console.ReadLine();


Random round = new Random();
int start = 0;

start = round.Next(0, 2);

if (start == 0)
{
Console.WriteLine(playerOne.name1);
}
else if (start == 1)
{
Console.WriteLine(playerTwo.name2);
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