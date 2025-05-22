namespace VideoGame.Inventory
{
    public class Player
    {
        private readonly PlayerInventory<Item> playerInventory;
        private readonly string name;

        private uint maxHealth;
        private uint maxStamina;
        private uint maxMagic;
        private uint health;
        private uint stamina;
        private uint magic;

        public PlayerInventory<Item> PlayerInventory
        {
            get { return playerInventory; }
        }

        public string Name
        {
            get { return name; }
        }

        public uint MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }

        public uint Health
        {
            get { return health; }
            set
            {
                if (value > maxHealth)
                {
                    health = maxHealth;
                    return;
                }
                health = value;
            }
        }

        public uint MaxStamina
        {
            get { return maxStamina; }
            set { maxStamina = value; }
        }

        public uint Stamina
        {
            get { return stamina; }
            set
            {
                if (value > maxStamina)
                {
                    stamina = maxStamina;
                    return;
                }
                stamina = value;
            }
        }

        public uint Magic
        {
            get { return magic; }
            set { magic = value; }
        }

        public Player(string name, uint maxHealth, uint maxStamina, uint maxMagic, uint health, uint stamina, uint magic)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.maxStamina = maxStamina;
            this.maxMagic = maxMagic;
            this.health = health;
            this.stamina = stamina;
            this.magic = magic;

            playerInventory = new PlayerInventory<Item>(this);
        }
    }
}