using DefaultNamespace;
using Primitive;
using UnityEngine;

namespace Mechanic
{
    public class RegenerationMechanic : MonoBehaviour
    {
        [SerializeField] private IntEventReceiver _takeDamageReceiver;
        [SerializeField] private IntBehaviour _hitPoints;
        [SerializeField] private TimerBehaviour _cooldownTimer;
        [SerializeField] private TimerBehaviour _regenerateTimer;

        private void OnEnable()
        {
            _takeDamageReceiver.OnEvent += OnTakeDamage;
            _cooldownTimer.OnEnded += OnCooldownEnded;
            _regenerateTimer.OnEnded += OnRegenerateTimerEnded;
        }

        private void OnRegenerateTimerEnded()
        {
            _hitPoints.Value++;
            _regenerateTimer.ResetTimer();
            _regenerateTimer.Run();
        }

        private void OnCooldownEnded()
        {
            _regenerateTimer.Run();
        }

        private void OnTakeDamage(int damage)
        {
            _regenerateTimer.Stop();
            _cooldownTimer.ResetTimer();
            _cooldownTimer.Run();
        }
    }
}