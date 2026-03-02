using System;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public int _score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Pick Up !");
            ScoreManager.instance.AddPointPickUp();
            Destroy(gameObject);
        }
    }
}
