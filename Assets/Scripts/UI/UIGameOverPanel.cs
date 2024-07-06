using TMPro;
using UnityEngine;

namespace Game.UI
{
    public class UIGameOverPanel : UIPanel
    {
        [SerializeField] private TextMeshProUGUI scoreTxt;
        [SerializeField] private TextMeshProUGUI bestScoreTxt;

        public override void Show()
        {
            base.Show();
            scoreTxt.text = "SCORE: " + GameController.Instance.score;
            bestScoreTxt.text = "BEST SCORE: " + PlayerPrefs.GetInt("BestScore", 0);
        }
        
        public void OnClickBackButton()
        {
            GameController.Instance.BackToHome();
        }
    }
}