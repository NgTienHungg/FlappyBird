using TMPro;
using UnityEngine;

namespace Game.UI
{
    public class UIInGamePanel : UIPanel
    {
        [SerializeField] private TextMeshProUGUI scoreText;

        private void OnEnable()
        {
            scoreText.text = GameManager.Instance.score.ToString();
        }

        private void FixedUpdate()
        {
            scoreText.text = GameManager.Instance.score.ToString();
        }
    }
}