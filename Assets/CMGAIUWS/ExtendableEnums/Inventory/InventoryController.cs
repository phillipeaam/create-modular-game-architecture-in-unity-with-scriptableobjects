using CMGAIUWS.ExtendableEnums.Base;
using UnityEngine;

namespace CMGAIUWS.ExtendableEnums.Inventory
{
    public class InventoryController : MonoBehaviour
    {
        [SerializeField] private GameItemSO[] inventoryItems;

        private IGameItem[] _inventoryItems;

        [ContextMenu(nameof(DescribeItems))]
        public void DescribeItems()
        {
            _inventoryItems = inventoryItems as IGameItem[];
            
            var sb = new System.Text.StringBuilder();
            var index = 0;

            foreach (var item in _inventoryItems)
            {
                if (item is null)
                {
                    sb.AppendLine("Item is null");
                    continue;
                }
                
                index++;
                
                sb.AppendLine($"Item index: {index}\nName: {item.Name}\nDescription: {item.Description}");
                
                if (item is IArmorItem armorItem)
                {
                    sb.Append($"Armor value: {armorItem.Value}\nArmor slot: {armorItem.Slot.Name}\n");
                }
                
                sb.AppendLine();
            }
            
            Debug.Log($"Inventory items:\n\n{sb}");
        }
    }
}
