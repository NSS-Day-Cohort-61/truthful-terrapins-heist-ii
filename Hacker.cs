using System;

namespace truthful_terrapins_heist_ii
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= this.SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system and has decresed it by {SkillLevel} points.");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }

        public Hacker(string nameParam, int skillLevelParam, int percentageCutParam)
        {
            Name = nameParam;
            SkillLevel = skillLevelParam;
            PercentageCut = percentageCutParam;
        }
    }
}