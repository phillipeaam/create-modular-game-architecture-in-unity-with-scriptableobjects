using UnityEngine;

namespace CMGAIUWS.ExtendableEnums.Jokempo
{
    public class JokempoController : MonoBehaviour
    {
        [SerializeField] private JokempoItemSO itemLeft;
        [SerializeField] private JokempoItemSO itemRight;

        [ContextMenu(nameof(CompareItems))]
        public void CompareItems()
        {
            if (itemLeft.IsWinner(itemRight))
            {
                Debug.Log($"{itemLeft.Name} wins {itemRight.Name}");
            }
            else if (itemRight.IsWinner(itemLeft))
            {
                Debug.Log($"{itemRight.Name} wins {itemLeft.Name}");
            }
            else
            {
                Debug.Log("Draw");
            }
        }
    }
}