using UnityEngine;

namespace DefaultNamespace
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private EventReceiver _takeDamageReceiver;
        
        public void TakeDamage()
        {    
            _takeDamageReceiver.Call();
        }
    }
}