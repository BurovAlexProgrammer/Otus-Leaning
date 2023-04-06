using DefaultNamespace;
using UnityEngine;

public class SceneContext : MonoBehaviour
{
    [SerializeField] private EventReceiver _eventReceiver;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _eventReceiver.Call();
        }
    }
}
