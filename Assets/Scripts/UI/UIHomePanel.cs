namespace Game.UI
{
    public class UIHomePanel : UIPanel
    {
        public void OnClickPlayButton()
        {
            GameController.Instance.GoToPlayGame();
        }
    }
}