using UnityEngine;

namespace Runtime.Extensions
{
    public class MonoSingleton<T> : MonoBehaviour where T : Component
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        GameObject newGameObject = new GameObject(typeof(T).Name);
                        _instance = newGameObject.AddComponent<T>();
                    }
                }

                return _instance;
            }
        }

        protected void Awake()
        {
            _instance = this as T;
        }
    }
}