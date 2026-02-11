using System.Collections.Generic;
using UnityEngine;


    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private float _levelSpeed;
    
        [SerializeField] private GameObject _prefab;
        [SerializeField] private float _spawnRate;

        public static List<Transform> SpawnPoints = new();
        public static List<Transform> WayPoints = new();
        
        private float _spawnTimer;

        private void Update()
        {
            transform.Translate(Vector2.down * (Time.deltaTime * _levelSpeed));
        
            _spawnTimer += Time.deltaTime;
            if (_spawnTimer >= _spawnRate)
            {
                if (WayPoints.Count == 0 || SpawnPoints.Count == 0) return;

                Transform rndPoint = SpawnPoints[Random.Range(0, SpawnPoints.Count)];
                GameObject instantiate = Instantiate(_prefab, rndPoint.position, rndPoint.rotation, rndPoint);
                instantiate.GetComponent<EnemyController>().Setup(WayPoints);
                _spawnTimer = 0;
            }
        }
    }
