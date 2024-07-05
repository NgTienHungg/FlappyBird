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

        private void Start()
        {
            uiInGamePanel.Show();
            // uiInGamePanel.Hide();
            // uiGameOverPanel.Hide();
        }
    }
}