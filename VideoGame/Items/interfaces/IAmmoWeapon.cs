namespace VideoGame.Inventory
{
    public interface IAmmoWeapon
    {
        int Remaining
        {
            get;
            set;
        }

        List<ItemType> ItemTypes
        {
            get { return new List<ItemType>{ItemType.AMMO_WEAPON}; }
        }
    }
}