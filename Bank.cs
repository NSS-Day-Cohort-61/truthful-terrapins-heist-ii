using System;

namespace truthful_terrapins_heist_ii
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure
        {
            get
            {
                return !(AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0);
            }
        }

        public Bank(int coh, int alarm, int vault, int guard)
        {
            CashOnHand = coh;
            AlarmScore = alarm;
            VaultScore = vault;
            SecurityGuardScore = guard;

        }
    }
}
