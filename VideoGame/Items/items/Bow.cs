namespace VideoGame.Inventory
{
    public class Bow : Item, IWeapon, IRangedWeapon, IAmmoWeapon
    {
        private int maxRange;
        private int remaining;

        public Bow(string name, uint price, bool salable, int maxRange, int remaining) : base(name, price, salable)
        {
            this.maxRange = maxRange;
            this.remaining = remaining;
        }

        public int MaxRange
        {
            get { return maxRange; }
            set { maxRange = value; }
        }

        public int Remaining
        {
            get { return remaining; }
            set { remaining = value; }
        }

        public bool Equip(Player player)
        {
            player.PlayerInventory.AddItem(this, true);
            return true;
        }

        public override void Use(Player player)
        {
            remaining--;
            Console.WriteLine($"{name} used. {remaining} arrows left...");
        }
    }
}