using UnityEngine;

namespace Game
{
    public class Pipe : MonoBehaviour
    {
        // [SerializeField] private Transform pipeTop, pipeBot;
        // [SerializeField] private float[] listDistance = { 6.2f, 6f, 5.6f };
        //
        // public void SetDifficult(int difficult)
        // {
        //     difficult = Mathf.Clamp(difficult, 0, listDistance.Length);
        // }

        // private void 

        [Header("Movement")]
        [SerializeField] private float speed;

        private void Update()
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}