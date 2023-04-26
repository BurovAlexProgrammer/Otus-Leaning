using System;
using DefaultNamespace.COP;
using UnityEngine;

namespace Primitive
{
    public class EntityEventReceiver : MonoBehaviour
    {
        public event Action<Entity> OnEvent;

        public void Call(Entity value)
        {
            OnEvent?.Invoke(value);
        }
    }
}