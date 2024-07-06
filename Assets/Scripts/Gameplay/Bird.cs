using UnityEngine;

namespace Game
{
    public class Bird : MonoBehaviour
    {
        [SerializeField] private float velocity;
        [SerializeField] private float rotationSpeed;

        private Rigidbody2D _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _rigidbody.velocity = Vector2.up * velocity;
            }
        }

        private void FixedUpdate()
        {
            transform.rotation = Quaternion.Euler(0, 0, _rigidbody.velocity.y * rotationSpeed);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Score"))
            {
                Debug.Log("ăn điểm");
                GameManager.Instance.score++;
            }
        }
    }
}