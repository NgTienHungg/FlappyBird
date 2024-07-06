using TMPro;
using UnityEngine;

namespace Game.UI
{
    public class UIInGamePanel : UIPanel
    {
        [SerializeField] private GameObject title;
        [SerializeField] private GameObject tutorial;
        [SerializeField] private TextMeshProUGUI scoreText;

        public override void Show()
        {
            base.Show();
            title.SetActive(true);
            tutorial.SetActive(true);
            scoreText.text = GameController.Instance.score.ToString();
        }

        public void OnClickStartButton()
        {
            GameController.Instance.StartPlayGame();
            title.SetActive(false);
            tutorial.SetActive(false);
        }

        private void FixedUpdate()
        {
            scoreText.text = GameController.Instance.score.ToString();
        }
    }
}