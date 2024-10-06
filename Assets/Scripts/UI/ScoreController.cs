using TMPro;
using UnityEngine;

namespace UI
{
    public class ScoreController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _currentScoreLabel; //ссылка на текст
        [SerializeField] private int _scorePerSquare; //количество очков за куб

        private int _currentScore; //общее количество очков
        
        public void AddScore()
        {
            _currentScore += _scorePerSquare;

            _currentScoreLabel.text = _currentScore.ToString();
        }
        
        public int GetCurrentScore()
        {
            return _currentScore;
        }
    }
}
