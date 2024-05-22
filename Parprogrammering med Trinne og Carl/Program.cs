using System.Xml.Linq;

namespace Parprogrammering_med_Trinne_og_Carl
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Welcome to chaos!");
                Console.WriteLine("");
                Console.WriteLine("Choose what you wish to do");
                Console.WriteLine("1 Meet the gang!");
                Console.WriteLine("2 Exit App");

                string response = Console.ReadLine();
                if (response == "1")
                {
                    MeetTheGang();
                } else if (response == "2")
                {
                    Environment.Exit(69);
                }

            } 
            void MeetTheGang()
            {
                while (true)
                {
                    Console.WriteLine("\n1 Carl");
                    Console.WriteLine("2 Trine");
                    Console.WriteLine("3 Audun");
                    Console.WriteLine("4 Back to main");
                    string Reaction = Console.ReadLine();
                    if (Reaction == "1")
                    {
                        Carl();
                    }
                    else if (Reaction == "2")
                    {
                        Trine();
                    }
                    else if (Reaction == "3")
                    {
                        Audun();
                    }
                    else if (Reaction == "4")
                    {
                        Main();
                    }
                }
            }

            void Carl()
            {
                //Du kaller og setter de forskjellige verdiene
                Person Carl = new Person();
                Carl.Name = "Carl";
                Carl.Age = 23;
                Carl.HairColor = "Blond";
                Carl.Hobby = "Nå koder jeg!";
                Carl.WhatDoing = "Se på meg! Jeg har blitt et dataprogram!";
                Carl.Textbox = $"Hei , jeg heter {Carl.Name} Jeg er {Carl.Age} år gammel og jeg har {Carl.HairColor} hår,";

                Carl.ShowPeople();
            }

            void Trine()
            {
                //Her lages en person og verdiene settes direkte
                Person Trine = new Person
                {
                    Name = "Trine",
                    Age = 31,
                    HairColor = "Brunt",
                    Hobby = "Gaming og lese bøker!",
                    WhatDoing = "Jeg prøver å lære meg C# og gråter innvendig!",
                };
                Trine.Textbox = $"Hei , jeg heter {Trine.Name} Jeg er {Trine.Age} år gammel og jeg har {Trine.HairColor} hår,";
                
                Trine.ShowPeople();
            }

            void Audun()
            {
                //Du sender med de forskjellige verdiene du vil ha inn i constructoren
                Person Audun = new Person("Audun", 22, "Brunt", "Jeg stirrer i takket.", "Det er gøy å svinge rundt på stolen.");
                Audun.ShowPeople();
            }
        }

     
    }
}




