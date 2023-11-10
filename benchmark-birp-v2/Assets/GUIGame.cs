using UnityEngine;
using UnityEngine.UI;

public class GUIGame : MonoBehaviour
{
    [SerializeField] private Button _buttonVeryLow;
    [SerializeField] private Button _buttonUltra;

    private void Start()
    {
        _buttonVeryLow.onClick.AddListener(OnButtonVeryLow);
        _buttonUltra.onClick.AddListener(OnButtonUltra);
    }

    private void OnButtonVeryLow()
        => QualitySettings.SetQualityLevel(0);
    private void OnButtonUltra()
        => QualitySettings.SetQualityLevel(1);
}
