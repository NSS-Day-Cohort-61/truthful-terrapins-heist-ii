using System;

namespace truthful_terrapins_heist_ii
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= this.SkillLevel;
            Console.WriteLine($"{Name} is destroying the security guard and has decresed it by {SkillLevel} points.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has killed the guards!");
            }
        }

        public Muscle(string nameParam, int skillLevelParam, int percentageCutParam)
        {
            Name = nameParam;
            SkillLevel = skillLevelParam;
            PercentageCut = percentageCutParam;
        }
    }
}