using System.Collections.Generic;
using Old;
using Player;
using UnityEngine;

namespace Enemy
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private int _seed;
        [SerializeField] private float _lifeTime;

        [Header("Waypoints")]
        [SerializeField] private List<Transform> _waypoints;
        [SerializeField] private Transform _currentwaypoint;
        [SerializeField] private int _waypointIndex;
    
        [Header("Waiting")]
        [SerializeField] private float _waitTimer;
        [SerializeField] private float _waitDuration = -1;
        [SerializeField] private int _minWaitDuration = 1;
        [SerializeField] private int _maxWaitDuration = 2;

        public void Setup(List<Transform> waypoints)
        public void 
        {
            _waypoints = waypoints;
            if (_currentwaypoint == null)
                _currentwaypoint = _waypoints[_waypointIndex];
        }
        private void Start()
        {
            Invoke(nameof(DestroyMe), _lifeTime);
            _moveSpeed = _moveSpeed + ;
        }

        private void Update()
        {
            Vector3 movement = _currentwaypoint.position - transform.position;

            if (movement.magnitude < 0.1f)
            {
                if (_waitDuration < 0 )
                { 
                    _waitDuration = LevelManager.Random.Next(_minWaitDuration, _maxWaitDuration);
                }
                if (_waitTimer >= _waitDuration)
                {
                    _currentwaypoint = NextRandomWaypoint();
                    _waitTimer = 0f;



                    _waitDuration = -1;
                }
                else _waitTimer += Time.deltaTime;
            }
            else
            {
                transform.Translate(movement.normalized * (Time.deltaTime * _moveSpeed));
            }
        }

        private Transform NextWaypoint()
        {
            _waypointIndex++;
            if (_waypointIndex >= _waypoints.Count)
                _waypointIndex = 0;

            return _waypoints[_waypointIndex];
        }

        private Transform NextRandomWaypoint()
        {
            _waypointIndex = LevelManager.Random.Next(0, _waypoints.Count);
            return _waypoints[_waypointIndex];
        }

        private void DestroyMe()
        {
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            //Debug.Log(other.name);
            PlayerController target = other.GetComponent<PlayerController>();
            if (target != null)
            {
                target.TakeDamage(1);
            }

        }
    }
}
