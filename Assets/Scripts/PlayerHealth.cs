using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _currentHealth;
    [SerializeField] private int _maxHealth;
    [SerializeField] public HealthBarManager _healthBar;
    public GameManager gameManager;
    private bool isDead = false;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        _healthBar.SetMaxHealth(_maxHealth);
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        _healthBar.SetHealth(_currentHealth);
        if (_currentHealth <= 0 && !isDead)
        {
            isDead = true;
            gameManager._gameOver();
            Destroy(gameObject);
            
        }
    }

}
