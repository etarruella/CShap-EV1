namespace VideoGame.Inventory
{
    public interface IArmor : IEquipable
    {
        List<ItemType> ItemTypes
        {
            get { return new List<ItemType>{ItemType.ARMOR}; }
        }
    }
}