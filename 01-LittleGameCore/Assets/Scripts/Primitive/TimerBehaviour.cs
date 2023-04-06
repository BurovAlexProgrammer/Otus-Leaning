using System;
using System.Collections;
using Unity.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class TimerBehaviour : MonoBehaviour
    {
        [SerializeField] private float _duration = 3;
        [ReadOnly][SerializeField] private float _currentTime;

        private Coroutine _coroutine;
        
        public event Action OnEnded;

        public bool IsPlaying => _coroutine != null;

        public void Run()
        {
            if (_coroutine == null)
            {
                _coroutine = StartCoroutine(RunTimer());
            }
        }
        
        public void Stop()
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }

        public void ResetTimer()
        {
            _currentTime = 0f;
        }

        private IEnumerator RunTimer()
        {
            
            while (_currentTime < _duration)
            {
                yield return null;
                _currentTime += Time.deltaTime;
            }

            _currentTime = 0;
            _coroutine = null;
            OnEnded?.Invoke();
        }
    }
}