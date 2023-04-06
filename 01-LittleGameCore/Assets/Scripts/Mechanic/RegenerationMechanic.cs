using DefaultNamespace;
using UnityEngine;

namespace Mechanic
{
    public class RegenerationMechanic : MonoBehaviour
    {
        [SerializeField] private EventReceiver _takeDamageReceiver;
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

        private void OnTakeDamage()
        {
            _regenerateTimer.Stop();
            _cooldownTimer.ResetTimer();
            _cooldownTimer.Run();
        }
    }
}