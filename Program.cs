// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("======Simole Dice Game=====\n    insert 'start' or 's' to begin the  game");
string startRoll = Console.ReadLine()!;

const int doublePoint = 2;
const int triplePoint = 6;
 int totalpoint = 0;

while (!((startRoll.Equals("start", StringComparison.OrdinalIgnoreCase)  || startRoll.Equals("s", StringComparison.OrdinalIgnoreCase))))
{   Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("invalid key word inserted type ");
    Console.ResetColor();
    Console.Write("'start or 's' to begin the game properly ")
    startRoll =  Console.ReadLine()!;
}  


// if (!(startRoll.Equals("start", StringComparison.OrdinalIgnoreCase)  || startRoll.Equals("s", StringComparison.OrdinalIgnoreCase)))
// {
//     Console.WriteLine("Write start");
//     return;
// }  

Random rand = new();
int diceOne = rand.Next(1,7);
int diceTwo = rand.Next(1,7);
int diceThree = rand.Next(1,7);
int originalScore = diceOne + diceTwo + diceThree; 
System.Console.WriteLine($"dice one: {diceOne}\ndice two: {diceTwo}\ndice three {diceThree}");
if(diceOne == diceTwo && diceTwo == diceThree)
{
    Console.WriteLine("you have been given a bonus of 6 point");
    totalpoint += originalScore + triplePoint;
    Console.WriteLine($"total point: {totalpoint}");
}

else if (diceOne == diceTwo || diceTwo == diceThree  || diceThree == diceOne)
{
    Console.WriteLine("you have been given a bonus of 2 point");
    totalpoint += originalScore + doublePoint;
    Console.WriteLine($"total point: {totalpoint}" );
}
if (totalpoint >= 10 && totalpoint <=13)
{
    Console.WriteLine("now congrats you have won a baloon");
}

else if (totalpoint >= 14 && totalpoint <= 16)
{
    Console.WriteLine("now congrat you have won an exercise book");
}

else if (totalpoint == 17)
{
    Console.WriteLine("now congrat you have won 5000ms power bannk");
}
else if (totalpoint == 21)
{
    Console.WriteLine("now congrat you have won samsung A21");
}

else if (totalpoint >=18 && totalpoint<= 20)
{
    Console.WriteLine("now congrat you are given a ticket to silverbird");
}

else if (totalpoint >= 22 && totalpoint<= 24)
{
    Console.WriteLine("now congrat you won all the items");
}
else
{
    Console.WriteLine("try again later");
}
// Console.WriteLine("~~~~~~~~~simple dice game~~~~~~~~\n type 'play' to to start game:");
// string startGame = Console.ReadLine()!;

// const int twopoint = 2;
// const int threepoint = 3;
// const int fourpoint = 4;
// int totalpoint = 0;

// if (startGame.Equals("play", StringComparison.OrdinalIgnoreCase))
// {
//     Console.WriteLine("ready to play type");
// }

// Console.WriteLine(" type 'Yes'to play the game ");
//     string play = Console.ReadLine()!;
//   if (play.Equals("yes",StringComparison.OrdinalIgnoreCase))
//  {
//     Console.Write("you are welcome");
 //}
    
