using UnityEngine;

namespace Game.UI
{
    public class UIPanelManager : MonoBehaviour
    {
        public static UIPanelManager Instance { get; private set; }

        public UIPanel uiHomePanel;
        public UIPanel uiInGamePanel;
        public UIPanel uiGameOverPanel;

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

        public void StartGame()
        {
            uiHomePanel.Show();
            uiInGamePanel.Hide();
            uiGameOverPanel.Hide();
        }

        public void FromHomeToPlay()
        {
            uiHomePanel.Hide();
            uiInGamePanel.Show();
        }

        public void ShowGameOver()
        {
            uiInGamePanel.Hide();
            uiGameOverPanel.Show();
        }
    }
}