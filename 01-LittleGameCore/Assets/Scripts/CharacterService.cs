using DefaultNamespace.COP;
using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterService : MonoBehaviour
    {
        [SerializeField] private Entity _character;

        public Entity GetCharacter() => _character;
    }
}