using CMGAIUWS.ExtendableEnums.Base;
using UnityEngine;

namespace CMGAIUWS.ExtendableEnums.Inventory
{
    [CreateAssetMenu(
        fileName = nameof(ArmorItemSO),
        menuName = nameof(ExtendableEnums) + "/" + nameof(ArmorItemSO))]
    public class ArmorItemSO : GameItemSO, IArmorItem
    {
        [SerializeField] private int armorValue;
        [SerializeField] private ArmorSlotSO armorSlot;
        
        public int Value => armorValue;
        public IArmorSlot Slot => armorSlot;
    }
}
