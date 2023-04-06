using System;
using DefaultNamespace;
using UnityEngine;

namespace Mechanic
{
    public class DeathMechanic : MonoBehaviour
    {
        [SerializeField] private IntBehaviour _hitPoints;
        [SerializeField] private EventReceiver _deathReceiver;

        private void OnEnable()
        {
            _hitPoints.OnValueChanged += HitPointsOnValueChanged;
        }
        
        private void OnDisable()
        {
            _hitPoints.OnValueChanged -= HitPointsOnValueChanged;
        }

        private void HitPointsOnValueChanged(int value)
        {
            if (value <= 0)
            {
                _deathReceiver.Call();
            }
        }
    }
}