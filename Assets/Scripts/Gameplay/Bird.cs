using UnityEngine;

namespace Game
{
    public class Bird : MonoBehaviour
    {
        [SerializeField] private float velocity;
        [SerializeField] private float rotationSpeed;

        private Rigidbody2D _rigidbody;
        private Animator _animator;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Flap();
            }
        }

        private void Flap()
        {
            SoundManager.Instance.PlayOneShot("wing");
            _rigidbody.velocity = Vector2.up * velocity;
        }

        private void FixedUpdate()
        {
            transform.rotation = Quaternion.Euler(0, 0, _rigidbody.velocity.y * rotationSpeed);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Score"))
            {
                GetScore();
            }
        }

        private void GetScore()
        {
            SoundManager.Instance.PlayOneShot("point");
            GameController.Instance.score++;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Pipe"))
            {
                Die();
            }
        }

        private void Die()
        {
            SoundManager.Instance.PlaySound("hit");
            _animator.enabled = false;
            GameController.Instance.GameOver();
        }
    }
}