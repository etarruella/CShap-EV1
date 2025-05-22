namespace VideoGame.Inventory
{
    public abstract class Potion : Item, ILimitedUse, ISpellCaster
    {
        protected readonly int maxUses;
        protected int remaining;
        protected string spell;

        public int MaxUses
        {
            get { return maxUses; }
        }

        public int Remaining
        {
            get { return remaining; }
            set
            {
                if (value > maxUses)
                {
                    return;
                }
                remaining = value;
            }
        }

        public string Spell
        {
            get { return spell; }
            set { spell = value; }
        }

        protected Potion(string name, uint price, bool salable, int maxUses, int remaining, string spell) : base(name, price, salable)
        {
            this.maxUses = maxUses;
            this.spell = spell;
            
            if (remaining > maxUses)
            {
                this.remaining = maxUses;
                return;
            }
            this.remaining = remaining;
        }
    }
}