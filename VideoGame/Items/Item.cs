namespace VideoGame.Inventory
{
    public abstract class Item
    {
        protected readonly string name;
        protected uint price = 0;
        protected bool salable = true;

        public string Name
        {
            get { return name; }
        }

        public uint? Price
        {
            get
            {
                if (!salable)
                {
                    return null;
                }
                return price;
            }
            set { price = (uint)value; }
        }

        public bool Salable
        {
            get { return salable; }
            set { salable = value; }
        }

        public abstract void Use(Player player);

        public Item(string name)
        {
            this.name = name;
        }

        public Item(string name, uint price, bool salable)
        {
            this.name = name;
            this.price = price;
            this.salable = salable;
        }
    }
}