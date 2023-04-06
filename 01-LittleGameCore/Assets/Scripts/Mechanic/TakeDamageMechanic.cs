using System;
using DefaultNamespace;
using Primitive;
using UnityEngine;

namespace Mechanic
{
    public class TakeDamageMechanic : MonoBehaviour
    {
        [SerializeField] private IntEventReceiver _takeDamageReceiver;
        [SerializeField] private IntBehaviour _hitPoints;

        private void OnEnable()
        {
            _takeDamageReceiver.OnEvent += OnDamageTaken;
        }

        private void OnDisable()
        {
            _takeDamageReceiver.OnEvent -= OnDamageTaken;
        }
        
        private void OnDamageTaken(int value)
        {
            _hitPoints.Value -= value;
        }
    }
}