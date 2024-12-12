using UnityEngine;

namespace CMGAIUWS.ExtendableEnums.Base
{
    [CreateAssetMenu(
        fileName = nameof(GameItemSO),
        menuName = nameof(ExtendableEnums) + "/" + nameof(GameItemSO))]
    public class GameItemSO : ScriptableObject, IGameItem
    {
        [SerializeField] private string gameItemName;
        [SerializeField] private string gameItemDescription;

        public string Name => gameItemName;
        public string Description => gameItemDescription;
    }
}
