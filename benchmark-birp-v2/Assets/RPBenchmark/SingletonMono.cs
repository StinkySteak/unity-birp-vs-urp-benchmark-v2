using UnityEngine;

namespace StinkySteak.RPBenchmark
{
    public class SingletonMono<T> : MonoBehaviour where T : Component
    {
        protected static T Instance { get; private set; }

        public static void Dispose()
            => Instance = null;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
                DontDestroyOnLoad(this);
                return;
            }

            Destroy(gameObject);
        }
    }
}