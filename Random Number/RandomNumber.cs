using System;
using System.Linq;
using System.Collections.Generic;

namespace RandomNumber;

public static class RandomNumber
{         
    public static void Main()
    {
		//Preparing numbers and choosing a random one (computer)
		Random rnd = new Random();
		int rndNumber = rnd.Next(1, 11);
		
		//Game Area (start)
		
		Console.WriteLine("Let's play: Guess the number! You got 3 chances to try guess the number (between 1 and 10) what computer thought!");
		
		int chances = 3;
		
		while (true)
		{
			if (chances == 0)
			{
				Console.WriteLine($"\n You lose. Your attempts is over!\n The number was {rndNumber}");
				break;
			}
			
			Console.Write("\n Your guess: ");
			int guess = int.Parse(Console.ReadLine());
			chances-- ;
			
			if (guess == rndNumber)
			{
				Console.Write("\n Correct! ");
				break;
			}
			
			while (chances != 0)
			{
				if (guess > rndNumber)
			{
				Console.WriteLine("Try lower");
				break;
			}
		    	else if (guess < rndNumber)
			{
				Console.WriteLine("Try higher");
				break;
			}
			
			}
			
			Console.WriteLine($"\n Left attempts: {chances}");
		}
    }
}
