using MøbelProgram.Factories;
using MøbelProgram.MøbelProgram;
using System;
using System.Collections.Generic;

namespace MøbelProgram
{
    public class MøbelApp
    {
        private List<IMøbel> møbler;
        private List<IMøbelFactory> møbelFactories;
        private IMøbelFactory? factoryChoice;
        private Dictionary<EMøbelType, Func<IMøbel>> møbelCreators;

        public MøbelApp()
        {
            møbler = new List<IMøbel>();
            møbelFactories = new List<IMøbelFactory>()
            {
                new Serie1Factory(),
                new Serie2Factory()
            };
            møbelCreators = new Dictionary<EMøbelType, Func<IMøbel>>();
        }

        public void Run()
        {
            Console.WriteLine("Velkommen til møbel appen!");
            factoryChoice = VælgFactory();
            OpdaterMøbelCreators();

            while (true)
            {
                try
                {
                    VisMenu();
                    int choice = int.Parse(Console.ReadLine()!);

                    var møbelTyper = Enum.GetValues<EMøbelType>();

                    if (choice == 0)
                    {
                        Console.WriteLine("\nFarvel!");
                        break;
                    }
                    else if (choice >= 1 && choice <= møbelTyper.Length)
                    {
                        OpretMøbel(møbelTyper[choice - 1]);
                    }
                    else if (choice == møbelTyper.Length + 1)
                    {
                        VisMøbelListe();
                    }
                    else if (choice == møbelTyper.Length + 2)
                    {
                        SkiftSerie();
                    }
                    else
                    {
                        Console.WriteLine("\nUgyldigt valg. Prøv igen.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nFejl: Indtast venligst et tal.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"\nFejl: {ex.Message}");
                }
            }
        }

        private void OpdaterMøbelCreators()
        {
            møbelCreators = new Dictionary<EMøbelType, Func<IMøbel>>()
            {
                { EMøbelType.TrePersonersSofa, () => factoryChoice!.CreateTrePersonerSofa() },
                { EMøbelType.ToPersonersSofa, () => factoryChoice!.CreateToPersonerSofa() },
                { EMøbelType.Hjørnesofa, () => factoryChoice!.CreateHjørneSofa() },
                { EMøbelType.Lænestol, () => factoryChoice!.CreateLænestol() },
                { EMøbelType.Taburet, () => factoryChoice!.CreateTaburet() }
            };
        }

        private void VisMenu()
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine($"Nuværende serie: {factoryChoice}");
            Console.WriteLine($"Antal møbler i listen: {møbler.Count}");
            Console.WriteLine("------------");

            var møbelTyper = Enum.GetValues<EMøbelType>();
            for (int i = 0; i < møbelTyper.Length; i++)
            {
                Console.WriteLine($"{i + 1}: Opret {møbelTyper[i]}");
            }
            Console.WriteLine($"{møbelTyper.Length + 1}: Vis møbelliste");
            Console.WriteLine($"{møbelTyper.Length + 2}: Skift serie (nulstiller listen)");
            Console.WriteLine("0: Afslut");

            Console.Write("\nIndtast valg: ");
        }

        private IMøbelFactory VælgFactory()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nVælg din møbelserie:");
                    for (int i = 0; i < møbelFactories.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {møbelFactories[i].GetType().Name}");
                    }
                    Console.Write("Indtast valg: ");
                    int factoryValg = int.Parse(Console.ReadLine()!);

                    if (factoryValg >= 1 && factoryValg <= møbelFactories.Count)
                    {
                        return møbelFactories[factoryValg - 1];
                    }
                    throw new InvalidOperationException("Ugyldigt valg");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fejl: Indtast venligst et tal.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Fejl: {ex.Message}");
                }
            }
        }

        private void OpretMøbel(EMøbelType type)
        {
            IMøbel møbel = møbelCreators[type]();
            møbler.Add(møbel);
            Console.WriteLine($"\nOprettet: {møbel}");
        }

        private void VisMøbelListe()
        {
            Console.WriteLine("\n--- MØBELLISTE ---");
            if (møbler.Count == 0)
            {
                Console.WriteLine("Listen er tom.");
            }
            else
            {
                for (int i = 0; i < møbler.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {møbler[i]}");
                }
            }
        }

        private void SkiftSerie()
        {
            factoryChoice = VælgFactory();
            OpdaterMøbelCreators();
            møbler.Clear();
            Console.WriteLine("\n*** Listen er nulstillet pga. serieskift ***");
        }
    }
}
