using System;
using Primitive;
using UnityEngine;

namespace DefaultNamespace
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private IntBehaviour _hitPoints;
        [SerializeField] private EventReceiver _attackReceiver;
        [SerializeField] private IntEventReceiver _tackDamageReceiver;
        [SerializeField] private EventReceiver _deathReceiver;

        public IntBehaviour HitPoints => _hitPoints;

        public event Action<int> OnHitPointsChanged
        {
            add => _hitPoints.OnValueChanged += value;
            remove => _hitPoints.OnValueChanged -= value;
        }
        
        public event Action OnDeath
        {
            add => _deathReceiver.OnEvent += value;
            remove => _deathReceiver.OnEvent -= value;
        }

        public void Attack()
        {
            _attackReceiver.Call();
        }

        public void TakeDamage(int damage)
        {
            _tackDamageReceiver.Call(damage);
        }
    }
} 