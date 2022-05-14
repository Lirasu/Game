using System;
using System.Threading.Tasks;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            int level = 0;
            int experience = 0;
            int levelUpRequirement = 2;
            int experienceEarned = 0;

            Console.WriteLine("Bienvenue dans le simulateur\n" +
                "Veuillez indiquer votre nom :");
            string name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Bonjour, " + name + " vous êtes actuellement niveau " + level + "\n" +
                "Faisons un quizz pour augmenter ton niveau.\n" +
                "La réponse devra etre le numéro de cette dernière\n" +
                "Si un numéro autre que celui d'une réponse est tapé, elle sera considérée comme fausse\n" +
                "Appuie sur Entrer pour commencer le quizz.");
            Console.ReadKey();
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine("Appuie sur Entrer pour commencer le quizz");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    goto Quizz;
                }
            }

        Quizz:
            Console.Clear();
            Console.WriteLine("Question 1 :\n" +
                "Dans quel langage est programmé cette application ?\n" +
                "1: Java\n" +
                "2: C#\n" +
                "3: Php");
            int answerOne = Convert.ToInt32(Console.ReadLine());

            switch (answerOne)
            {
                case 1:
                    Console.WriteLine("Mauvaise réponse.\n" +
                        "Tu ne gagnes pas d'expérience pour cette question.");
                    Console.WriteLine("Appuies sur Entrer pour passer a la question suivante");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine("Appuies sur Entrer pour passer a la question suivante");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                    goto Question2;
                case 2:
                    Console.WriteLine("Réponse correcte.\n" +
                        "Tu gagnes donc 1 point d'expérience, Bravo. ");
                    experience++;
                    experienceEarned++;
                    Console.WriteLine("Appuies sur Entrer pour passer a la question suivante");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine("Appuies sur Entrer pour passer a la question suivante");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                    goto Question2;
                case 3:
                    Console.WriteLine("Mauvaise réponse.\n" +
                        "Tu ne gagnes pas d'expérience pour cette question.");
                    Console.WriteLine("Appuies sur Entrer pour passer a la question suivante");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine("Appuies sur Entrer pour passer a la question suivante");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                    goto Question2;
                default:
                    Console.WriteLine("La saisie est incorrecte.\n" +
                        "Aucun point d'expérience ne sera accordé pour cette question");
                    Console.WriteLine("Appuies sur Entrer pour passer a la question suivante");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine("Appuies sur Entrer pour passer a la question suivante");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                    goto Question2;
            }
            

        Question2:
            Console.Clear();
            Console.WriteLine("Question 2 (Difficile) :\n" +
                "Combien de lignes pensez vous que ce programme fait ?\n" +
                "1: Entre 100 et 125\n" +
                "2: Entre 150 et 200\n" +
                "3: Plus que 200");
            int answerTwo = Convert.ToInt32(Console.ReadLine());

            switch (answerTwo)
            {
                case 1:
                    Console.WriteLine("Mauvaise réponse.\n" +
                        "Tu ne gagnes pas d'expérience pour cette question.");
                    Console.WriteLine("Appuies sur Entrer pour passer aux résultats");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine("Appuies sur Entrer pour passer aux résultats");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                    goto Resultat;
                case 2:
                    Console.WriteLine("Mauvaise réponse.\n" +
                        "Tu ne gagnes pas d'expérience pour cette question.");
                    Console.WriteLine("Appuies sur Entrer pour passer aux résultats");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine("Appuies sur Entrer pour passer aux résultats");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                    goto Resultat;
                case 3:
                    Console.WriteLine("Réponse correcte.\n" +
                       "Tu gagnes donc 2 points d'expérience, Bravo. ");
                    experience += 2;
                    experienceEarned += 2;
                    Console.WriteLine("Appuies sur Entrer pour passer aux résultats");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine("Appuies sur Entrer pour passer aux résultats");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                    goto Resultat;
                default:
                    Console.WriteLine("La saisie est incorrecte.\n" +
                        "Aucun point d'expérience ne sera accordé pour cette question");
                    Console.WriteLine("Appuies sur Entrer pour passer aux résultats");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine("Appuies sur Entrer pour passer aux résultats");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                    goto Resultat;
            }
            
        Resultat:
            if (experience >= 2)
            {
                level++;
            }
            Console.Clear();
            Console.WriteLine("Ce quizz fut court mais intense n'est-ce pas " + name + " ?\n" +
                "Voici les résultats de ce dernier :\n" +
                "\n" +
                "Tu as acquis " + experienceEarned + " points d'expérience sur ce quizz\n" +
                "Tu es donc désormais niveau " + level + " .");
            if(level < 1)
            {
                int remainingExperience = levelUpRequirement - experience;
                Console.WriteLine("Il te manque " + remainingExperience + " pour passer niveau 1");
            }
            Console.WriteLine("\n" +
                "Merci d'avoir participé, et a bientot\n" +
                "Appuies sur Entrer pour fermer la console");
            Console.ReadKey();
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine("Appuies sur Entrer pour fermer la console");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}