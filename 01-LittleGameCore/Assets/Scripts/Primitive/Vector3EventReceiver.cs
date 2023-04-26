using System;
using UnityEngine;

namespace Primitive
{
    public class Vector3EventReceiver : MonoBehaviour
    {
        public event Action<Vector3> OnEvent;

        public void Call(Vector3 value)
        {
            OnEvent?.Invoke(value);
        }
    }
}