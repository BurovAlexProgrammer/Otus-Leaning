using DefaultNamespace;
using DefaultNamespace.COP;
using Primitive;
using UnityEngine;

namespace Mechanic
{
    public class AttackMechanic : MonoBehaviour
    {
        [SerializeField] private EntityEventReceiver _attackReceiver;
        [SerializeField] private TimerBehaviour _coolDown;
        [SerializeField] private IntBehaviour _damage;

        [SerializeField] private Enemy _enemy;
        
        private void OnEnable()
        {
            _attackReceiver.OnEvent += OnAttackRequested;
        }
        
        private void OnDisable()
        {
            _attackReceiver.OnEvent -= OnAttackRequested;
        }

        private void OnAttackRequested(Entity target)
        {
            if (_coolDown.IsPlaying) return;

            target.Get<ITakeDamageComponent>().TakeDamage(_damage.Value);
            //_enemy.TakeDamage(5);
            
            _coolDown.Run();
        }
    }
    
}