using System;

public enum MessageType
{
	QUERY,
	COMBAT_INFO,
	WARNINGS,
	HIT_RECEIVED,
	HIT_DEALT,
	HIT_BLOCKED,
	DEAD,
	WINNING_FIGHT
}

public class UserInterface
{
	public void DisplayMessage(string message, MessageType messageType)
	{
		switch (messageType)
		{
			case MessageType.QUERY:
				Console.ForegroundColor = ConsoleColor.Cyan;
				break;
			case MessageType.COMBAT_INFO:
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.BackgroundColor = ConsoleColor.Gray;
				break;
			case MessageType.WARNINGS:
				Console.ForegroundColor = ConsoleColor.Yellow;
				break;
			case MessageType.HIT_RECEIVED:
				Console.ForegroundColor = ConsoleColor.Red;
				break;
			case MessageType.HIT_DEALT:
				Console.ForegroundColor = ConsoleColor.Green;
				break;
			case MessageType.HIT_BLOCKED:
				Console.ForegroundColor = ConsoleColor.Magenta;
				break;
			case MessageType.DEAD:
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.Red;
				break;
			case MessageType.WINNING_FIGHT:
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.Green;
				break;
			default:
				break;
		}

		Console.WriteLine(message);

		Console.ResetColor();
	}

	public static void DisplayInfo(params string[] info)
	{
		foreach (var item in info)
		{
			Console.WriteLine(item);
		}
	}
}