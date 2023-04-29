using System;
using DefaultNamespace.COP;
using UnityEngine;

namespace DefaultNamespace.Controller
{
    public class MoveController : MonoBehaviour, IConstructListener, IStartGameListener, IFinishGameListener
    {
        private IMoveComponent _moveComponent;
        private InputController _inputController;

        public void Construct(GameContext gameContext)
        {
            _inputController = gameContext.GetService<InputController>();
            _moveComponent = gameContext.GetService<CharacterService>().GetCharacter().Get<IMoveComponent>();
        }
        
        public void OnStartGame()
        {
            _inputController.OnMove += OnMove;
        }

        private void OnMove(Vector3 vector3)
        {
            _moveComponent.Move(vector3 * Time.deltaTime);
        }

        public void OnFinishGame()
        {
        }
    }

    public interface IConstructListener
    {
        void Construct(GameContext gameContext);
    }

    public interface IFinishGameListener
    {
        void OnFinishGame();
    }

    public interface IStartGameListener
    {
        void OnStartGame();
    }
}