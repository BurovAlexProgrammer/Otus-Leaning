using DefaultNamespace.Controller;
using Primitive;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace.COP
{
    //НИКАКОЙ БИЗНЕС-ЛОГИКИ!!!
    public class AttackComponent : MonoBehaviour, IAttackComponent
    {
        [SerializeField] private EntityEventReceiver _targetReceiver;
        
        public void Attack(Entity target)
        {
            _targetReceiver.Call(target);
        }
    }
}