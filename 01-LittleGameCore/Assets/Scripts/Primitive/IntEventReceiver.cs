using System;
using UnityEngine;

namespace Primitive
{
    public class IntEventReceiver : MonoBehaviour
    {
        public event Action<int> OnEvent;

        public void Call(int value)
        {
            OnEvent?.Invoke(value);
        }
    }
}