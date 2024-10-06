using TMPro;
using UnityEngine;

namespace UI
{
    public class GameOverScreen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _bestScoreLabel;
        [SerializeField] private ScoreController _scoreController;
        [SerializeField] private TextMeshProUGUI _currentScoreLabel;
        
        private void OnEnable()
        {
            _currentScoreLabel.text = _scoreController.GetCurrentScore().ToString();
            _bestScoreLabel.text = $"BEST {_scoreController.GetBestScore().ToString()}";
        }
    }
}
