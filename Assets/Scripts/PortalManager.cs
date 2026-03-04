using System;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public bool _isOpen = false;
    public GameManager _gameManager;
    public SpriteRenderer SpriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenPortal()
    {
        _isOpen = true;
        SpriteRenderer.color = Color.green;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.CompareTag("Player")) && (_isOpen))
        {
            _gameManager.Pause();
            Debug.Log(other.gameObject.name);
            _gameManager._gameOver();
        }
    }
}
