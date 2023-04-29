using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameContextInstaller : MonoBehaviour
    {
        [SerializeField] private GameContext _gameContext;
        [SerializeField] private MonoBehaviour[] _listeners;
        [SerializeField] private MonoBehaviour[] _services;

        private void Awake()
        {
            foreach (var service in _services)
            {
                _gameContext.AddService(service);
            }
            
            foreach (var listener in _listeners)
            {
                _gameContext.AddListener(listener);
            }

            _gameContext.ConstructGame();
        }
    }
}