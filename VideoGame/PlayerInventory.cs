namespace VideoGame.Inventory
{
    public class PlayerInventory<T>
    {
        private readonly Player player;
        private readonly List<T> mainInventory;
        private readonly List<T> hotbar;

        public Player Player
        {
            get { return player; }
        }

        public List<T> MainInventory
        {
            get { return mainInventory; }
        }

        public List<T> Hotbar
        {
            get { return hotbar; }
        }

        public PlayerInventory(Player player)
        {
            this.player = player;

            mainInventory = new List<T> { };
            hotbar = new List<T> { };
        }

        public void AddItem(T item, bool onHotbar)
        {
            if (onHotbar)
            {
                hotbar.Add(item);
                return;
            }
            mainInventory.Add(item);
        }

        public void RemoveItem(T item, bool onHotbar)
        {
            if (onHotbar)
            {
                hotbar.Remove(item);
                return;
            }
            mainInventory.Remove(item);
        }

        public void ClearInventory()
        {
            hotbar.Clear();
            mainInventory.Clear();
        }
        
    }
}