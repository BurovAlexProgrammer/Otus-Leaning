using Primitive;
using UnityEngine;

namespace DefaultNamespace.COP
{
    //НИКАКОЙ БИЗНЕС-ЛОГИКИ!!!
    public class MoveComponent : MonoBehaviour, IMoveComponent
    {
        [SerializeField] private Vector3EventReceiver _moveReceiver;
        
        public void Move(Vector3 vector3)
        {
            _moveReceiver.Call(vector3);
        }
    }
}