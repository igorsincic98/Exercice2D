using System;
using UnityEngine;
using Pathfinding;

public class AIAgent : MonoBehaviour
{
    private AIPath path;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform _target;
    
    [SerializeField] private float stopDistanceThreshold;
    private float distanceToTarget;

    private void Start()
    {
        path = GetComponent<AIPath>();
        _target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        path.maxSpeed = _moveSpeed;
        distanceToTarget = Vector2.Distance(transform.position, _target.position);
        if (distanceToTarget < stopDistanceThreshold)
        {
            path.destination = transform.position;
        }
        else
        {
            path.destination = _target.position;
        }
    }
}

