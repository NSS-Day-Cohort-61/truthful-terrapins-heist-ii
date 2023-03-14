using System;

namespace truthful_terrapins_heist_ii
{
    public class LockPickSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= this.SkillLevel;
            Console.WriteLine($"{Name} is picking the vault system and has decresed it by {SkillLevel} points.");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the Vault system!");
            }
        }

        public LockPickSpecialist(string nameParam, int skillLevelParam, int percentageCutParam)
        {
            Name = nameParam;
            SkillLevel = skillLevelParam;
            PercentageCut = percentageCutParam;
        }
    }
}