using System;
using System.Net;
using System.Collections.Generic;
using System.Globalization;

public static class Jokempo
{
	public static void Main()
	{
		List<string> plays = new List<string> {"Rock", "Paper", "Scissors"};
		Random rnd = new Random();
		int rndPick = rnd.Next(plays.Count);
		
		Console.WriteLine("Let's play Rock, Paper, Scissors");
		Console.WriteLine("\n -Rock \n -Paper \n -Scissors");
		
		Console.Write("\n You play: ");
		
		string rootPlayerPlay = Console.ReadLine();
		string computerPlay = plays[rndPick];
		
		var playerUpper = char.ToUpper(rootPlayerPlay[0]); //char captures an unicode character
		
	    string playerPlay = 	playerUpper + rootPlayerPlay.Substring(1); //Substring captures an informed index forward
		
		while (!(plays.Contains(playerPlay)))
		{
			Console.Write("\n Type a valid action: ");
			rootPlayerPlay = Console.ReadLine();
			playerUpper = char.ToUpper(rootPlayerPlay[0]);
			playerPlay = 	playerUpper + rootPlayerPlay.Substring(1);
		}
		
		Console.WriteLine($"\n Computer plays: {computerPlay}");
		Console.Write($"\n {playerPlay} X {computerPlay} is... ");
		
		if (playerPlay == computerPlay)
		{
			Console.WriteLine("Tie!");
		}
		else if (playerPlay == "Rock" && computerPlay == "Scissors")
		{
			Console.WriteLine("Your victory!");
		}
		else if (playerPlay == "Paper" && computerPlay == "Rock")
		{
			Console.WriteLine("Your victory!");
		}
		else if (playerPlay == "Scissors" && computerPlay == "Paper")
		{
			Console.WriteLine("Your victory!");
		}
		else
		{
			Console.WriteLine("Your defeat!");
		}
	}
}
