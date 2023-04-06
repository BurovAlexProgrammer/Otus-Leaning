using System;
using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace
{
    public class EventReceiver : MonoBehaviour
    {
        public event Action OnEvent;

        public void Call()
        {
            OnEvent?.Invoke();
        }
    }
}