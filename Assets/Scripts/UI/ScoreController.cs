using TMPro;
using UnityEngine;

namespace UI
{
    public class ScoreController : MonoBehaviour
    {
        private const string BEST_SCORE = "BestScore"; //константа для сохранения и загрузки данных

        [SerializeField] private AudioSource _bestScoreSound;
        [SerializeField] private TextMeshProUGUI _currentScoreLabel; //ссылка на текст
        [SerializeField] private int _scorePerSquare; //количество очков за куб

        private int _currentScore; //общее количество очков
        private int _bestScore; //лучший результат очков
        
        private void Awake()
        {
            _bestScore = PlayerPrefs.GetInt(BEST_SCORE);
        }
        
        public void AddScore()
        {
            _currentScore += _scorePerSquare;

            _currentScoreLabel.text = _currentScore.ToString();
        }
        
        public int GetCurrentScore()
        {
            return _currentScore;
        }
        
        public int GetBestScore()
        {
            if (_currentScore > _bestScore)
            {
                _bestScore = _currentScore;
                PlayerPrefs.SetInt(BEST_SCORE, _bestScore); //записываем значение по ключу
                PlayerPrefs.Save(); //сохраняем данны
                _bestScoreSound.Play();
            }

            return _bestScore;
        }
    }
}
