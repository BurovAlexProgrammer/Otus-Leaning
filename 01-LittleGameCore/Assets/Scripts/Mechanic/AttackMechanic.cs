using System;
using DefaultNamespace;
using UnityEngine;

namespace Mechanic
{
    public class AttackMechanic : MonoBehaviour
    {
        [SerializeField] private EventReceiver _attackReceiver;
        [SerializeField] private TimerBehaviour _coolDown;

        [SerializeField] private Enemy _enemy;
        
        private void OnEnable()
        {
            _attackReceiver.OnEvent += OnAttackRequested;
        }
        
        private void OnDisable()
        {
            _attackReceiver.OnEvent -= OnAttackRequested;
        }

        private void OnAttackRequested()
        {
            if (_coolDown.IsPlaying) return;
            
            _enemy.TakeDamage();
            
            _coolDown.Run();
        }
    }
}