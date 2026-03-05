using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static Vector2 Movement;
    public float _speed;
    
    private PlayerInput _playerInput;

    private InputAction _moveAction;
    void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Move"];
        _speed = 1f;

    }

    void Update()
    {
        Movement = _moveAction.ReadValue<Vector2>() * _speed;
    }
}
