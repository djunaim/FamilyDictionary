using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // my family, each member, their properties
         
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Andrew" } , { "age", "35" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Sukani" }, { "age", "58" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Harjanto" }, { "age", "62" } });
            myFamily.Add("husband", new Dictionary<string, string>() { { "name", "Joseph" }, { "age", "32" } });

            foreach(var member in myFamily)
            {
                // member is the entire Key/Value pair of myFamily
                // member.Key is the members themselves
                // Value is the 2nd dictionary
                // member.Value["name"] means get me the Value that has the Key of "name" from the 2nd dictionary
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
            }

        }
    }
}


