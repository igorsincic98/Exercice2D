using UnityEngine;

namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int _currentHealth;
        [SerializeField] private int _maxHealth;
        [SerializeField] public HealthBarManager _healthBar;
        [SerializeField] private AudioClip damageSoundClip;
        public float invulnerableFrames;
        public GameManager gameManager;
        private bool isDead = false;
        private AudioSource audioSource;
        private void Awake()
        {
            _currentHealth = _maxHealth;
            _healthBar.SetMaxHealth(_maxHealth);
            invulnerableFrames = 0;
            audioSource = GetComponent<AudioSource>();
        }

        private void Update()
        {
            if (invulnerableFrames >= 0)
            {
                invulnerableFrames -= Time.deltaTime;
            }
        }

        public void TakeDamage(int damage)
        {
            if (invulnerableFrames <= 0)
            {
                audioSource.clip = damageSoundClip;
                audioSource.Play();
                _currentHealth -= damage;
                invulnerableFrames = 3;
        
                _healthBar.SetHealth(_currentHealth);
                if (_currentHealth <= 0 && !isDead)
                {
                    isDead = true;
                    gameManager._gameOver();
                    gameManager.Pause();
                    Destroy(gameObject);

                }
            }
        }

    }
}
