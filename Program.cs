// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("======Simole Dice Game=====\n    insert 'start' or 's' to begin the  game");
string startRoll = Console.ReadLine()!;

const int doublePoint = 2;
const int triplePoint = 6;
 int totalpoint = 0;

if (!(startRoll.Equals("start", StringComparison.OrdinalIgnoreCase)  || startRoll.Equals("s", StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine("Write start");
    return;
}  

Random rand = new();
int diceOne = rand.Next(1,7);
int diceTwo = rand.Next(1,7);
int diceThree = rand.Next(1,7);

System.Console.WriteLine($"dice one {diceOne} dise two {diceTwo} dice three {diceThree}");
if(diceOne == diceTwo && diceTwo == diceThree)
{
    Console.Write("you have been given a bonus of 6 point");
    totalpoint+=triplePoint;
}

else if (diceOne == diceTwo || diceTwo == diceThree  || diceThree == diceOne)
{
    Console.Write("you have been given a bonus of 2 point");
    totalpoint+=doublePoint;
}
if (totalpoint >= 10 && totalpoint <=13)
{
    Console.WriteLine("congrats you have won a baloon");
}

if (totalpoint >= 14 && totalpoint <= 16)
{
    Console.WriteLine("exercise book");
}

if (totalpoint == 17)
{
    Console.WriteLine("congrat you have won 5000ms power bannk");
}
if (totalpoint == 21)
{
    Console.WriteLine("congrat you have won samsung A21");
}

if (totalpoint >=18 && totalpoint<= 20)
{
    Console.WriteLine("congrat you are given a ticket to silverbird");
}

if (totalpoint >= 22 && totalpoint<= 24)
{
    Console.WriteLine("congrat you won all the items");
}
else
{
    Console.Write("try again later");
}