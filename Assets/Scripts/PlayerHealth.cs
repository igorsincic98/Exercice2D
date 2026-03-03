using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _currentHealth;
    [SerializeField] private int _maxHealth;
    [SerializeField] public HealthBarManager _healthBar;
    public float invulnerableFrames;
    public GameManager gameManager;
    private bool isDead = false;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        _healthBar.SetMaxHealth(_maxHealth);
        invulnerableFrames = 0;
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
