using System;
using DefaultNamespace.Controller;
using UnityEngine;

namespace DefaultNamespace.COP
{
    public class Entity : MonoBehaviour
    {
        [SerializeField] private MonoBehaviour[] _components;

        public T Get<T>()
        {
            for (var i = 0; i < _components.Length; i++)
            {
                var component = _components[i];

                if (component is T result)
                {
                    return result;
                }
            }

            throw new Exception($"Component type of {typeof(T).Name} is not found.");
        }

        public bool TryGet<T>(out T outResult)
        {
            for (var i = 0; i < _components.Length; i++)
            {
                var component = _components[i];

                if (component is T result)
                {
                    outResult = result;
                    return true;
                }
            }

            outResult = default;
            return false;
        }
    }
}