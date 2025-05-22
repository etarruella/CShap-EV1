namespace VideoGame.Inventory
{
    public class Armor : Item
    {
        private float dmgReduction;

        public float DmgReduction
        {
            get { return dmgReduction; }
            set
            {
                if (value > 1 | value < 0)
                {
                    return;
                }
                dmgReduction = value;
            }
        }

        public Armor(string name, float dmgReduction) : base(name)
        {
            this.dmgReduction = dmgReduction;
        }

        public float ReduceDMG(float damage)
        {
            float reducedDamage = damage * (1 - dmgReduction);

            Console.WriteLine($"Damage reduced from {damage} to {reducedDamage}.");
            return reducedDamage;
        }

        public override void Use(Player player)
        {
            // nothing;
        }
    }
}