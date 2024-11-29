using System;
using System.Diagnostics;

namespace reactgame;

public class Game
{
	
	private readonly Random _rnd = new Random();

	public void Start() 
	{
		// skapa en start metod som startar spelet. 
		// Ge spelaren info om hur spelet går till
		// Säg REDO, vänta random millisekunder
		// Säg NU
		// räkna hur lång tid det tog för spelaren att trycka på en knapp
		// Säg tiden det tog
		
		System.Console.WriteLine("Gör dig redo, klicka på en tangent när jag säger NU!");
		int delay = _rnd.Next(3000, 5001);
		Thread.Sleep(delay);
		
		// KOLLA OM ANVÄNDAREN HAR FUSKAT?
		
		char fusk = Console.KeyAvailable ? Console.ReadKey(true).KeyChar : '\0';
		
		// TERNARY aka One Line If
		
		// typ syntax CheckFusk(fusk) ? "Du fuskade" : "Du fuskade inte" ;
			
		System.Console.WriteLine("NU!");
		
		if (CheckFusk(fusk)) 
		{
			System.Console.WriteLine("Du fuskade!");
		}
		
		var stopwatch = Stopwatch.StartNew();
		
		char key = Console.ReadKey(true).KeyChar;
		
		stopwatch.Stop();
		
		System.Console.WriteLine("Du reagerade på: " + stopwatch.ElapsedMilliseconds + " millisekunder!");
	}

	public bool CheckFusk(char input) 
	{
		// KOLLA OM DET FINNS INPUT
		// OM SANT SÄG FUSK
		// OM INTE SANT LÅT GÅ
		
		// LOGGA RESULTATET
		
		if (input != '\0') 
		{
			return true;
		} else 
		{
			return false;
		}
	}
	
	public string FormatMilliseconds(long millseconds) 
	{
		// TA EMOT MILLISEKUNDER
		// RETURNERA sträng typ 1 minut, 10 sekunder och 5 hundradelar 
		
		// ANVÄND MODULUS % OPERATORN
		throw new NotImplementedException();
	}
}
