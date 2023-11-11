using UnityEngine;

namespace StinkySteak.RPBenchmark
{
    public class LODGroupDisabler : MonoBehaviour
    {
        private void Start()
        {
            LODGroup[] groups = FindObjectsByType<LODGroup>(FindObjectsInactive.Include, FindObjectsSortMode.None);

            for (int i = 0; i < groups.Length; i++)
            {
                groups[i].enabled = false;
            }
        }
    }
}