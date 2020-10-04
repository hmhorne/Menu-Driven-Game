using System;
using System.ComponentModel.Design;

namespace fall_2020_starter_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameChoice;
            int games = 0; //Total games played
            int losses = 0; // Total games loss
            int wins = 0; // Total games won
            int EP = 200;
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            Console.WriteLine("            Press ENTER to move throughout console              ");
            Console.WriteLine("");
            Console.WriteLine("****************************************************************");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            Console.WriteLine("             Welcome to Adventures in Babysitting               ");
            Console.WriteLine("");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            Console.WriteLine("As the babysitter, it’s your job to wear the kids energy down through ");
            Console.WriteLine("games of Pick Up Sticks and Mother May I. As you win games, the kids");
            Console.WriteLine("get bored and lose energy. If their energy runs out, they’ll go to bed ");
            Console.WriteLine("early and you’ve won the game! As the kids win, they get excited and");
            Console.WriteLine("gain energy."); 
            Console.WriteLine("");
            Console.WriteLine("Energy Points:");
            Console.WriteLine("");
            Console.WriteLine("There are 200 energy points.");
            Console.WriteLine("You win when EP reaches 0. ");
            Console.WriteLine("You lose when EP reaches 300. ");
            Console.WriteLine("");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            Console.WriteLine("                            Good Luck!                          ");
            Console.WriteLine("");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            Console.WriteLine("Press enter to begin...");
            Console.ReadKey();
            do {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("");
                Console.WriteLine("             Welcome to Adventures in Babysitting               ");
                Console.WriteLine("");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("");
                Console.WriteLine("Select a game:");
                Console.WriteLine("");
                Console.WriteLine("1. Pick Up Sticks");
                Console.WriteLine("2. Mother, May I");
                Console.WriteLine("3. View Scoreboard");
                Console.WriteLine("4. Exit");
                string menuInput = Console.ReadLine();
                if (int.TryParse(menuInput, out gameChoice))
                {
                    switch (gameChoice)
                    {
                        case 1:
                            int stickCount;
                            int userChoice;
                            Console.Clear();
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            Console.WriteLine("                       Pick Up Sticks                           ");
                            Console.WriteLine("");
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            Console.WriteLine("Rules:");
                            Console.WriteLine(" - There are 20 to 100 sticks in the pile. The player that picks up the last one loses.");
                            Console.WriteLine(" - The babysitter decides how many sticks are in the pile. (20-100 sticks)");
                            Console.WriteLine(" - At each turn, players decide how many sticks to pick up.");
                            Console.WriteLine(" - You may pick up no more than 3 sticks at a time.");
                            Console.WriteLine(" - Play continues until loser picks up the last stick.");
                            Console.WriteLine("");
                            Console.WriteLine("Press enter to begin game...");
                            Console.ReadKey();
                        Game:
                            Console.Clear();
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            Console.WriteLine("                       Pick Up Sticks                           ");
                            Console.WriteLine("");
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            Console.WriteLine("How many sticks will be in the pile?");
                            do
                            {
                                int userPoints = 0;
                                int compPoints = 0;
                                string input = Console.ReadLine();
                                if (int.TryParse(input, out stickCount))
                                {
                                    //stickCount = Convert.ToInt32(Console.ReadLine());
                                    if (stickCount < 20 || stickCount > 100)
                                    {
                                        Console.WriteLine("Choose a number from 20 to 100.");
                                    }
                                    else if (stickCount >= 20 || stickCount <= 100)
                                    {
                                        do
                                        {
                                            if (stickCount > 0)
                                            {
                                                if (stickCount == 1)
                                                {
                                                    Console.WriteLine("There is " + stickCount + " stick left in the pile.");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("There are " + stickCount + " sticks in the pile.");
                                                }
                                                Console.WriteLine("How many sticks would you like to pick up? ");
                                                string nextInput = Console.ReadLine();
                                                if (int.TryParse(nextInput, out userChoice))
                                                {
                                                    if (userChoice == 1 || userChoice == 2 || userChoice == 3)
                                                    {
                                                        Console.WriteLine("You picked up " + userChoice);
                                                        userPoints = userChoice + userPoints;
                                                        stickCount = stickCount - userChoice;
                                                        if (stickCount <= 0)
                                                        {
                                                            int number;
                                                            ++ games;
                                                            ++ losses;
                                                            EP = EP + compPoints;
                                                            if (EP >= 300)
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("EP is " + EP + "");
                                                                Console.WriteLine("****************************************************************");
                                                                Console.WriteLine("                           EP reached 300                       ");
                                                                Console.WriteLine("****************************************************************");
                                                                Console.WriteLine("                              You Lose                          ");
                                                                Console.WriteLine("****************************************************************");
                                                                Console.WriteLine("                            Game Summary:                       ");
                                                                Console.WriteLine("");
                                                                Console.WriteLine("You played " + games + "");
                                                                Console.WriteLine("You won " + wins + " games");
                                                                Console.WriteLine("You loss " + losses + " games");
                                                                Console.WriteLine("");
                                                                Console.WriteLine("****************************************************************");
                                                                EP = 0;
                                                                Console.WriteLine("Would you like to play again?");
                                                                Console.WriteLine("Choose an option:");
                                                                Console.WriteLine("1. Replay");
                                                                Console.WriteLine("2. Main menu");
                                                                Console.WriteLine("3. Exit");
                                                                number = int.Parse(Console.ReadLine());
                                                                switch (number)
                                                                {
                                                                    case 1:
                                                                        goto Game;
                                                                    case 2:
                                                                        goto menu;
                                                                    case 3:
                                                                        Environment.Exit(0);
                                                                        break;
                                                                }
                                                            }
                                                            else if (EP <= 0)
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("EP is " + EP + "");
                                                                Console.WriteLine("****************************************************************");
                                                                Console.WriteLine("                            EP reached 0                        ");
                                                                Console.WriteLine("****************************************************************");
                                                                Console.WriteLine("                              You Win                           ");
                                                                Console.WriteLine("****************************************************************");
                                                                Console.WriteLine("                            Game Summary:                       ");
                                                                Console.WriteLine("");
                                                                Console.WriteLine("You played " + games + "");
                                                                Console.WriteLine("You won " + wins + " games");
                                                                Console.WriteLine("You loss " + losses + " games");
                                                                Console.WriteLine("");
                                                                Console.WriteLine("****************************************************************");
                                                                EP = 0;
                                                                Console.WriteLine("Would you like to play again?");
                                                                Console.WriteLine("Choose an option:");
                                                                Console.WriteLine("1. Replay");
                                                                Console.WriteLine("2. Main menu");
                                                                Console.WriteLine("3. Exit");
                                                                number = int.Parse(Console.ReadLine());
                                                                switch (number)
                                                                {
                                                                    case 1:
                                                                        goto Game;
                                                                    case 2:
                                                                        goto menu;
                                                                    case 3:
                                                                        Environment.Exit(0);
                                                                        break;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("****************************************************************");
                                                                Console.WriteLine("                              You Lose                          ");
                                                                Console.WriteLine("****************************************************************");
                                                                Console.WriteLine("EP is " + EP + "");
                                                                Console.WriteLine("Would you like to play again?");
                                                                Console.WriteLine("Choose an option:");
                                                                Console.WriteLine("1. Replay");
                                                                Console.WriteLine("2. Main menu");
                                                                Console.WriteLine("3. Exit");
                                                                number = int.Parse(Console.ReadLine());
                                                                switch (number)
                                                                {
                                                                    case 1:
                                                                        goto Game;
                                                                    case 2:
                                                                        goto menu;
                                                                    case 3:
                                                                        Environment.Exit(0);
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        }
                                                        else if (stickCount > 0)
                                                        {
                                                            if (stickCount == 3 or s)
                                                            {
                                                                Random r = new Random();
                                                                int compStrategy = r.Next(1, 3);
                                                                Console.WriteLine("There are " + stickCount + " left");
                                                                Console.WriteLine("The children picked up " + compStrategy);
                                                                compPoints = compStrategy + compPoints;
                                                                stickCount = stickCount - compStrategy;
                                                                if (stickCount <= 0)
                                                                {
                                                                    int number;
                                                                    ++games;
                                                                    ++wins;
                                                                    EP = EP - userPoints;
                                                                    if (EP >= 300)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("EP is " + EP + "");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                           EP reached 300                       ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                              You Lose                          ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                            Game Summary:                       ");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("You played " + games + "");
                                                                        Console.WriteLine("You won " + wins + " games");
                                                                        Console.WriteLine("You loss " + losses + " games");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("****************************************************************");
                                                                        EP = 0;
                                                                        Console.WriteLine("Would you like to play again?");
                                                                        Console.WriteLine("Choose an option:");
                                                                        Console.WriteLine("1. Replay");
                                                                        Console.WriteLine("2. Main menu");
                                                                        Console.WriteLine("3. Exit");
                                                                        number = int.Parse(Console.ReadLine());
                                                                        switch (number)
                                                                        {
                                                                            case 1:
                                                                                goto Game;
                                                                            case 2:
                                                                                goto menu;
                                                                            case 3:
                                                                                Environment.Exit(0);
                                                                                break;
                                                                        }
                                                                    }
                                                                    else if (EP <= 0)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("EP is " + EP + "");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                            EP reached 0                        ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                              You Win                           ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                            Game Summary:                       ");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("You played " + games + "");
                                                                        Console.WriteLine("You won " + wins + " games");
                                                                        Console.WriteLine("You loss " + losses + " games");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("****************************************************************");
                                                                        EP = 0;
                                                                        Console.WriteLine("Would you like to play again?");
                                                                        Console.WriteLine("Choose an option:");
                                                                        Console.WriteLine("1. Replay");
                                                                        Console.WriteLine("2. Main menu");
                                                                        Console.WriteLine("3. Exit");
                                                                        number = int.Parse(Console.ReadLine());
                                                                        switch (number)
                                                                        {
                                                                            case 1:
                                                                                goto Game;
                                                                            case 2:
                                                                                goto menu;
                                                                            case 3:
                                                                                Environment.Exit(0);
                                                                                break;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                              You Win                           ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("EP is " + EP + "");
                                                                        Console.WriteLine("Would you like to play again?");
                                                                        Console.WriteLine("Choose an option:");
                                                                        Console.WriteLine("1. Replay");
                                                                        Console.WriteLine("2. Main menu");
                                                                        Console.WriteLine("3. Exit");
                                                                        number = int.Parse(Console.ReadLine());
                                                                        switch (number)
                                                                        {
                                                                            case 1:
                                                                                goto Game;
                                                                            case 2:
                                                                                goto menu;
                                                                            case 3:
                                                                                Environment.Exit(0);
                                                                                break;
                                                                        }
                                                                    }
                                                                    break;
                                                                }
                                                            }
                                                            else if (stickCount <= 2)
                                                            {
                                                                int compStrategy = 1;
                                                                Console.WriteLine("There is " + stickCount + " stick left in the pile.");
                                                                Console.WriteLine("The children picked up " + compStrategy);
                                                                compPoints = compStrategy + compPoints;
                                                                stickCount = stickCount - compStrategy;
                                                                if (stickCount <= 0)
                                                                {
                                                                    int number;
                                                                    ++games;
                                                                    ++wins;
                                                                    EP = EP - userPoints;
                                                                    if (EP >= 300)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("EP is " + EP + "");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                           EP reached 300                       ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                              You Lose                          ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                            Game Summary:                       ");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("You played " + games + "");
                                                                        Console.WriteLine("You won " + wins + " games");
                                                                        Console.WriteLine("You loss " + losses + " games");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("****************************************************************");
                                                                        EP = 0;
                                                                        Console.WriteLine("Would you like to play again?");
                                                                        Console.WriteLine("Choose an option:");
                                                                        Console.WriteLine("1. Replay");
                                                                        Console.WriteLine("2. Main menu");
                                                                        Console.WriteLine("3. Exit");
                                                                        number = int.Parse(Console.ReadLine());
                                                                        switch (number)
                                                                        {
                                                                            case 1:
                                                                                goto Game;
                                                                            case 2:
                                                                                goto menu;
                                                                            case 3:
                                                                                Environment.Exit(0);
                                                                                break;
                                                                        }

                                                                    }
                                                                    else if (EP <= 0)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("EP is " + EP + "");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                            EP reached 0                        ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                              You Win                           ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                            Game Summary:                       ");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("You played " + games + "");
                                                                        Console.WriteLine("You won " + wins + " games");
                                                                        Console.WriteLine("You loss " + losses + " games");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("****************************************************************");
                                                                        EP = 0;
                                                                        Console.WriteLine("Would you like to play again?");
                                                                        Console.WriteLine("Choose an option:");
                                                                        Console.WriteLine("1. Replay");
                                                                        Console.WriteLine("2. Main menu");
                                                                        Console.WriteLine("3. Exit");
                                                                        number = int.Parse(Console.ReadLine());
                                                                        switch (number)
                                                                        {
                                                                            case 1:
                                                                                goto Game;
                                                                            case 2:
                                                                                goto menu;
                                                                            case 3:
                                                                                Environment.Exit(0);
                                                                                break;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                              You Win                           ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("EP is " + EP + "");
                                                                        Console.WriteLine("Would you like to play again?");
                                                                        Console.WriteLine("Choose an option:");
                                                                        Console.WriteLine("1. Replay");
                                                                        Console.WriteLine("2. Main menu");
                                                                        Console.WriteLine("3. Exit");
                                                                        number = int.Parse(Console.ReadLine());
                                                                        switch (number)
                                                                        {
                                                                            case 1:
                                                                                goto Game;
                                                                            case 2:
                                                                                goto menu;
                                                                            case 3:
                                                                                Environment.Exit(0);
                                                                                break;
                                                                        }
                                                                    }
                                                                    break;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Random r = new Random();
                                                                int compChoice = r.Next(1, 4);
                                                                Console.WriteLine("There are " + stickCount + " left");
                                                                Console.WriteLine("The children picked up " + compChoice);
                                                                compPoints = compChoice + compPoints;
                                                                stickCount = stickCount - compChoice;
                                                                if (stickCount <= 0)
                                                                {
                                                                    int number;
                                                                    ++games;
                                                                    ++wins;
                                                                    EP = EP - userPoints;
                                                                    if (EP >= 300)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("EP is " + EP + "");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                           EP reached 300                       ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                              You Lose                          ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                            Game Summary:                       ");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("You played " + games + "");
                                                                        Console.WriteLine("You won " + wins + " games");
                                                                        Console.WriteLine("You loss " + losses + " games");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("****************************************************************");
                                                                        EP = 0;
                                                                        Console.WriteLine("Would you like to play again?");
                                                                        Console.WriteLine("Choose an option:");
                                                                        Console.WriteLine("1. Replay");
                                                                        Console.WriteLine("2. Main menu");
                                                                        Console.WriteLine("3. Exit");
                                                                        number = int.Parse(Console.ReadLine());
                                                                        switch (number)
                                                                        {
                                                                            case 1:
                                                                                goto Game;
                                                                            case 2:
                                                                                goto menu;
                                                                            case 3:
                                                                                Environment.Exit(0);
                                                                                break;
                                                                        }
                                                                    }
                                                                    else if (EP <= 0)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("EP is " + EP + "");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                            EP reached 0                        ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                              You Win                           ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                            Game Summary:                       ");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("You played " + games + "");
                                                                        Console.WriteLine("You won " + wins + " games");
                                                                        Console.WriteLine("You loss " + losses + " games");
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("****************************************************************");
                                                                        EP = 0;
                                                                        Console.WriteLine("Would you like to play again?");
                                                                        Console.WriteLine("Choose an option:");
                                                                        Console.WriteLine("1. Replay");
                                                                        Console.WriteLine("2. Main menu");
                                                                        Console.WriteLine("3. Exit");
                                                                        number = int.Parse(Console.ReadLine());
                                                                        switch (number)
                                                                        {
                                                                            case 1:
                                                                                goto Game;
                                                                            case 2:
                                                                                goto menu;
                                                                            case 3:
                                                                                Environment.Exit(0);
                                                                                break;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("                              You Win                           ");
                                                                        Console.WriteLine("****************************************************************");
                                                                        Console.WriteLine("EP is " + EP + "");
                                                                        Console.WriteLine("Would you like to play again?");
                                                                        Console.WriteLine("Choose an option:");
                                                                        Console.WriteLine("1. Replay");
                                                                        Console.WriteLine("2. Main menu");
                                                                        Console.WriteLine("3. Exit");
                                                                        number = int.Parse(Console.ReadLine());
                                                                        switch (number)
                                                                        {
                                                                            case 1:
                                                                                goto Game;
                                                                            case 2:
                                                                                goto menu;
                                                                            case 3:
                                                                                Environment.Exit(0);
                                                                                break;
                                                                        }
                                                                    }
                                                                    break;
                                                                }
                                                            }

                                                        }

                                                    }
                                                    else if (userChoice < 1 || userChoice > 3)
                                                    {
                                                        Console.WriteLine("You may only pick up 1, 2, or 3 sticks.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("You may only pick up 1, 2, or 3 sticks.");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid Input.");
                                                    Console.WriteLine("Choose a number from 1 to 3.");
                                                }
                                            }
                                        }
                                        while (true);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input.");
                                    Console.WriteLine("Choose a number from 20 to 100.");
                                }
                            }
                            while (true);
                        menu:
                            break;
                        case 2:
                            int userSteps;
                            int compSteps = 0;
                            int mother = 21;
                            Console.Clear();
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            Console.WriteLine("                        Mother, May I                           ");
                            Console.WriteLine("");
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            Console.WriteLine("Rules:");
                            Console.WriteLine(" - Mother is 22 steps away. At your turn, you take steps closer to mother. The player that gets closest to mother loses.");
                            Console.WriteLine(" - Your initial steps are automatically determined by rolling two 10-sided dice and adding the numbers.");
                            Console.WriteLine(" - You may choose to roll an additional 6-sided die until satisfied with your step count.");
                            Console.WriteLine(" - Play instantly ends when a player takes more than 21 steps towards Mother.");
                            Console.WriteLine(" - The children win tie games.");
                            Console.WriteLine("");
                            Console.WriteLine("Press enter to begin game...");
                            Console.ReadKey();
                            nextGame:
                            Console.Clear();
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            Console.WriteLine("                        Mother, May I                           ");
                            Console.WriteLine("");
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            do
                            {
                                Random r = new Random();
                                int DiceA = r.Next(1, 11);
                                int DiceB = r.Next(1, 11);
                                userSteps = DiceA + DiceB;
                                Console.WriteLine("You have taken " + userSteps + " steps");
                                BonusDice:
                                if (userSteps >= 22)
                                {
                                    int number;
                                    ++games;
                                    ++losses;
                                    EP = EP + userSteps;
                                    if (EP >= 300)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("EP is " + EP + "");
                                        Console.WriteLine("****************************************************************");
                                        Console.WriteLine("                           EP reached 300                       ");
                                        Console.WriteLine("****************************************************************");
                                        Console.WriteLine("                              You Lose                          ");
                                        Console.WriteLine("****************************************************************");
                                        Console.WriteLine("                            Game Summary:                       ");
                                        Console.WriteLine("");
                                        Console.WriteLine("You played " + games + "");
                                        Console.WriteLine("You won " + wins + " games");
                                        Console.WriteLine("You loss " + losses + " games");
                                        Console.WriteLine("");
                                        Console.WriteLine("****************************************************************");
                                        EP = 0;
                                        Console.WriteLine("Would you like to play again?");
                                        Console.WriteLine("Choose an option:");
                                        Console.WriteLine("1. Replay");
                                        Console.WriteLine("2. Main menu");
                                        Console.WriteLine("3. Exit");
                                        number = int.Parse(Console.ReadLine());
                                        switch (number)
                                        {
                                            case 1:
                                                goto nextGame;
                                            case 2:
                                                goto menu;
                                            case 3:
                                                Environment.Exit(0);
                                                break;
                                        }
                                    }
                                    else if (EP <= 0)
                                    {

                                        Console.Clear();
                                        Console.WriteLine("EP is " + EP + "");
                                        Console.WriteLine("****************************************************************");
                                        Console.WriteLine("                            EP reached 0                        ");
                                        Console.WriteLine("****************************************************************");
                                        Console.WriteLine("                              You Win                           ");
                                        Console.WriteLine("****************************************************************");
                                        Console.WriteLine("                            Game Summary:                       ");
                                        Console.WriteLine("");
                                        Console.WriteLine("You played " + games + "");
                                        Console.WriteLine("You won " + wins + " games");
                                        Console.WriteLine("You loss " + losses + " games");
                                        Console.WriteLine("");
                                        Console.WriteLine("****************************************************************");
                                        EP = 0;
                                        Console.WriteLine("Would you like to play again?");
                                        Console.WriteLine("Choose an option:");
                                        Console.WriteLine("1. Replay");
                                        Console.WriteLine("2. Main menu");
                                        Console.WriteLine("3. Exit");
                                        number = int.Parse(Console.ReadLine());
                                        switch (number)
                                        {
                                            case 1:
                                                goto nextGame;
                                            case 2:
                                                goto menu;
                                            case 3:
                                                Environment.Exit(0);
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("****************************************************************");
                                        Console.WriteLine("                              You Lose                          ");
                                        Console.WriteLine("****************************************************************");
                                        Console.WriteLine("EP is " + EP + "");
                                        Console.WriteLine("Would you like to play again?");
                                        Console.WriteLine("Choose an option:");
                                        Console.WriteLine("1. Replay");
                                        Console.WriteLine("2. Main menu");
                                        Console.WriteLine("3. Exit");
                                        number = int.Parse(Console.ReadLine());
                                        switch (number)
                                        {
                                            case 1:
                                                goto nextGame;
                                            case 2:
                                                goto menu;
                                            case 3:
                                                Environment.Exit(0);
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Would you like to take anymore steps?");
                                    Console.WriteLine("1. Yes");
                                    Console.WriteLine("2. No");
                                }
                                    string input = Console.ReadLine();
                                
                                if (int.TryParse(input, out userChoice))
                                {
                                    if (userChoice == 1)
                                    {
                                        int DiceC = r.Next(1, 7);
                                        userSteps = userSteps + DiceC;
                                        Console.WriteLine("You have taken " + userSteps + " steps");
                                        goto BonusDice;
                                    }
                                    else if (userChoice == 2)
                                    {
                                        if (userSteps > mother)
                                        {
                                            int number;
                                            ++games;
                                            ++losses;
                                            EP = EP + userSteps;
                                            if (EP >= 300)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("EP is " + EP + "");
                                                Console.WriteLine("****************************************************************");
                                                Console.WriteLine("                           EP reached 300                       ");
                                                Console.WriteLine("****************************************************************");
                                                Console.WriteLine("                              You Lose                          ");
                                                Console.WriteLine("****************************************************************");
                                                Console.WriteLine("                            Game Summary:                       ");
                                                Console.WriteLine("");
                                                Console.WriteLine("You played " + games + "");
                                                Console.WriteLine("You won " + wins + " games");
                                                Console.WriteLine("You loss " + losses + " games");
                                                Console.WriteLine("");
                                                Console.WriteLine("****************************************************************");
                                                EP = 0;
                                                Console.WriteLine("Would you like to play again?");
                                                Console.WriteLine("Choose an option:");
                                                Console.WriteLine("1. Replay");
                                                Console.WriteLine("2. Main menu");
                                                Console.WriteLine("3. Exit");
                                                number = int.Parse(Console.ReadLine());
                                                switch (number)
                                                {
                                                    case 1:
                                                        goto nextGame;
                                                    case 2:
                                                        goto menu;
                                                    case 3:
                                                        Environment.Exit(0);
                                                        break;
                                                }
                                            }
                                            else if (EP <= 0)
                                            {

                                                Console.Clear();
                                                Console.WriteLine("EP is " + EP + "");
                                                Console.WriteLine("****************************************************************");
                                                Console.WriteLine("                            EP reached 0                        ");
                                                Console.WriteLine("****************************************************************");
                                                Console.WriteLine("                              You Win                           ");
                                                Console.WriteLine("****************************************************************");
                                                Console.WriteLine("                            Game Summary:                       ");
                                                Console.WriteLine("");
                                                Console.WriteLine("You played " + games + "");
                                                Console.WriteLine("You won " + wins + " games");
                                                Console.WriteLine("You loss " + losses + " games");
                                                Console.WriteLine("");
                                                Console.WriteLine("****************************************************************");
                                                EP = 0;
                                                Console.WriteLine("Would you like to play again?");
                                                Console.WriteLine("Choose an option:");
                                                Console.WriteLine("1. Replay");
                                                Console.WriteLine("2. Main menu");
                                                Console.WriteLine("3. Exit");
                                                number = int.Parse(Console.ReadLine());
                                                switch (number)
                                                {
                                                    case 1:
                                                        goto nextGame;
                                                    case 2:
                                                        goto menu;
                                                    case 3:
                                                        Environment.Exit(0);
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("****************************************************************");
                                                Console.WriteLine("                              You Lose                          ");
                                                Console.WriteLine("****************************************************************");
                                                Console.WriteLine("EP is " + EP + "");
                                                Console.WriteLine("Would you like to play again?");
                                                Console.WriteLine("Choose an option:");
                                                Console.WriteLine("1. Replay");
                                                Console.WriteLine("2. Main menu");
                                                Console.WriteLine("3. Exit");
                                                number = int.Parse(Console.ReadLine());
                                                switch (number)
                                                {
                                                    case 1:
                                                        goto nextGame;
                                                    case 2:
                                                        goto menu;
                                                    case 3:
                                                        Environment.Exit(0);
                                                        break;
                                                }
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            compRoll:
                                            int compDice = r.Next(1, 11);
                                            compSteps = compDice + compSteps;
                                                if (compSteps >= 17)
                                                {
                                                    Console.WriteLine("The chidren have taken " + compSteps + " steps");
                                                    if (compSteps > mother)
                                                    {
                                                        int number;
                                                        ++games;
                                                        ++wins;
                                                        EP = EP - userSteps;
                                                        if (EP >= 300)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                           EP reached 300                       ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Lose                          ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            Game Summary:                       ");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("You played " + games + "");
                                                            Console.WriteLine("You won " + wins + " games");
                                                            Console.WriteLine("You loss " + losses + " games");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("****************************************************************");
                                                            EP = 0;
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }

                                                        else if (EP <= 0)
                                                        {

                                                            Console.Clear();
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            EP reached 0                        ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Win                           ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            Game Summary:                       ");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("You played " + games + "");
                                                            Console.WriteLine("You won " + wins + " games");
                                                            Console.WriteLine("You loss " + losses + " games");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("****************************************************************");
                                                            EP = 0;
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Win                           ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    }
                                                    else if (compSteps > userSteps)
                                                    {
                                                        int number;
                                                        ++games;
                                                        ++wins;
                                                        EP = EP - userSteps;
                                                        if (EP >= 300)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                           EP reached 300                       ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Lose                          ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            Game Summary:                       ");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("You played " + games + "");
                                                            Console.WriteLine("You won " + wins + " games");
                                                            Console.WriteLine("You loss " + losses + " games");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("****************************************************************");
                                                            EP = 0;
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }

                                                        else if (EP <= 0)
                                                        {

                                                            Console.Clear();
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            EP reached 0                        ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Win                           ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            Game Summary:                       ");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("You played " + games + "");
                                                            Console.WriteLine("You won " + wins + " games");
                                                            Console.WriteLine("You loss " + losses + " games");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("****************************************************************");
                                                            EP = 0;
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Win                           ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    }
                                                    else if (compSteps < userSteps)
                                                    {
                                                        int number;
                                                        ++games;
                                                        ++losses;
                                                        EP = EP + compSteps;
                                                        if (EP >= 300)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                           EP reached 300                       ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Lose                          ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            Game Summary:                       ");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("You played " + games + "");
                                                            Console.WriteLine("You won " + wins + " games");
                                                            Console.WriteLine("You loss " + losses + " games");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("****************************************************************");
                                                            EP = 0;
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }
                                                        else if (EP <= 0)
                                                        {

                                                            Console.Clear();
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            EP reached 0                        ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Win                           ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            Game Summary:                       ");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("You played " + games + "");
                                                            Console.WriteLine("You won " + wins + " games");
                                                            Console.WriteLine("You loss " + losses + " games");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("****************************************************************");
                                                            EP = 0;
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Lose                          ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    }
                                                    else if (compSteps == userSteps)
                                                    {
                                                        int number;
                                                        ++games;
                                                        ++losses;
                                                        EP = EP + compSteps;
                                                        if (EP >= 300)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                           EP reached 300                       ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Lose                          ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            Game Summary:                       ");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("You played " + games + "");
                                                            Console.WriteLine("You won " + wins + " games");
                                                            Console.WriteLine("You loss " + losses + " games");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("****************************************************************");
                                                            EP = 0;
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }

                                                        else if (EP <= 0)
                                                        {

                                                            Console.Clear();
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            EP reached 0                        ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Win                           ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                            Game Summary:                       ");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("You played " + games + "");
                                                            Console.WriteLine("You won " + wins + " games");
                                                            Console.WriteLine("You loss " + losses + " games");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("****************************************************************");
                                                            EP = 0;
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("                              You Lose                          ");
                                                            Console.WriteLine("****************************************************************");
                                                            Console.WriteLine("EP is " + EP + "");
                                                            Console.WriteLine("Would you like to play again?");
                                                            Console.WriteLine("Choose an option:");
                                                            Console.WriteLine("1. Replay");
                                                            Console.WriteLine("2. Main menu");
                                                            Console.WriteLine("3. Exit");
                                                            number = int.Parse(Console.ReadLine());
                                                            switch (number)
                                                            {
                                                                case 1:
                                                                    goto nextGame;
                                                                case 2:
                                                                    goto menu;
                                                                case 3:
                                                                    Environment.Exit(0);
                                                                    break;
                                                            }
                                                        }
                                                        break;

                                                    }
                                                 }
                                            else
                                            {
                                                goto compRoll;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Input");
                                        goto BonusDice;
                                    }
                                }
                            }
                            while (true);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            Console.WriteLine("                         Scoreboard                             ");
                            Console.WriteLine("");
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("");
                            Console.WriteLine("Wins:");
                            Console.WriteLine("" + wins + "");
                            Console.WriteLine("");
                            Console.WriteLine("Losses:");
                            Console.WriteLine("" + losses + "");
                            Console.WriteLine("");
                            Console.WriteLine(" Total Games Played:");
                            Console.WriteLine("" + games + "");
                            Console.WriteLine("");
                            Console.WriteLine("Press ENTER to return to main menu");
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            while (true) ;
        }
    }
}
