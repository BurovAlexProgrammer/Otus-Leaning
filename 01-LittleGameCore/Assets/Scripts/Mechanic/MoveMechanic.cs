using Primitive;
using UnityEngine;

namespace Mechanic
{
    public class MoveMechanic : MonoBehaviour
    {
        [SerializeField] private Vector3EventReceiver _moveReceiver;
        [SerializeField] private Transform _moveTransform;

        private void OnEnable()
        {
            _moveReceiver.OnEvent += OnMove;
        }
        
        private void OnDisable()
        {
            _moveReceiver.OnEvent -= OnMove;
        }

        private void OnMove(Vector3 moveVector3)
        {
            _moveTransform.position += moveVector3;
        }
    }
}