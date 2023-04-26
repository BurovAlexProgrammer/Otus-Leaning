using Mechanic;
using Primitive;
using UnityEngine;

namespace COP
{
    public class TakeDamageComponent: MonoBehaviour, ITakeDamageComponent
    {
        [SerializeField] private IntEventReceiver _eventReceiver;
        public void TakeDamage(int damage)
        {
            _eventReceiver.Call(damage);
        }
    }
}