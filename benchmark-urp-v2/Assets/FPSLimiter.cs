using UnityEngine;

public class FPSLimiter : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 3_000;
    }
}
