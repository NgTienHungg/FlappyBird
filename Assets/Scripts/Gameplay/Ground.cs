using UnityEngine;

namespace Game
{
    public class Ground : MonoBehaviour
    {
        [SerializeField] private Transform ground1, ground2;
        [SerializeField] private float speed;

        private Vector3 _distance;

        private void Start()
        {
            _distance = ground2.localPosition - ground1.localPosition;
        }

        private void Update()
        {
            ground1.Translate(Vector3.left * speed * Time.deltaTime);
            ground2.Translate(Vector3.left * speed * Time.deltaTime);

            if (ground2.localPosition.x <= 0)
            {
                ground1.localPosition = ground2.localPosition + _distance;
                (ground1, ground2) = (ground2, ground1); // swap
            }
        }
    }
}