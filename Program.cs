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

            while (true)
            {
                string noobName = Console.ReadLine();
                if(noobName == "")
                {
                    break;
                }

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

                switch (noobSpecialty)
                {
                    case 1:
                        rolodex.Add(new Hacker(noobName, noobSkill, noobPay));
                        break;
                    case 2:
                        rolodex.Add(new Muscle(noobName, noobSkill, noobPay));
                        break;
                    case 3:
                        rolodex.Add(new LockPickSpecialist(noobName, noobSkill, noobPay));
                        break;
                    default:
                        Console.WriteLine("Please select a speciality");
                        goto Taco;
                }

                Console.WriteLine($"Now we got {rolodex.Count} homies in this squad");
                Console.WriteLine("If you have anymore homies that want in, submit their name now! If not, hit enter to continue");
            };

            Random rnd = new Random();
            int coh = rnd.Next(50000, 1000001);
            int alarm = rnd.Next(0, 101);
            int vault = rnd.Next(0, 101);
            int guard = rnd.Next(0, 101);
            Bank bank = new(coh, alarm, vault, guard);

            // Let's do a little recon next. Print out a Recon Report to the user. 
            Dictionary<string, int> bankDict = new()
            {
                {"Alarm", bank.AlarmScore},
                {"Vault", bank.VaultScore},
                {"Security Guard", bank.SecurityGuardScore}
            };

            var ordered = bankDict.OrderBy(x => x.Value).ToList();

            Console.WriteLine($"Least secure system: {ordered[0].Key}. With a score of: {ordered[0].Value}");
            Console.WriteLine($"Most secure system: {ordered[2].Key}. With a score of: {ordered[2].Value}");

            int x = 0;

            foreach(IRobber rob in rolodex)
            {
                x += 1;
                Console.WriteLine($@"
                    Member {x}: {rob.Name}
                    Specialty: {rob.GetType().Name}
                    Skill Level: {rob.SkillLevel}
                    Cut: {rob.PercentageCut}%");
            }

            List<IRobber> crew = new();

            Console.WriteLine("Which members do you want on this job?");
            while(true)
            {
                string pick = Console.ReadLine();

                if(pick == "")
                {
                    break;
                }

                int index = int.Parse(pick) - 1;
                crew.Add(rolodex[index]);
                
            }


        }
    }
}
