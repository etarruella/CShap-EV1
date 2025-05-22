namespace VideoGame.Inventory
{
    public interface IWeapon : IEquipable
    {
        List<ItemType> ItemTypes
        {
            get { return new List<ItemType>{ItemType.WEAPON}; }
        }
    }
}