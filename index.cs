int theNumber=new Random().Next(20);
bool keepGoing=true;
Console.WriteLine("Let's play'Guess the number!'");
Console.WriteLine("I am thinking of a number between 0 and 20.");
Console.WriteLine("Enter your guess,or -1 to give up.");
//Keep track of number of guesses and current guess
int guessNum=0;
int guessCount=0;

//Prompt user to enter a guess
do
 {
Console.WriteLine("What's your guess?");
//Guess will be stored in the string
string theGuess=Console.ReadLine();

//tryParse method to convert input to number
bool result=Int32.TryParse(theGuess,out guessNum);
//Incase you input  what is not a number
if(!result)
{
   Console.WriteLine("That does not look like a number.Try again");
}
   else
{
if(guessNum==-1)
  {
    Console.WriteLine("I was thinking of ${theNumber}");
    keepGoing=false;
  }
  else
    {
     guessCount++;
    }
    if (guessNum==theNumber)
    {
        Console.WriteLine($"You got it in {guessCount} guesses!!");
        keepGoing=false;
    }
//Give prediction based on yuor guess
else
{
    Console.WriteLine("Nope,{0} than that",guessNum<theNumber?"higher":"lower");
}
}
 }
while(keepGoing);
