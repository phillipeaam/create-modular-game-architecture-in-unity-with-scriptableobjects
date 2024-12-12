using CMGAIUWS.ExtendableEnums.Base;
using UnityEngine;

namespace CMGAIUWS.ExtendableEnums.Jokempo
{
    [CreateAssetMenu(
        fileName = nameof(JokempoItemSO),
        menuName = nameof(ExtendableEnums) + "/" + nameof(JokempoItemSO))]
    public class JokempoItemSO : GameItemSO
    {
        [SerializeField] private JokempoItemSO weakness;

        public bool IsWinner(JokempoItemSO other)
        {
            return other.weakness == this;
        }
    }
}
