using TMPro;
using UnityEngine;

namespace UI
{
    public class GameOverScreen : MonoBehaviour
    {
        [SerializeField] private ScoreController _scoreController;

        [SerializeField] private TextMeshProUGUI _currentScoreLabel;


        private void OnEnable()
        {
            _currentScoreLabel.text = _scoreController.GetCurrentScore().ToString();
        }
    }
}
