using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class CameraService : MonoBehaviour
    {
        [SerializeField] private Camera _cameraMain;

        public Camera MainCamera => _cameraMain;
    }
}