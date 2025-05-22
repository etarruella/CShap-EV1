namespace VideoGame.Inventory
{
    public class MagicWand : Item, IWeapon, IRangedWeapon, ISpellCaster
    {
        private int maxRange;
        private string spell;

        public MagicWand(string name, uint price, bool salable, int maxRange, string spell) : base(name, price, salable)
        {
            this.maxRange = maxRange;
            this.spell = spell;
        }

        public int MaxRange
        {
            get { return maxRange; }
            set { maxRange = value; }
        }

        public string Spell
        {
            get { return spell; }
            set { spell = value; }
        }

        public bool Equip(Player player)
        {
            player.PlayerInventory.AddItem(this, true);
            return true;
        }

        public override void Use(Player player)
        {
            if (player.Magic > 10)
            {
                player.Magic -= 10;
                Console.WriteLine($"{name} used... {player.Magic} player magic remaining...");
                return;
            }
            
            Console.WriteLine($"{player.Name} has enough magic to use {name}...");
        }
    }
}