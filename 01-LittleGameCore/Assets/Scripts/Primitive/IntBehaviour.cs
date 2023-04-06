using System;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class IntBehaviour: MonoBehaviour
    {
        [SerializeField] private int value;

        public event Action<int> OnValueChanged; 

        public int Value
        {
            get => value;
            set
            {
                this.value = value; 
                OnValueChanged?.Invoke(value);
            }
        }
    }
}