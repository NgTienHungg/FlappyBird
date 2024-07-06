using UnityEngine;

namespace Game
{
    public class Pipe : MonoBehaviour
    {
        [SerializeField] private float speed;

        private void Update()
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}