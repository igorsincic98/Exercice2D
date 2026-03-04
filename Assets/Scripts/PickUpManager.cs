using System;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public int _score;
    [SerializeField] private AudioClip _pickUpSound;

    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(_pickUpSound, transform.position, 2f);
            Debug.Log("Pick Up !");
            ScoreManager.instance.AddPointPickUp();
            Destroy(gameObject);
        }
    }
}
