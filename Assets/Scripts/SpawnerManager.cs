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
    private float _spawnTimer;
    [SerializeField]
    private Transform[] _spawnPoints;
    public static Random Random;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _spawnTimer += Time.deltaTime;
        if (_spawnTimer >= _spawnRate)
        {
            Debug.Log("Spawning ?");
            //Transform rndPoint = Spawners[Random.Next(0, Spawners.Count)];
            Transform randomPoint = _spawnPoints[Random.Next(0, _spawnPoints.Length)]; 
            GameObject instantiated = Instantiate(_prefab);
            instantiated.transform.position = randomPoint.position;
            Debug.Log("Spawning !");



        }
    }
}

