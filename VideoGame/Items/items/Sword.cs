namespace VideoGame.Inventory
{
    public class Sword : Item, IWeapon, IRangedWeapon
    {
        private int maxRange;

        public Sword(string name, uint price, bool salable, int maxRange) : base(name, price, salable)
        {
            this.maxRange = maxRange;
        }

        public int MaxRange
        {
            get { return maxRange; }
            set { maxRange = value; }
        }

        public bool Equip(Player player)
        {
            player.PlayerInventory.AddItem(this, true);
            return true;
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{name} used...");
        }
    }
}