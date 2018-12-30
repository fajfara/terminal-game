using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour
{
	// Game state
	string _userInput;
	int level;
	enum Screen { MainMenu, WaitingForPassword, Win };

	private Screen currentScreen = Screen.MainMenu;
	
	
	// Use this for initialization
	void Start () 
	{
		showMainMenu();
	}
	

	void OnUserInput(string input)
	{
		_userInput = input;
		if (input == "menu")
		{
			currentScreen = Screen.MainMenu;
			showMainMenu();
		}
		else if (currentScreen == Screen.MainMenu)
		{
			RunMainMenu(input);
		}
		
	}

	void RunMainMenu(string input)
	{
		if (input == "1")
		{
			level = 1;
			StartGame(level);
		}
		else if (input == "2")
		{
			level = 2;
			StartGame(level);
		}
		else if (input == "3")
		{
			level = 2;
			StartGame(level);
		}
		else if (input == "007")
		{
			Terminal.WriteLine("Please select a level Mr. Bond!");
		}
		else
		{
			Terminal.WriteLine("Enter a valid number to select a level!");
		}
	}

	void showMainMenu() 
	{
		Terminal.ClearScreen();
		Terminal.WriteLine("LTC limited parts welcomes you,");
		Terminal.WriteLine("Choose what to hack: ");
		Terminal.WriteLine("Police station - level 1 - press one");
		Terminal.WriteLine("National Bank - level 2 - press two");
		Terminal.WriteLine("NSA - level 3 - press three");
		Terminal.WriteLine("Enter your selection: ");
	}

	void StartGame(int level)
	{
		currentScreen = Screen.WaitingForPassword;
		string choosenMap = "";
		switch (level)
		{
			case 1:
				choosenMap = "Police Station";
				break;
			case 2:
				choosenMap = "National Bank";
				break;
			case 3:
				choosenMap = "NSA";
				break;
		}
		Terminal.WriteLine("You have chosen " + choosenMap );
		Terminal.WriteLine("Please enter your password: ");
	}
}
