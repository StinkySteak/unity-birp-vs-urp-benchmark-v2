using Tayx.Graphy;
using UnityEngine;

namespace StinkySteak.RPBenchmark
{
    public static class GameMain
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void DisposeSingleton()
        {
            Application.targetFrameRate = 3_000;

            GUIGame.Dispose();



            if (GraphyManager.Instance != null)
                Object.Destroy(GraphyManager.Instance);
        }
    }
}