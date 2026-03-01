using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHealth;
    public static Vector2 Movement;
    private PlayerInput _playerInput;
    private InputAction _moveAction;
    
    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Move"];

    }

    private void Update()
    {
        Movement = _moveAction.ReadValue<Vector2>();
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
