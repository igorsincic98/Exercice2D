using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private CharacterController _characterController;
    private Vector3 _move;
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 moveDirection = transform.TransformDirection(_move);
        moveDirection *= _moveSpeed;
        _characterController.Move(moveDirection * Time.deltaTime);
    }

    private void OnMove(InputValue input)
    {
        Vector2 movement = input.Get<Vector2>();
        _move.x = movement.x;
        _move.y = movement.y;
    }
}
