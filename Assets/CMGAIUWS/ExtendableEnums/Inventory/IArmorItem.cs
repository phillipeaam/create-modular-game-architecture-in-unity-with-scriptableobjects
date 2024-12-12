namespace CMGAIUWS.ExtendableEnums.Inventory
{
    public interface IArmorItem
    {
        public int Value { get; }
        public IArmorSlot Slot { get; }
    }
}