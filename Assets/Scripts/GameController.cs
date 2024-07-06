using Game.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class GameController : MonoBehaviour
    {
        public static GameController Instance { get; private set; }

        [HideInInspector] public int score;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            Time.timeScale = 0f;
            UIPanelManager.Instance.StartGame();
        }

        public void GoToPlayGame()
        {
            UIPanelManager.Instance.FromHomeToPlay();
        }

        public void StartPlayGame()
        {
            Time.timeScale = 1f;
        }

        public void GameOver()
        {
            Time.timeScale = 0f;

            if (score > PlayerPrefs.GetInt("BestScore", 0))
            {
                PlayerPrefs.SetInt("BestScore", score);
            }

            SoundManager.Instance.PlaySound("die");
            UIPanelManager.Instance.ShowGameOver();
        }

        public void BackToHome()
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}