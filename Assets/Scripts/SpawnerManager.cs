using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnerManager : MonoBehaviour
{
    [Header("Spawning")]
    [SerializeField]
    public GameObject _prefab;
    [SerializeField]
    public int _spawnRate;
    [SerializeField]
    public int _spawnRateMin;
    [SerializeField]
    public int _spawnRateMax;
    private float _spawnTimer;
    [SerializeField]
    private Transform[] _spawnPoints;
    public Random Random = new Random();



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spawnRate = Random.Next(_spawnRateMin, _spawnRateMax);
    }

    // Update is called once per frame
    void Update()
    {
        _spawnTimer += Time.deltaTime;
        if (_spawnTimer >= _spawnRate)
        {
            //Transform rndPoint = Spawners[Random.Next(0, Spawners.Count)];
            
            int random = Random.Next(0, _spawnPoints.Length);
            Transform randomPoint = _spawnPoints[random]; 
            GameObject instantiated = Instantiate(_prefab);
            instantiated.transform.position = randomPoint.position;
            _spawnTimer = 0;
            _spawnRate = Random.Next(_spawnRateMin, _spawnRateMax);



        }
    }
}

