using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_med_Trinne_og_Carl
{

    //Lager en 'oppskrift' hvor du lager en mal for det du skal lage
    internal class Person
    {
       public string Name;
       public int Age;
       public string HairColor;
       public string Hobby;
       public string WhatDoing;
       public string Textbox;

       //Tom constructor som gjør at du kan få inn alle metodene
       public Person()
       {
       }

       //Constructor som gjør at du kan sette verdiene direkte via constructor og inn i objekter.
       public Person(string name, int age, string haircolor, string hobby, string whatdoing)
       {
           Name = name;
           Age = age;
           HairColor = haircolor;
           Hobby = hobby;
           WhatDoing = whatdoing;
           Textbox = $"Hei , jeg heter {Name} Jeg er {Age} år gammel og jeg har {HairColor} hår,";
       }

       public void ShowPeople()
       {
           Console.Clear();
           Console.WriteLine(Textbox);
           Console.WriteLine(Hobby);
           Console.WriteLine(WhatDoing);
       }
    }
}
