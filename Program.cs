using System;
using System.Collections.Generic;
using System.Linq;

namespace truthful_terrapins_heist_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>()
            {
            new Hacker("chris", 50, 25),
            new Hacker("kaci", 51, 35),
            new LockPickSpecialist("pinto", 50, 25),
            new LockPickSpecialist("billy bob", 75, 5),
            new Muscle("john", 50, 25),
            new Muscle("taylor", 50, 5),
            };
            Console.WriteLine("We're breaking in and stealing some shit");
            Console.WriteLine($"We got {rolodex.Count} homies in this squad");
            
            Console.Write("Please enter the name of a new operative:");
            string noobName = Console.ReadLine();
                    
            Console.Write("Please enter their skill level (1-100):");
            int noobSkill = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter their percentage cut:");
            int noobPay = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please select a speciality:");
            Taco:
            Console.WriteLine("1) Hacker (Disables alarms)");
            Console.WriteLine("2) Muscle (Disarms guards)");
            Console.WriteLine("3) Lock Specialist (cracks vault)");
            int noobSpecialty = int.Parse(Console.ReadLine());

            switch(noobSpecialty)
            {
                case 1:
                    rolodex.Add(new Hacker (noobName, noobSkill, noobPay));
                    break;
                case 2:
                    rolodex.Add(new Muscle (noobName, noobSkill, noobPay));
                    break;
                case 3:
                    rolodex.Add(new LockPickSpecialist (noobName, noobSkill, noobPay));
                    break;
                default:
                    Console.WriteLine("Please select a speciality");
                    goto Taco;
            }

            Console.WriteLine($"Now we got {rolodex.Count} homies in this squad");
        }
    }
}
