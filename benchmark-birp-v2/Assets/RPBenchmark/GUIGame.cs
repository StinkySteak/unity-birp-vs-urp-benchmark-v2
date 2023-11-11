using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StinkySteak.RPBenchmark
{
    public class GUIGame : SingletonMono<GUIGame>
    {
        [Header("Graphics")]
        [SerializeField] private Button _buttonVeryLow;
        [SerializeField] private Button _buttonUltra;

        [Header("Level")]
        [SerializeField] private Button _buttonLevelSimple;
        [SerializeField] private Button _buttonLevelAdvanced;

        private void Start()
        {
            _buttonVeryLow.onClick.AddListener(OnButtonVeryLow);
            _buttonUltra.onClick.AddListener(OnButtonUltra);
            _buttonLevelSimple.onClick.AddListener(OnButtonLevelSimple);
            _buttonLevelAdvanced.onClick.AddListener(OnButtonLevelAdvanced);
        }

        private void OnButtonLevelSimple()
               => SceneManager.LoadScene(0);
        private void OnButtonLevelAdvanced()
            => SceneManager.LoadScene(1);
        private void OnButtonVeryLow()
                => QualitySettings.SetQualityLevel(0);
        private void OnButtonUltra()
            => QualitySettings.SetQualityLevel(1);
    }
}