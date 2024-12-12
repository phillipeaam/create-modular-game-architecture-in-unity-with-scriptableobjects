using UnityEngine;

namespace CMGAIUWS.ExtendableEnums.Inventory
{
    [CreateAssetMenu(
        fileName = nameof(ArmorSlotSO),
        menuName = nameof(ExtendableEnums) + "/" + nameof(ArmorSlotSO))]
    public class ArmorSlotSO : ScriptableObject, IArmorSlot
    {
        [SerializeField] private string slotName; 

        public string Name => slotName;
    }
}
