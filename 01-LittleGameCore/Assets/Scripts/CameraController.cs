using System;
using DefaultNamespace.Controller;
using DefaultNamespace.COP;
using UnityEngine;

namespace DefaultNamespace
{
    public class CameraController : MonoBehaviour, IConstructListener
    {
        private Camera _mainCamera;
        private Entity _character;

        public void Construct(GameContext gameContext)
        {
            _mainCamera= gameContext.GetService<CameraService>().MainCamera;
            _character = gameContext.GetService<CharacterService>().GetCharacter();
        }

        private void LateUpdate()
        {
            var direction = _character.transform.position - _mainCamera.transform.position;
            _mainCamera.transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}