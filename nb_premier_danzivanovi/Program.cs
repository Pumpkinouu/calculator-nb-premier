//ETML
//Auteur      : Danilo Zivanovic
//Date        : 23.12.2022
//Descritpion : L'utilisateur donne un nombre puis la console affiche les nombre premiers précédent.
using System;

namespace nb_premier_danzivanovi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool recommencer = true;

            Console.Title = ("Nombre Premier");
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Bienvenue dans le programme Nombre Premier by Danilo Zivanovic ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.ResetColor();


                // Demander à l'utilisateur d'entrer un nombre
                Console.Write("Veuillez entrer un nombre : ");
                int number = Convert.ToInt32(Console.ReadLine());

                // Vérifier les nombres premiers qui précèdent le nombre saisi par l'utilisateur
                Console.WriteLine("Les nombres premiers qui précèdent " + number + " sont :");
                int count = 0;
                for (int i = 2; i < number; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    // Afficher les nombres premiers 
                    if (isPrime)
                    {
                        Console.Write(i + " ");
                        count++;
                        if (count % 10 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine();
                Console.Write("Voulez vous recommencer le programme ? (o / n): ");
                string oui = "o";
                if (oui == Console.ReadLine())
                {
                    recommencer = true;
                }
                else
                {
                    recommencer = false;
                }
            } while (recommencer == true);
        }
    }
}
