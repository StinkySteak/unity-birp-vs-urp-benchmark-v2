using UnityEngine;
using UnityEngine.Rendering;

public class URPDebugManagerDisabler : MonoBehaviour
{
    private void Awake()
    {
        DebugManager.instance.enableRuntimeUI = false;
    }
}