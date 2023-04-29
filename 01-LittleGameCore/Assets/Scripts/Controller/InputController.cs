using System;
using DefaultNamespace.COP;
using Mechanic;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace.Controller
{
    public class InputController : MonoBehaviour, IStartGameListener
    {
        public Entity Entity;
        public Entity EnemyEntity;
        
        public event Action<Vector3> OnMove;
        public event Action OnAttack;
        
        private void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                Move(Vector3.left);
            } 
            else if (Input.GetKey(KeyCode.D))
            {
                Move(Vector3.right);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                Move(Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Move(Vector3.back);
            }

            if (Input.anyKeyDown)
            {
                Attack();
            }
        }

        private void Attack()
        {
            Entity.Get<IAttackComponent>().Attack(EnemyEntity);
            OnAttack?.Invoke();
        }

        private void Move(Vector3 vector3)
        {
            var speed = 5f;
            OnMove?.Invoke(vector3);
        }

        public void OnStartGame()
        {
            
        }
    }
}