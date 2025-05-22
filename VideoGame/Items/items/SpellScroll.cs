namespace VideoGame.Inventory
{
    public class SpellScroll : Item, IWeapon, ILimitedUse, IRangedWeapon
    {
        private int remaining = 1;
        private int maxRange;

        public SpellScroll(string name, uint price, bool salable, int maxRange) : base(name, price, salable)
        {
            this.maxRange = maxRange;
        }

        public int Remaining
        {
            get { return remaining; }
            set { remaining = value; }
        }

        public int MaxRange
        {
            get { return maxRange; }
            set { maxRange = value; }
        }

        public bool Equip(Player player)
        {
            throw new NotImplementedException();
        }

        public override void Use(Player player)
        {
            remaining--;
            Console.WriteLine($"Using {name}. Remaining uses: {remaining}.");
        }
    }
}