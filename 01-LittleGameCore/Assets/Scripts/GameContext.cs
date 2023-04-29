using System;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Controller;
using UnityEngine;

public class GameContext : MonoBehaviour
{
    [SerializeField] private EventReceiver _eventReceiver;

    private List<object> listeners = new List<object>();
    private List<object> _services = new List<object>();
    

    public void AddListener(object listener)
    {
        listeners.Add(listener);
    }
    
    public void RemoveListener(object listener)
    {
        listeners.Remove(listener);
    }
    
    private void OnEnable()
    {
        foreach (var listener in listeners)
        {
            if (listener is IStartGameListener result)
            {
                result.OnStartGame();
            }
        }
    }

    private void OnDisable()
    {
        foreach (var listener in listeners)
        {
            if (listeners is IFinishGameListener result)
            {
                result.OnFinishGame();
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _eventReceiver.Call();
        }
    }

    public T GetService<T>()
    {
        foreach (var service in _services)
        {
            if (service is T result)
            {
                return result;
            }
        }

        throw new Exception($"Service {typeof(T).Name} not found.");
    }

    public void ConstructGame()
    {
        foreach (var listener in listeners)
        {
            if (listener is IConstructListener result)
            {
                result.Construct(this);
            }
        }
    }

    public void AddService(MonoBehaviour service)
    {
        _services.Add(service);
    }
}
