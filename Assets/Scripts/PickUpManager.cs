using System;
using Player;
using UnityEngine;
using UnityEngine.Serialization;

public class PickUpManager : MonoBehaviour
{
    public int Score;
    
    [SerializeField] private AudioClip _pickUpSound;

    private AudioSource _audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(_pickUpSound, transform.position, 1f);
            Debug.Log("Pick Up !");
            ScoreManager.instance.AddPointPickUp();
            PlayerMovement.MoveSpeed += 0.1f;
            Destroy(gameObject);
        }
    }
}
